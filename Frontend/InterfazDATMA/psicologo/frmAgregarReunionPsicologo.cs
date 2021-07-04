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
using MaterialSkin;

namespace InterfazDATMA
{
    public partial class frmAgregarReunionPsicologo : MaterialSkin.Controls.MaterialForm
    {

        public MaterialSkinManager ThemeManager = MaterialSkinManager.Instance;
        public frmAgregarReunionPsicologo()
        {
            InitializeComponent();
            Design.Ini(this);
            if (Design.tema == 'd') ThemeManager.Theme = MaterialSkinManager.Themes.DARK;
            else ThemeManager.Theme = MaterialSkinManager.Themes.LIGHT;
            dtpInicio.Format = DateTimePickerFormat.Short;
            dtpFin.Format= DateTimePickerFormat.Short;

            dtpFechaReunion.Format = DateTimePickerFormat.Short;

        }

    }
}
