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
        private TutorWS.TutorWSClient daoTutor;
        private TutorWS.tutor tutor;
        public frmModificarPreferencias(frmModificarTutor formModificarTutor, frmPlantillaGestion formPlantilla, TutorWS.tutor tutor)
        {
            InitializeComponent();
            MaterialSkin.MaterialSkinManager skinManager = MaterialSkin.MaterialSkinManager.Instance;
            skinManager.AddFormToManage(this);
            skinManager.Theme = MaterialSkin.MaterialSkinManager.Themes.DARK;
            skinManager.ColorScheme = new MaterialSkin.ColorScheme(MaterialSkin.Primary.BlueGrey500, MaterialSkin.Primary.BlueGrey700, MaterialSkin.Primary.BlueGrey100, MaterialSkin.Accent.Teal700, MaterialSkin.TextShade.WHITE);
            
            this.tutor = tutor;
            daoTutor = new TutorWS.TutorWSClient();
            this.formPlantilla = formPlantilla;
            this.formAnterior = formModificarTutor;

            chblDias.CheckOnClick = true;
            chblDispositivos.CheckOnClick = true;
            chblInternet.CheckOnClick = true;
            chblTurno.CheckOnClick = true;
            chblRedes.CheckOnClick = true;

            // Leer Dispositivos Electronicos
            for (int x = 0; x < (int)Math.Floor(Math.Log10(tutor.dispositivos) + 1); x++)
            {
                if (tutor.dispositivos.ToString()[(int)Math.Floor(Math.Log10(tutor.dispositivos)) - x] == '1')
                {
                    chblDispositivos.SetItemChecked(x, true);       // Si es 2, es false
                }
            }



        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            formPlantilla.abrirFormulario(formAnterior);
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            // Guardar Dispositivos Electronicos
            tutor.dispositivos = 0;
            if (chblDispositivos.CheckedItems.Count != 0)       // Si fue seleccionado al menos 1 dispositivo
            {
                for (int x = 0; x < chblDispositivos.Items.Count; x++)
                {
                    if (chblDispositivos.GetItemChecked(x))
                    {
                        tutor.dispositivos = tutor.dispositivos + 1 * (int)Math.Pow(10, x);
                    }
                    else
                    {
                        tutor.dispositivos = tutor.dispositivos + 2 * (int)Math.Pow(10, x);
                    }
                }
            }
            else
            {
                tutor.dispositivos = 2222;  // Ninguno escogido
            }

            try
            {
                // Se modifica el Tutor
                daoTutor.modificarTutor(tutor);
                // Mensaje
                MessageBox.Show("Se ha modificado con exito", "Mensaje de Confirmacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                // Siguiente ventana
                formPlantilla.abrirFormulario(formAnterior.formOperacionPersona);
            }
            catch (Exception ex)
            {
                var mensaje = "Error message: " + ex.Message;
                MessageBox.Show("No se pudo modificar el Tutor", "Mensaje de Confirmacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
    }
}
