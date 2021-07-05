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
        public string mensaje;
        public string n;
        public MaterialSkinManager ThemeManager = MaterialSkinManager.Instance;
        public frmJustificacionCursoEliminado(int nTutores,string nombreCruso)
        {
            InitializeComponent();
            Design.Ini(this);
            if (Design.tema == 'd') ThemeManager.Theme = MaterialSkinManager.Themes.DARK;
            else ThemeManager.Theme = MaterialSkinManager.Themes.LIGHT;
            n = nombreCruso;
            lbl1.WidgetText = "Seguro que quiere eliminar el curso? hay  " + nTutores.ToString() + "  tutores inscritos";
            
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (txt.Text != "")
            {
                mensaje = n +" "+txt.Text;
                DialogResult = DialogResult.OK;
            }
            else
                MessageBox.Show("Debe ingresar una justificacion.", "Mensaje de alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }

}
