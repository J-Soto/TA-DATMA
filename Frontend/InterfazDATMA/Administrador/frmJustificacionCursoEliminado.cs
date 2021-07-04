using InterfazDATMA.util;
using MaterialSkin;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InterfazDATMA.Administrador
{
    public partial class frmJustificacionCursoEliminado : MaterialSkin.Controls.MaterialForm
    {
        public MaterialSkinManager ThemeManager = MaterialSkinManager.Instance;
        public frmJustificacionCursoEliminado()
        {
            InitializeComponent();
            Design.Ini(this);
            if (Design.tema == 'd') ThemeManager.Theme = MaterialSkinManager.Themes.DARK;
            else ThemeManager.Theme = MaterialSkinManager.Themes.LIGHT;
        }
    }
}
