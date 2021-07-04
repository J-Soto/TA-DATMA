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
using MaterialSkin;

namespace InterfazDATMA.Administrador
{
    public partial class frmOperacionesCursos : MaterialSkin.Controls.MaterialForm 
    {
        private frmPlantillaGestion formPlantillaGest;
        private frmGestionarModuloAdmin formGestionarModuloAdmin;

        public MaterialSkinManager ThemeManager = MaterialSkinManager.Instance;
        private CursoWS.CursoWSClient daoCurso;
        private GrupoWS.GrupoWSClient daoGrupo;
        private SemanaWS.SemanaWSClient daoSemana;
        private PsicologoWS.PsicologoWSClient daoPsicologo;
        private UsuarioWS.UsuarioWSClient daoUsuario;
        private BindingList<CursoWS.curso> cursos;

        public frmOperacionesCursos(frmGestionarModuloAdmin formGestionarModuloAdmin, frmPlantillaGestion formPlantillaGest)
        {
            this.formGestionarModuloAdmin = formGestionarModuloAdmin;
            this.formPlantillaGest = formPlantillaGest;
            this.daoCurso = new CursoWS.CursoWSClient();
            this.daoGrupo = new GrupoWS.GrupoWSClient();
            this.daoSemana = new SemanaWS.SemanaWSClient();
            this.daoPsicologo = new PsicologoWS.PsicologoWSClient();
            this.daoUsuario = new UsuarioWS.UsuarioWSClient();
            this.DoubleBuffered = true;
            InitializeComponent();

            Design.Ini(this);
            if (Design.tema == 'd') ThemeManager.Theme = MaterialSkinManager.Themes.DARK;
            else ThemeManager.Theme = MaterialSkinManager.Themes.LIGHT;
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

        private int eliminarCursoSeleccionado(int idCurso,string mensaje)
        {
            int resultado = 0;
            try
            {
                //Lista temas existentes en curso
                BindingList<CursoWS.tema> temasExistentes;
                try
                {
                    temasExistentes = new BindingList<CursoWS.tema>(daoCurso.listarTemasPorIdCurso(idCurso).ToList());
                }
                catch (Exception) {
                    temasExistentes = new BindingList<CursoWS.tema>();
                }
                //Elimina la lista de temas ya existentes en el curso
                foreach (CursoWS.tema item in temasExistentes)
                {
                    daoCurso.eliminarCursoTema(item.id_curso_tema);
                }
                //LLena la lista de psicologos ya existentes en el curso
                BindingList<PsicologoWS.psicologo> psiExistentes;
                try
                {
                    psiExistentes = new BindingList<PsicologoWS.psicologo>(daoPsicologo.listarPsicologosPorIdCurso(idCurso).ToList());
                }
                catch (Exception)
                {
                    psiExistentes = new BindingList<PsicologoWS.psicologo>();
                }
                //Eliminar lista de psicologos ya existentes
                foreach (PsicologoWS.psicologo item in psiExistentes)
                {
                    daoCurso.eliminarPsicologoCurso(item.idPersona, idCurso);
                }
                //Listar semanas de un curso
                BindingList<CursoWS.semana> semanasExistentes;
                try
                {
                    semanasExistentes = new BindingList<CursoWS.semana>(daoCurso.listarSemanasPorIdCurso(idCurso).ToList());
                }
                catch (Exception) 
                {
                    semanasExistentes = new BindingList<CursoWS.semana>();
                }
                //Elimina las semanas ya existentes
                foreach (CursoWS.semana item in semanasExistentes)
                {
                    daoSemana.eliminarSemana(item.id);
                }
                //listar grupos del curso
                BindingList<CursoWS.grupo> gruposExistentes = null;
                try
                {
                    gruposExistentes = new BindingList<CursoWS.grupo>(daoCurso.listarGruposPorIdCurso(idCurso).ToList());
                    foreach (CursoWS.grupo item in gruposExistentes)
                    {
                        //LLena la lista de psicologos ya existentes en el grupo
                        BindingList<GrupoWS.psicologo> psicologosExistentes;
                        try
                        {
                            psicologosExistentes = new BindingList<GrupoWS.psicologo>(daoGrupo.listarPsicologosPorIdGrupo(item.idGrupo).ToList());
                        }
                        catch (Exception)
                        {
                            psicologosExistentes = new BindingList<GrupoWS.psicologo>();
                        }
                        //Elimina la lista de psicologos ya existentes en el grupo
                        foreach (GrupoWS.psicologo psi in psicologosExistentes)
                        {
                            daoUsuario.enviarDatosUsuario(psi.correo,psi.user,psi.password,psi.nombre+" "+psi.apellidoPaterno+" "+psi.apellidoMaterno,
                                mensaje,2);
                            daoGrupo.eliminarGrupoPsicologo(psi.idPersona, item.idGrupo);
                        }
                        //LLena la lista de tutores ya existentes en el grupo
                        BindingList<GrupoWS.tutor> tutoresExistentes;
                        try
                        {
                            tutoresExistentes = new BindingList<GrupoWS.tutor>(daoGrupo.listarTutoresPorIdGrupo(item.idGrupo).ToList());
                        }
                        catch (Exception)
                        {
                            tutoresExistentes = new BindingList<GrupoWS.tutor>();
                        }
                        //Elimina la lista de tutores ya existentes en el grupo
                        foreach (GrupoWS.tutor tut in tutoresExistentes)
                        {
                            daoUsuario.enviarDatosUsuario(tut.correo, tut.user, tut.password, tut.nombre + " " + tut.apellidoPaterno + " " +
                                tut.apellidoMaterno, mensaje, 2);
                            daoGrupo.eliminarGrupoTutor(tut.idPersona, item.idGrupo);
                        }
                    }
                }
                catch (Exception) {}

                resultado = daoCurso.eliminarCurso(idCurso);
            }
            catch (Exception)
            {
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

            if (nTutores >= 0)
            {/*
                var rpt = MessageBox.Show("¿Desea eliminar el curso seleccionado?", "Mensaje de Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (rpt == DialogResult.Yes)
                {
                    eliminarCursoSeleccionado(cursos[index].idCurso);
                    cursos.RemoveAt(index);
                    UpdateCursosTable();
                }*/
                frmJustificacionCursoEliminado formJustificacion = new frmJustificacionCursoEliminado(nTutores,cursos[index].descripcion);
                if (formJustificacion.ShowDialog() == DialogResult.OK)
                {
                    int resultado = eliminarCursoSeleccionado(cursos[index].idCurso, formJustificacion.mensaje);
                    if (resultado == 1)
                    {
                        MessageBox.Show("Curso eliminado con exito.", "Mensaje de Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        cursos.RemoveAt(index);
                        UpdateCursosTable();
                    }
                }
            }
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            formPlantillaGest.abrirFormulario(formGestionarModuloAdmin);
        }
    }
}
