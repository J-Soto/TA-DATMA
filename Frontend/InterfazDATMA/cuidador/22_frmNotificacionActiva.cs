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
using MaterialSkin;

namespace InterfazDATMA
{
    public partial class frmNotificacionActiva : MaterialSkin.Controls.MaterialForm
    {
        public MaterialSkinManager ThemeManager = MaterialSkinManager.Instance;
        public frmNotificacionActiva()
        {
            InitializeComponent();
            Design.Ini(this);
            if (Design.tema == 'd') ThemeManager.Theme = MaterialSkinManager.Themes.DARK;
            else ThemeManager.Theme = MaterialSkinManager.Themes.LIGHT;
        }


        private void btnAceptar_Click_1(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;

        }
    }
}
