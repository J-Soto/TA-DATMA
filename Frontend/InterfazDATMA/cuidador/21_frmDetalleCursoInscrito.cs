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

namespace InterfazDATMA
{
    public partial class frmDetalleCursoInscrito : MaterialSkin.Controls.MaterialForm 
    {
        public frmListaCursoInscritos formAnterior;

        public MaterialSkinManager ThemeManager = MaterialSkinManager.Instance;
        private frmPlantillaGestion plantillaGestion;
        private CursoWS.curso curso;
        private CursoWS.CursoWSClient daoCurso = new CursoWS.CursoWSClient();
        private ActividadWS.ActividadWSClient daoAct = new ActividadWS.ActividadWSClient();
        private List<CursoWS.semana> semanas = null;
        private List<List<ActividadWS.actividad>> actividades = null;

        public frmDetalleCursoInscrito(frmListaCursoInscritos formAnterior,frmPlantillaGestion plantillaGestion, CursoWS.curso curso)
        {
            InitializeComponent();
            Design.Ini(this);
            if (Design.tema == 'd') ThemeManager.Theme = MaterialSkinManager.Themes.DARK;
            else ThemeManager.Theme = MaterialSkinManager.Themes.LIGHT;
            this.formAnterior = formAnterior;
            this.plantillaGestion = plantillaGestion;
            this.curso = curso;

            TableStyles.CopyStyles(dgvSemanas);
            TableStyles.CopyStyles(dgvActividades);

            dgvSemanas.AutoGenerateColumns = false;
            dgvActividades.AutoGenerateColumns = false;

            // obtener semanas y actividades
            var temp = daoCurso.listarSemanasPorIdCurso(curso.idCurso);
            if (temp is object)
            {
                semanas = new List<CursoWS.semana>(temp);
                actividades = new List<List<ActividadWS.actividad>>();
                foreach (var semana in semanas)
                {
                    var acti = daoAct.listarActividadesIdSemana(semana.id);
                    if (acti is object)
                    {
                        actividades.Add(new List<ActividadWS.actividad>(acti));
                    } else
                    {
                        actividades.Add(new List<ActividadWS.actividad>());
                    }
                }
            }

            dgvSemanas.DataSource = semanas;
            dgvActividades.DataSource = actividades[0];
            txtSemanaDescripcion.Text = semanas[0].descripcion;
            txtNombreCurso.Text = "Curso: " + curso.descripcion;
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            plantillaGestion.abrirFormulario(formAnterior);
        }

        private void dgvSemanas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            txtSemanaDescripcion.Text = semanas[index].descripcion;
            dgvActividades.DataSource = actividades[index];
        }

        private void btnMaterial_Click(object sender, EventArgs e)
        {
            int semanaInd = dgvSemanas.CurrentCell.RowIndex, actInd = dgvActividades.CurrentCell.RowIndex;
            var activ = actividades[semanaInd][actInd];
            plantillaGestion.abrirFormulario(new frmDetalleCursoInscritoMaterial(this, plantillaGestion, curso.descripcion, activ));
        }

        private void btnReuniones_Click(object sender, EventArgs e)
        {
            int semanaInd = dgvSemanas.CurrentCell.RowIndex, actInd = dgvActividades.CurrentCell.RowIndex;
            var activ = actividades[semanaInd][actInd];
            plantillaGestion.abrirFormulario(new frmDetalleCursoInscritoReunion(this, plantillaGestion, activ.linkZoom));
        }
    }
}
