using InterfazDATMA.MaterialWS;
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
using InterfazDATMA.util;
using MaterialSkin;

namespace InterfazDATMA.psicologo
{
    public partial class frmInsertarDocumento : MaterialSkin.Controls.MaterialForm
    {
        private MaterialWS.documento documento = null;
        private byte[] auxBytes = null;

        public documento Documento { get => documento; set => documento = value; }

        public frmInsertarDocumento()
        {
            InitializeComponent();
            Design.Ini(this);
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            documento = new MaterialWS.documento();

            if(auxBytes == null)
            {
                MessageBox.Show("Debe subir un archivo","Mensaje de Advertencia",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            else
            {
                documento.docPDF = auxBytes;
                documento.descripcion = txtDescripcion.Text;

                this.DialogResult = DialogResult.OK;
            }
        }

        private void btnSubirArchivo_Click(object sender, EventArgs e)
        {

            try
            {
                if(ofdBuscarDoc.ShowDialog() == DialogResult.OK)
                {
                    string ruta = ofdBuscarDoc.FileName;
                    txtRutaArchivo.Text = ruta;
                    FileStream archivo = new FileStream(ruta,FileMode.Open,FileAccess.Read);
                    BinaryReader br = new BinaryReader(archivo);
                    auxBytes = br.ReadBytes((int) archivo.Length);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Debe introducir un documento valido (PDF)", "Mensaje de advertencia", MessageBoxButtons.OK,MessageBoxIcon.Information);
            }

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
    }
}
