using MaterialSkin.Controls;

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
    public partial class frmAgregarReunionPsicologo : MaterialSkin.Controls.MaterialForm 
    {
        public frmAgregarReunionPsicologo()
        {
            InitializeComponent();
            MaterialSkin.MaterialSkinManager skinManager = MaterialSkin.MaterialSkinManager.Instance;
            skinManager.AddFormToManage(this);
            skinManager.Theme = MaterialSkin.MaterialSkinManager.Themes.DARK;
            skinManager.ColorScheme = new MaterialSkin.ColorScheme(MaterialSkin.Primary.BlueGrey500, MaterialSkin.Primary.BlueGrey700, MaterialSkin.Primary.BlueGrey100, MaterialSkin.Accent.Teal700, MaterialSkin.TextShade.WHITE);

            dtpInicio.CustomFormat = "hh:mm tt";
            dtpInicio.Format = DateTimePickerFormat.Custom;
            dtpInicio.ShowUpDown = true;

            dtpFin.CustomFormat = "hh:mm tt";
            dtpFin.Format = DateTimePickerFormat.Custom;
            dtpFin.ShowUpDown = true;

            dtpFechaReunion.CustomFormat = "dd/MM/yyyy";
            dtpFechaReunion.Format = DateTimePickerFormat.Custom;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
