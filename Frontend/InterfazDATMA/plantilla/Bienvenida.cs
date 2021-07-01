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
namespace InterfazDATMA.plantilla
{
    public partial class Bienvenida : MaterialSkin.Controls.MaterialForm
    {
        public Bienvenida()
        {
            InitializeComponent();
            Design.Ini(this);
        }
    }
}
