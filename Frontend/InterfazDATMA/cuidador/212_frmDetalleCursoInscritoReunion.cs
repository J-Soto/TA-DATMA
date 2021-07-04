using MaterialSkin.Controls;
using InterfazDATMA.plantilla;
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
    public partial class frmDetalleCursoInscritoReunion : MaterialSkin.Controls.MaterialForm 
    {
        public frmDetalleCursoInscrito formAnterior;
        private frmPlantillaGestion plantillaGestion;

        public MaterialSkinManager ThemeManager = MaterialSkinManager.Instance;
        public frmDetalleCursoInscritoReunion(frmDetalleCursoInscrito formAnterior, frmPlantillaGestion plantillaGestion, string link)
        {
            InitializeComponent();
            Design.Ini(this);
            if (Design.tema == 'd') ThemeManager.Theme = MaterialSkinManager.Themes.DARK;
            else ThemeManager.Theme = MaterialSkinManager.Themes.LIGHT;
            this.plantillaGestion = plantillaGestion;
            this.formAnterior = formAnterior;
            txtZoom.Text = link;
        }

        private void Regresar_Click(object sender, EventArgs e)
        {
            plantillaGestion.abrirFormulario(formAnterior);
        }

        private void txtZoom_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            txtZoom.LinkVisited = true;
            System.Diagnostics.Process.Start(txtZoom.Text);
        }
    }
}
