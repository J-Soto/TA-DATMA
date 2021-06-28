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

        private CursoTutor cursoTutor;
      
        public frmInformacionCurso(frmCursosDisponibles formAnterior, frmPlantillaGestion plantillaGestion, CursoTutor cursoTutor)
        {
            InitializeComponent();
            Design.Ini(this);
            dgvInfCurso.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvInfCurso.AutoGenerateColumns = false;

            this.formAnterior = formAnterior;
            this.plantillaGestion = plantillaGestion;
            this.cursoTutor = cursoTutor;

            LlenarInformacion();
        }

        private void LlenarInformacion()
        {
            lblNombreModulo.Text = cursoTutor.Modulo;
            lblInformacionEncargada.Text = cursoTutor.Encargado;
            if (cursoTutor.Psicologo.fotoPerfil is object)
            {
                pictBoxEncargada.Image = (Bitmap)((new ImageConverter()).ConvertFrom(cursoTutor.Psicologo.fotoPerfil));
            }
        }

        private void frmInformacionCurso_Load(object sender, EventArgs e)
        {

        }

        private void btnVerMas_Click(object sender, EventArgs e)
        {
            //plantillaGestion.abrirFormulario(new frmDetalleCurso(this, plantillaGestion));
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {

        }

        private void btnSig_Click(object sender, EventArgs e)
        {

        }
    }
}
