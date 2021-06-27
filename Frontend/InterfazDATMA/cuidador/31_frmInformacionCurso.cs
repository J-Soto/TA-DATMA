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

        private PsicologoWS.PsicologoWSClient daoPsicologo;
        private CursoWS.CursoWSClient daoCurso;
        private CursoWS.curso curso;
      
        public frmInformacionCurso(frmCursosDisponibles formAnterior, frmPlantillaGestion plantillaGestion)
        {
            InitializeComponent();
            Design.Ini(this);
            dgvInfCurso.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvInfCurso.AutoGenerateColumns = false;

            this.formAnterior = formAnterior;
            this.plantillaGestion = plantillaGestion;
            this.daoCurso = new CursoWS.CursoWSClient();
            this.daoPsicologo = new PsicologoWS.PsicologoWSClient();

            llenar_informacion();
        }

        public void llenar_informacion()
        {
            BindingList<CursoWS.curso> lCursos = null;
            try
            {
                lCursos = new BindingList<CursoWS.curso>(daoCurso.listarCursos().ToList());
                //hACER lISTAR CURSOS POR ID
                for (int i = 0; i < lCursos.Count; i++)
                {
                    if (lCursos[i].idCurso == this.curso.idCurso)
                    {
                        this.curso = lCursos[i];
                        break;
                    }
                }
                lblNombreModulo.Text = this.curso.descripcion;
                BindingList<PsicologoWS.psicologo> lPsi = null;
                try
                {
                    lPsi = new BindingList<PsicologoWS.psicologo>(daoPsicologo.listarPsicologosPorIdCurso(this.curso.idCurso).ToList());
                    PsicologoWS.psicologo psicologo = lPsi[0];
                    lblInformacionEncargada.Text = psicologo.nombre + " " + psicologo.apellidoPaterno + " " + psicologo.apellidoMaterno;

                    try
                    {

                    }
                    catch (Exception)
                    {

                        throw;
                    }
                }
                catch (Exception)
                {

                    throw;
                }
            }
            catch (ArgumentNullException)
            {
                throw;
            }
        }

        private void frmInformacionCurso_Load(object sender, EventArgs e)
        {

        }

        private void btnVerMas_Click(object sender, EventArgs e)
        {
            plantillaGestion.abrirFormulario(new frmDetalleCurso(this, plantillaGestion));

        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {

        }

        private void txtBoxFechaFin_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtBoxFechaIni_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSig_Click(object sender, EventArgs e)
        {

        }
    }
}
