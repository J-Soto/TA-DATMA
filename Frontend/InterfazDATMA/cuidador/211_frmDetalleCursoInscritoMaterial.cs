using MaterialSkin.Controls;
using InterfazDATMA.plantilla;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

using InterfazDATMA.util;
using MaterialSkin;

namespace InterfazDATMA
{
    public partial class frmDetalleCursoInscritoMaterial : MaterialSkin.Controls.MaterialForm 
    {
        public frmDetalleCursoInscrito formAnterior;

        public MaterialSkinManager ThemeManager = MaterialSkinManager.Instance;
        private frmPlantillaGestion plantillaGestion;
        //private ActividadWS.actividad act;
        private ActividadWS.ActividadWSClient actDao = new ActividadWS.ActividadWSClient();
        private List<ActividadWS.documento> docs = new List<ActividadWS.documento>();
        private List<ActividadWS.video> videos = new List<ActividadWS.video>();

        public frmDetalleCursoInscritoMaterial(frmDetalleCursoInscrito formAnterior,frmPlantillaGestion plantillaGestion, string curso, ActividadWS.actividad act)
        {
            InitializeComponent();
            Design.Ini(this);
            if (Design.tema == 'd') ThemeManager.Theme = MaterialSkinManager.Themes.DARK;
            else ThemeManager.Theme = MaterialSkinManager.Themes.LIGHT;
            this.formAnterior = formAnterior;
            this.plantillaGestion = plantillaGestion;
            //this.act = act;
            NombreCurso.Text = curso;
            // obtener material
            var temp = actDao.listarVideosPorIdActividad(act.idActividad);
            if (temp is object)
            {
                videos = new List<ActividadWS.video>(temp);
            }
            var temp1 = actDao.listarDocumentosPorIdActividad(act.idActividad);
            if (temp1 is object)
            {
                docs = new List<ActividadWS.documento>(temp1);
            }
            dgvDocumentos.AutoGenerateColumns = false;
            dgvVideos.AutoGenerateColumns = false;
            dgvDocumentos.DataSource = docs;
            dgvVideos.DataSource = videos;
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            plantillaGestion.abrirFormulario(formAnterior);
        }

        private void dgvDocumentos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int col = e.ColumnIndex, row = e.RowIndex;
            if (col == 1)
            {
                var sf = new SaveFileDialog
                {
                    Filter = "Archivo PDF (*.pdf)|*.pdf",
                    Title = "Guardar documento..."
                };

                if (sf.ShowDialog() == DialogResult.OK)
                {
                    using (var fs = new FileStream(sf.FileName, FileMode.Create))
                    {
                        // get bytes from text you want to save
                        byte[] data = docs[row].docPDF;
                        fs.Write(data, 0, data.Length);
                        fs.Flush();
                    }
                }
            }
        }

        private void dgvVideos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int col = e.ColumnIndex, row = e.RowIndex;
            if (col == 2)
            {
                System.Diagnostics.Process.Start(videos[row].linkVideo);
            }
        }
    }
}
