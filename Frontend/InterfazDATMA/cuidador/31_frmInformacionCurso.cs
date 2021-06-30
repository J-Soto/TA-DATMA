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
        }

        private void ActualizarFechaStr()
        {
            materialLabel4.Text = daterunner.ToString("MMMM").ToUpper() + " 2021";
        }

        private void btnVerMas_Click(object sender, EventArgs e)
        {
            plantillaGestion.abrirFormulario(new frmDetalleCurso(this, plantillaGestion));
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            if (daterunner.Month - cursoTutor.FechaInicio.Month > 0)
            {
                daterunner.AddMonths(-1);
                ActualizarFechaStr();
            }
        }

        private void btnSig_Click(object sender, EventArgs e)
        {
            if (cursoTutor.FechaFin.Month - daterunner.Month > 0)
            {
                daterunner.AddMonths(1);
                ActualizarFechaStr();
            }
        }
    }
}
