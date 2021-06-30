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

namespace InterfazDATMA
{
    public partial class frmInformacionCurso : MaterialSkin.Controls.MaterialForm 
    {
        public frmCursosDisponibles formAnterior;
        private frmPlantillaGestion plantillaGestion;

        private CursoWS.CursoWSClient daoCurso = new CursoWS.CursoWSClient();
        private ActividadWS.ActividadWSClient daoAct = new ActividadWS.ActividadWSClient();
        private List<ActividadWS.actividad> actividades = new List<ActividadWS.actividad>();

        private CursoTutor cursoTutor;
        private DateTime daterunner;
        public frmInformacionCurso(frmCursosDisponibles formAnterior, frmPlantillaGestion plantillaGestion, CursoTutor cursoTutor)
        {
            InitializeComponent();
            Design.Ini(this);
            dgvInfCurso.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvInfCurso.AutoGenerateColumns = false;

            this.formAnterior = formAnterior;
            this.plantillaGestion = plantillaGestion;
            this.cursoTutor = cursoTutor;
            daterunner = cursoTutor.FechaInicio;

            // obtener actividades
            var semanas = daoCurso.listarSemanasPorIdCurso(cursoTutor.Curso.idCurso);
            if (semanas is object)
            {
                foreach (var semana in semanas)
                {
                    var newact = daoAct.listarActividadesIdSemana(semana.id);
                    if (newact is object)
                    {
                        actividades.AddRange(newact);
                    }
                }
            }

            LlenarInformacion();
        }

        public void LlenarInformacion()
        {
            lblNombreModulo.Text = cursoTutor.Modulo;
            lblInformacionEncargada.Text = cursoTutor.Encargado;
            nDateTimeBoxControl2.SelectedDate = cursoTutor.FechaInicio;
            nDateTimeBoxControl1.SelectedDate = cursoTutor.FechaFin;
            ActualizarFechaStr();
            if (cursoTutor.Psicologo.fotoPerfil is object)
            {
                pictBoxEncargada.Image = (Bitmap)((new ImageConverter()).ConvertFrom(cursoTutor.Psicologo.fotoPerfil));
            }
            ActualizarActividades();
        }

        private void ActualizarFechaStr()
        {
            materialLabel4.Text = daterunner.ToString("MMMM").ToUpper() + " 2021";
        }

        private void ActualizarActividades()
        {
            var temp = new List<ActividadWS.actividad>(actividades);
            temp.RemoveAll(item => item.fecha.Month != daterunner.Month);
            dgvInfCurso.DataSource = temp;
        }

        private void btnVerMas_Click(object sender, EventArgs e)
        {
            plantillaGestion.abrirFormulario(new frmDetalleCurso(this, plantillaGestion));
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            if (daterunner.Month - cursoTutor.FechaInicio.Month > 0)
            {
                daterunner = daterunner.AddMonths(-1);
                ActualizarFechaStr();
                ActualizarActividades();
            }
        }

        private void btnSig_Click(object sender, EventArgs e)
        {
            if (cursoTutor.FechaFin.Month - daterunner.Month > 0)
            {
                daterunner = daterunner.AddMonths(1);
                ActualizarFechaStr();
                ActualizarActividades();
            }
        }
    }
}
