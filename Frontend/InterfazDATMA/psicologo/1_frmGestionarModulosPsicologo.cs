using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using InterfazDATMA;
using InterfazDATMA.plantilla;
using InterfazDATMA.util;
using MaterialSkin.Controls;


namespace InterfazDATMA
{
    public partial class frmGestionarModulosPsicologo : MaterialSkin.Controls.MaterialForm 
    {
        private frmPlantillaGestion plantillaGestion;
        private PsicologoWS.PsicologoWSClient daoPsicologo;
        private CursoWS.CursoWSClient daoCurso;
        private ActividadWS.ActividadWSClient daoActividad;

        //cursos:
        private BindingList<CursoWS.curso> cursos;
        private BindingList<Psicologo_Curso> cursosGrupos; //Contiene el idgrupo y el idcurso (Activos)
        private BindingList<Psicologo_Curso> cursosFinalizado; //(Finalizados)
        

        //actividades
        private BindingList <ActividadWS.actividad> actividades;


        //psicologo:
        private PsicologoWS.psicologo psicologo;
        public frmGestionarModulosPsicologo(frmPlantillaGestion plantilla)
        {
            InitializeComponent();
            Design.Ini(this);
            plantillaGestion = plantilla;
            daoPsicologo = new PsicologoWS.PsicologoWSClient();
            daoCurso = new CursoWS.CursoWSClient();
            daoActividad = new ActividadWS.ActividadWSClient();
            // obtener psicolog a partir del usuario
            //var psicologos = daoPsicologo.listarTodosPsicologos();
            //foreach (var psico in psicologos)
            //{
            //    if (psico.idUsuario == frmPlantillaGestion.user.idUsuario)
            //    {
            //        frmPlantillaGestion.psico = psico;
            //        break;
            //    }
            //}


            psicologo = daoPsicologo.buscarPsicologoPorIdUsuario(frmPlantillaGestion.user.idUsuario);
            frmPlantillaGestion.psico = psicologo;


            // obtener cursos del psicologo

            dgvModulos.AutoGenerateColumns = false;
            dgvFinalizado.AutoGenerateColumns = false;
            try
            {
                cursos = new BindingList<CursoWS.curso>(daoCurso.listarCursosPsicologo(psicologo.idPersona));
            }
            catch (ArgumentNullException)
            {
                cursos = new BindingList<CursoWS.curso>();
            }


            cursosGrupos = new BindingList<Psicologo_Curso>();
            cursosFinalizado = new BindingList<Psicologo_Curso>();

            BindingList<CursoWS.grupo> grupos;

            foreach (CursoWS.curso recCurso in cursos)
            {
                grupos = new BindingList<CursoWS.grupo>(daoCurso.listarCursosGrupoPsicologo(psicologo.idPersona, recCurso.idCurso).ToList());
                foreach (CursoWS.grupo recGrupo in grupos)
                {
                    Psicologo_Curso auxCurso = new Psicologo_Curso();
                    auxCurso.Curso = new CursoWS.curso();
                    auxCurso.Curso.idCurso = recCurso.idCurso;
                    auxCurso.Curso.descripcion = recCurso.descripcion;
                    auxCurso.Curso.fechaInicio = recCurso.fechaInicio;
                    auxCurso.Curso.fechaFin = recCurso.fechaFin;
                    auxCurso.Grupo = recGrupo;

                    if (recCurso.fechaFin.Date < DateTime.Now.Date) cursosFinalizado.Add(auxCurso);
                    else cursosGrupos.Add(auxCurso);
                }
            }


            dgvModulos.DataSource = cursosGrupos;
            dgvFinalizado.DataSource = cursosFinalizado;
        }


        private void AccederModulo_Click(object sender, EventArgs e)
        {
            if(dgvModulos.RowCount != 0)
            {
                Psicologo_Curso auxCurso = dgvModulos.CurrentRow.DataBoundItem as Psicologo_Curso;

                var frmConfig = new frmConfigurarModuloPsicologo(this, plantillaGestion, auxCurso);
                plantillaGestion.abrirFormulario(frmConfig);
            }
        }

        private void frmGestionarModulosPsicologo_Load(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
        
        }

        private void dgvModulos_CellFormatting_1(object sender, DataGridViewCellFormattingEventArgs e)
        {
            Psicologo_Curso psicologo_Curso = dgvModulos.Rows[e.RowIndex].DataBoundItem as Psicologo_Curso;

            dgvModulos.Rows[e.RowIndex].Cells["Curso"].Value = psicologo_Curso.Curso.descripcion;
            dgvModulos.Rows[e.RowIndex].Cells["Grupo"].Value = psicologo_Curso.Grupo.nombrePromocion;
            dgvModulos.Rows[e.RowIndex].Cells["FechaInicio"].Value = psicologo_Curso.Curso.fechaInicio;
            dgvModulos.Rows[e.RowIndex].Cells["FechaFin"].Value = psicologo_Curso.Curso.fechaFin;
        }

        private void dgvFinalizado_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            Psicologo_Curso auxPsicologo_Curso = dgvFinalizado.Rows[e.RowIndex].DataBoundItem as Psicologo_Curso;

            dgvFinalizado.Rows[e.RowIndex].Cells["CursoFinalizado"].Value = auxPsicologo_Curso.Curso.descripcion;
            dgvFinalizado.Rows[e.RowIndex].Cells["GrupoFinalizado"].Value = auxPsicologo_Curso.Grupo.nombrePromocion;
            dgvFinalizado.Rows[e.RowIndex].Cells["FechaInicioFinalizado"].Value = auxPsicologo_Curso.Curso.fechaInicio;
            dgvFinalizado.Rows[e.RowIndex].Cells["FechaFinFinalizado"].Value = auxPsicologo_Curso.Curso.fechaFin;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
