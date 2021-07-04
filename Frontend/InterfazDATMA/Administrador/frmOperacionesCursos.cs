using MaterialSkin.Controls;
using InterfazDATMA.plantilla;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using InterfazDATMA.util;

namespace InterfazDATMA.Administrador
{
    public partial class frmOperacionesCursos : MaterialSkin.Controls.MaterialForm 
    {
        private frmPlantillaGestion formPlantillaGest;
        private frmGestionarModuloAdmin formGestionarModuloAdmin;
        private CursoWS.CursoWSClient daoCurso;
        private GrupoWS.GrupoWSClient daoGrupo;
        private BindingList<CursoWS.curso> cursos;

        public frmOperacionesCursos(frmGestionarModuloAdmin formGestionarModuloAdmin, frmPlantillaGestion formPlantillaGest)
        {
            this.formGestionarModuloAdmin = formGestionarModuloAdmin;
            this.formPlantillaGest = formPlantillaGest;
            this.daoCurso = new CursoWS.CursoWSClient();
            this.daoGrupo = new GrupoWS.GrupoWSClient();
            this.DoubleBuffered = true;
            InitializeComponent();

            Design.Ini(this);
            dgvCursos.AutoGenerateColumns = false;
            dgvCursos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            FetchCursos();
            UpdateCursosTable();
        }

        private void UpdateCursosTable()
        {
            dgvCursos.Rows.Clear();
            foreach (var curso in cursos) {
                dgvCursos.Rows.Add(curso.descripcion, curso.fechaInicio, curso.fechaFin, curso.fechaInscripcion, curso.cantSemanas);
            }
        }

        private void FetchCursos()
        {
            try
            {
                cursos = new BindingList<CursoWS.curso>(daoCurso.listarCursos().ToList());
            } catch (ArgumentNullException ex)
            {
                cursos = new BindingList<CursoWS.curso>();
            }
        }

       
        private void frmOperacionesCursos_VisibleChanged(object sender, EventArgs e)
        {
            FetchCursos();
            UpdateCursosTable();
        }

        private void frmOperacionesCursos_Load(object sender, EventArgs e)
        {

        }

        private void btnInsertarCurso_Click(object sender, EventArgs e)
        {
            frmInsertarCurso formInsertarCurso = new frmInsertarCurso(this, formPlantillaGest);
            formPlantillaGest.abrirFormulario(formInsertarCurso);


        }

        private int eliminarCursoSeleccionado(int idCurso)
        {
            int resultado = 0;
            try
            {
                //Lista temas existentes en curso
                BindingList<CursoWS.tema> temasExistentes = null;
                try
                {
                    temasExistentes = new BindingList<CursoWS.tema>(daoCurso.listarTemasPorIdCurso(idCurso).ToList());
                }
                catch (Exception) {}
                //Elimina la lista de temas ya existentes en el curso
                foreach (CursoWS.tema item in temasExistentes)
                {
                    daoCurso.eliminarCursoTema(item.id_curso_tema);
                }
                resultado = daoCurso.eliminarCurso(idCurso);
            }
            catch (Exception)
            {

                throw;
            }
            return resultado;
            
        }

        private void btnEliminarCurso_Click(object sender, EventArgs e)
        {
            //Verificar Tutores inscritos en curso
            var index = dgvCursos.CurrentCell.RowIndex;
            BindingList<CursoWS.grupo> lGrupos = null;
            int nTutores = 0;
            try
            {
                //Verifica grupos
                lGrupos = new BindingList<CursoWS.grupo>(daoCurso.listarGruposPorIdCurso(index).ToList());
                foreach (CursoWS.grupo item in lGrupos)
                {
                    BindingList<GrupoWS.tutor> lTutores = null;
                    try
                    {
                        lTutores = new BindingList<GrupoWS.tutor>(daoGrupo.listarTutoresPorIdGrupo(item.idGrupo).ToList());
                        nTutores += lTutores.Count;
                    }
                    catch (Exception) {}
                    
                }
            }
            catch (Exception) {}

            if (nTutores == 0)
            {
                var rpt = MessageBox.Show("¿Desea eliminar el curso seleccionado?", "Mensaje de Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (rpt == DialogResult.Yes)
                {
                    eliminarCursoSeleccionado(cursos[index].idCurso);
                    cursos.RemoveAt(index);
                    UpdateCursosTable();
                }
            }
            else
            {
                frmJustificacionCursoEliminado formJustificacion = new frmJustificacionCursoEliminado();
                if (formJustificacion.ShowDialog() == DialogResult.OK)
                {
                    eliminarCursoSeleccionado(cursos[index].idCurso);
                    cursos.RemoveAt(index);
                    UpdateCursosTable();
                }
            }

            

            

        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            formPlantillaGest.abrirFormulario(formGestionarModuloAdmin);


        }
    }
}
