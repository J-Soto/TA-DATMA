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

using InterfazDATMA.util;
namespace InterfazDATMA
{
    public partial class frmAgregarReunionPsicologo : MaterialSkin.Controls.MaterialForm
    {

        public frmAgregarReunionPsicologo()
        {
            InitializeComponent();
            Design.Ini(this);
            dtpInicio.Format= "hh:mm tt";

            dtpFin.Format = "hh:mm tt";

            dtpFechaReunion.Format = "hh:mm tt";

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

        private void btnGuardarReunion_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void frmAgregarReunionPsicologo_Load(object sender, EventArgs e)
        {

        }
    }
}
