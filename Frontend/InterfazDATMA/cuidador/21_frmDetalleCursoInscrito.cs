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
    public partial class frmDetalleCursoInscrito : MaterialSkin.Controls.MaterialForm 
    {
        public frmListaCursoInscritos formAnterior;
        private frmPlantillaGestion plantillaGestion;
        private CursoWS.curso curso;
        private CursoWS.CursoWSClient daoCurso = new CursoWS.CursoWSClient();
        private List<CursoWS.semana> semanas = null;

        public frmDetalleCursoInscrito(frmListaCursoInscritos formAnterior,frmPlantillaGestion plantillaGestion, CursoWS.curso curso)
        {
            InitializeComponent();
            Design.Ini(this);
            this.formAnterior = formAnterior;
            this.plantillaGestion = plantillaGestion;
            this.curso = curso;
            var temp = daoCurso.listarSemanasPorIdCurso(curso.idCurso);
            dgvSemanas.AutoGenerateColumns = false;
            if (temp is object)
            {
                semanas = new List<CursoWS.semana>(temp);
                dgvSemanas.DataSource = semanas;
                txtSemanaDescripcion.Text = semanas[0].descripcion;
            }
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            plantillaGestion.abrirFormulario(formAnterior);
        }

        private void dgvSemanas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            txtSemanaDescripcion.Text = semanas[index].descripcion;
        }

        /*
        private void btnRegresar_Click(object sender, EventArgs e)
        {
            
        }

        private void btnVideos_Click(object sender, EventArgs e)
        {
            plantillaGestion.abrirFormulario(new frmDetalleCursoInscritoMaterial(this, plantillaGestion));
        }

        private void btnReuniones_Click(object sender, EventArgs e)
        {

            plantillaGestion.abrirFormulario(new frmDetalleCursoInscritoReunion(this, plantillaGestion));

        }*/


    }
}
