using InterfazDATMA.util;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InterfazDATMA.Administrador
{
    public partial class frmReportePsicologos : MaterialSkin.Controls.MaterialForm
    {
        private ReporteWS.ReporteWSClient daoReporte;
        private byte[] archivo;
        public frmReportePsicologos()
        {
            InitializeComponent();
            Design.Ini(this);
            daoReporte = new ReporteWS.ReporteWSClient();
            this.archivo = daoReporte.reportePsicologos();
            var path = Path.GetTempFileName();
            File.WriteAllBytes(path, this.archivo);
            axAcroPDF1.LoadFile(path);
        }

        private void btnReportePsi_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    String archivoGenerar = saveFileDialog1.FileName;
                    File.WriteAllBytes(archivoGenerar, this.archivo);
                    MessageBox.Show("Se ha guardado el archivo", "Mensaje de Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Se ha generado un error al momento de guardar el archivo", "Mensaje de Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
