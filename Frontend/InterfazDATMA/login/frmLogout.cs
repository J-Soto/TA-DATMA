using InterfazDATMA.util;

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

namespace InterfazDATMA.login
{
    public partial class frmLogout : MaterialSkin.Controls.MaterialForm 
    {
        public frmLogout()
        {
            InitializeComponent();

            Design.Ini(this);
        }


        private void frmLogout_Load(object sender, EventArgs e)
        {

        }


        private void lblNotificacionActiva_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bAceptar_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }
    }
}
