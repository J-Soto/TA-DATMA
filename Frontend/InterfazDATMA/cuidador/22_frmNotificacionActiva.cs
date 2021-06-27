using MaterialSkin.Controls;

using InterfazDATMA.util;
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
    public partial class frmNotificacionActiva : MaterialSkin.Controls.MaterialForm 
    {
        public frmNotificacionActiva()
        {
            InitializeComponent();
            Design.Ini(this);
        }


        private void btnAceptar_Click_1(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;

        }
    }
}
