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
    public partial class frmCursosDisponibles : MaterialSkin.Controls.MaterialForm 
    {
        public frmListaCursoInscritos formAnterior;
        private frmPlantillaGestion plantilla;

        private CursoWS.CursoWSClient daoCurso;
        private PsicologoWS.PsicologoWSClient daoPsi;
        private PsicologoWS.psicologo psicologo; 
        public frmCursosDisponibles(frmListaCursoInscritos formAnterior,frmPlantillaGestion plantilla)
        {
            InitializeComponent();
            Design.Ini(this);
            this.formAnterior = formAnterior;
            this.plantilla = plantilla;

            daoCurso = new CursoWS.CursoWSClient();
            daoPsi = new PsicologoWS.PsicologoWSClient();
            dgvCursos.AutoGenerateColumns = false;
            dgvCursos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            BindingList<CursoWS.curso> lCursos;
            try
            {
                lCursos = new BindingList<CursoWS.curso>(daoCurso.listarCursosDisponibles().ToList());
            }
            catch (ArgumentNullException)
            {
                lCursos = null;
            }
            dgvCursos.DataSource = lCursos;
            dgvCursos.Refresh();
        }

        private void frmCursosDisponibles_Load(object sender, EventArgs e)
        {

        }

        private void btnInscribirse_Click_1(object sender, EventArgs e)
        {
            plantilla.abrirFormulario(new frmInscripcionHecha(this, plantilla));

        }

        private void btnMasInfo_Click_1(object sender, EventArgs e)
        {
            plantilla.abrirFormulario(new frmInformacionCurso(this, plantilla));
        }

        private void dgvCursos_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            CursoWS.curso curso = (CursoWS.curso)dgvCursos.Rows[e.RowIndex].DataBoundItem;
            dgvCursos.Rows[e.RowIndex].Cells["Modulo"].Value = curso.descripcion;
            dgvCursos.Rows[e.RowIndex].Cells["FechaIni"].Value = curso.fechaInicio;
            dgvCursos.Rows[e.RowIndex].Cells["FechaFin"].Value = curso.fechaFin;
            BindingList<PsicologoWS.psicologo> lPsi;
            try
            {
                lPsi = new BindingList<PsicologoWS.psicologo>(daoPsi.listarPsicologosPorIdCurso(curso.idCurso).ToList());
                if (lPsi.Count != 0)
                    dgvCursos.Rows[e.RowIndex].Cells["Encargado"].Value = lPsi[0].nombre + " " + lPsi[0].apellidoPaterno + " " + lPsi[0].apellidoMaterno;
            }
            catch (Exception)
            {

                lPsi = null;
            }
            
        }
    }
}
