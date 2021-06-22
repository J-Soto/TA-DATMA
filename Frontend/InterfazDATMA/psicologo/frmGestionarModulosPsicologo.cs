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
        private BindingList<Psicologo_Curso> cursosGrupos; //Contiene el idgrupo y el idcurso

        //psicologo:
        private PsicologoWS.psicologo psicologo;

        public frmGestionarModulosPsicologo(frmPlantillaGestion plantilla)
        {
            InitializeComponent();
            MaterialSkin.MaterialSkinManager skinManager = MaterialSkin.MaterialSkinManager.Instance;
            skinManager.AddFormToManage(this);
            skinManager.Theme = MaterialSkin.MaterialSkinManager.Themes.DARK;
            skinManager.ColorScheme = new MaterialSkin.ColorScheme(MaterialSkin.Primary.BlueGrey500, MaterialSkin.Primary.BlueGrey700, MaterialSkin.Primary.BlueGrey100, MaterialSkin.Accent.Teal700, MaterialSkin.TextShade.WHITE);

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
            
            /*
            psicologo = daoPsicologo.buscarPsicologoPorIdUsuario(frmPlantillaGestion.user.idUsuario);
            frmPlantillaGestion.psico = psicologo;

            */
            // obtener cursos del psicologo
            
            dgvModulos.AutoGenerateColumns = false;
            try
            {
                cursos = new BindingList<CursoWS.curso>(daoCurso.listarCursosPsicologo(psicologo.idPersona));
            } catch (ArgumentNullException)
            {
                cursos = new BindingList<CursoWS.curso>();
            }


            cursosGrupos = new BindingList<Psicologo_Curso>();


            BindingList<CursoWS.grupo> grupos;
            /*
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

                    cursosGrupos.Add(auxCurso);
                }
            }
            */
            dgvModulos.DataSource = cursosGrupos;


            //// obtener semanas
            //var semanas = new List<CursoWS.semana>();
            //foreach (var curso in cursos)
            //{
            //    var temp = daoCurso.listarSemanasPorIdCurso(curso.idCurso);
            //    if (temp is object)
            //    {
            //        semanas.AddRange(temp);
            //    }
            //}
            //// obtener actividades
            //var actividades = new List<ActividadWS.actividad>();
            //var allActiv = daoActividad.listarActividad();
            //foreach (var semana in semanas)
            //{
            //    foreach (var activ in allActiv)
            //    {
            //        if (activ.idSemana == semana.id)
            //        {
            //            actividades.Add(activ);
            //        }
            //    }
            //}
            //dgvCalendario.AutoGenerateColumns = false;
            //dgvCalendario.DataSource = new BindingList<ActividadWS.actividad>(actividades);
        }

        private void dgvModulos_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            Psicologo_Curso psicologo_Curso = dgvModulos.Rows[e.RowIndex].DataBoundItem as Psicologo_Curso;

            dgvModulos.Rows[e.RowIndex].Cells["Curso"].Value = psicologo_Curso.Curso.descripcion;
            dgvModulos.Rows[e.RowIndex].Cells["Grupo"].Value = psicologo_Curso.Grupo.nombrePromocion;
            dgvModulos.Rows[e.RowIndex].Cells["FechaInicio"].Value = psicologo_Curso.Curso.fechaInicio;
            dgvModulos.Rows[e.RowIndex].Cells["FechaFin"].Value = psicologo_Curso.Curso.fechaFin;
        }

        private void btnAccederModulo_Click(object sender, EventArgs e)
        {

            Psicologo_Curso auxCurso = dgvModulos.CurrentRow.DataBoundItem as Psicologo_Curso;

            var frmConfig = new frmConfigurarModuloPsicologo(this, plantillaGestion, auxCurso);
            plantillaGestion.abrirFormulario(frmConfig);
        }
    }
}
