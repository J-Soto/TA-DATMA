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

namespace InterfazDATMA
{
    public partial class frmInformacionCurso : MaterialSkin.Controls.MaterialForm 
    {
        public frmCursosDisponibles formAnterior;
        private frmPlantillaGestion plantillaGestion;

        private PsicologoWS.PsicologoWSClient daoPsicologo;
        private CursoWS.CursoWSClient daoCurso;
        private CursoWS.curso curso;
        private int idCurso;
        public frmInformacionCurso(frmCursosDisponibles formAnterior, frmPlantillaGestion plantillaGestion)
        {
            InitializeComponent();
            MaterialSkin.MaterialSkinManager skinManager = MaterialSkin.MaterialSkinManager.Instance;
            skinManager.AddFormToManage(this);
            skinManager.Theme = MaterialSkin.MaterialSkinManager.Themes.DARK;
            skinManager.ColorScheme = new MaterialSkin.ColorScheme(MaterialSkin.Primary.BlueGrey500, MaterialSkin.Primary.BlueGrey700, MaterialSkin.Primary.BlueGrey100, MaterialSkin.Accent.Teal700, MaterialSkin.TextShade.WHITE);

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
                    if (lCursos[i].idCurso == this.idCurso)
                    {
                        this.curso = lCursos[i];
                        break;
                    }
                }
                lblNombreModulo.Text = this.curso.descripcion;
                txtBoxFechaIni.Text = this.curso.fechaInicio.ToString("dd/MM/yyyy");
                txtBoxFechaFin.Text = this.curso.fechaFin.ToString("dd/MM/yyyy");
                BindingList<PsicologoWS.psicologo> lPsi = null;
                try
                {
                    lPsi = new BindingList<PsicologoWS.psicologo>(daoPsicologo.listarPsicologosPorIdCurso(this.idCurso).ToList());
                    PsicologoWS.psicologo psicologo = lPsi[0];
                    lblInformacionEncargada.Text = psicologo.nombre + " " + psicologo.apellidoPaterno + " " + psicologo.apellidoMaterno;
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
    }
}
