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

namespace InterfazDATMA.Administrador
{
    public partial class frmModificarPreferencias : MaterialSkin.Controls.MaterialForm 
    {
        private frmPlantillaGestion formPlantilla;
        public frmModificarTutor formAnterior;
        private TutorWS.tutor tutor;
        public frmModificarPreferencias(frmModificarTutor formModificarTutor, frmPlantillaGestion formPlantilla, TutorWS.tutor tutor)
        {
            InitializeComponent();
            MaterialSkin.MaterialSkinManager skinManager = MaterialSkin.MaterialSkinManager.Instance;
            skinManager.AddFormToManage(this);
            skinManager.Theme = MaterialSkin.MaterialSkinManager.Themes.DARK;
            skinManager.ColorScheme = new MaterialSkin.ColorScheme(MaterialSkin.Primary.BlueGrey500, MaterialSkin.Primary.BlueGrey700, MaterialSkin.Primary.BlueGrey100, MaterialSkin.Accent.Teal700, MaterialSkin.TextShade.WHITE);

            this.tutor = tutor;
            this.formPlantilla = formPlantilla;
            this.formAnterior = formModificarTutor;

            chblDias.CheckOnClick = true;
            chblDispositivos.CheckOnClick = true;
            chblInternet.CheckOnClick = true;
            chblTurno.CheckOnClick = true;
            chblRedes.CheckOnClick = true;

            int aux = tutor.dispositivos.ToString().Length;
            for (int i = 0, j = 0; i < chblDispositivos.Items.Count && j < aux; i++, j++)
            {
                if ( tutor.dispositivos.ToString()[i] == '2')
                {
                    //Check only if they match! 
                    chblDispositivos.SetItemChecked(i, true);
                }
            }

            int aux2 = tutor.tiposConexion.ToString().Length;
            for (int i = 0, j = 0; i < chblInternet.Items.Count && j < aux2; i++, j++)
            {
                if (tutor.tiposConexion.ToString()[i] == '2')
                {
                    //Check only if they match! 
                    chblInternet.SetItemChecked(i, true);
                }
            }

            int aux3 = tutor.turno.ToString().Length;
            for (int i = 0, j = 0; i < chblTurno.Items.Count && j < aux3; i++, j++)
            {
                if (tutor.turno.ToString()[i] == '2')
                {
                    //Check only if they match! 
                    chblTurno.SetItemChecked(i, true);
                }
            }

            int aux4 = tutor.dia.ToString().Length;
            for (int i = 0, j = 0; i < chblDias.Items.Count && j < aux4; i++, j++)
            {
                if (tutor.dia.ToString()[i] == '2')
                {
                    //Check only if they match! 
                    chblDias.SetItemChecked(i, true);
                }
            }

            int aux5 = tutor.redesSociales.ToString().Length;
            for (int i = 0, j = 0; i < chblRedes.Items.Count && j < aux5; i++, j++)
            {
                if (tutor.redesSociales.ToString()[i] == '2')
                {
                    //Check only if they match! 
                    chblRedes.SetItemChecked(i, true);
                }
            }
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            formPlantilla.abrirFormulario(formAnterior);
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            formPlantilla.abrirFormulario(formAnterior.formOperacionPersona);
        }
    }
}
