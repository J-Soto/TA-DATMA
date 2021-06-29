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

namespace InterfazDATMA.Administrador
{
    public partial class frmInsertarPreferencias : MaterialSkin.Controls.MaterialForm 
    {
        private frmPlantillaGestion formPlantilla;
        private frmInsertarTutor formAnterior;
        private TutorWS.tutor tutorAux;
        private TutorWS.TutorWSClient daoTutor;
        public frmInsertarPreferencias(frmInsertarTutor formAnterior, frmPlantillaGestion formPlantilla, TutorWS.tutor tutor)
        {
            this.DoubleBuffered = true;
            InitializeComponent();

            Design.Ini(this);
            this.formPlantilla = formPlantilla;
            this.formAnterior = formAnterior;
            daoTutor = new TutorWS.TutorWSClient();

            chblDias.CheckOnClick = true;
            chblDispositivos.CheckOnClick = true;
            chblInternet.CheckOnClick = true;
            chblTurno.CheckOnClick = true;
            chblRedes.CheckOnClick = true;
            if (tutor.genero == 'M') chbGestante.Enabled = false;
            tutorAux = tutor;
        }

        private void frmInsertarPreferencias_Load(object sender, EventArgs e)
        {

        }

        private void chblDispositivos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            formPlantilla.abrirFormulario(formAnterior);

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            // Insertar Dispositivos Electronicos
            tutorAux.dispositivos = 0;
            if (chblDispositivos.CheckedItems.Count != 0)       // Si fue seleccionado al menos 1 dispositivo
            {
                for (int x = 0; x < chblDispositivos.CheckedItems.Count; x++)
                {
                    if (chblDispositivos.GetItemChecked(x))
                    {
                        tutorAux.dispositivos = tutorAux.dispositivos + (int)Math.Pow(10, x);
                    }
                }
            }
            else
            {
                tutorAux.dispositivos = 0;
            }

            tutorAux.tiposConexion = 1;
            tutorAux.gestante = 1;
            tutorAux.turno = 1;
            tutorAux.dia = 1;
            tutorAux.bajoRecursos = 1;
            tutorAux.redesSociales = 1;

            //Validaciones:
            if (tutorAux.DNI.Length != 8)
            {
                MessageBox.Show("El DNI debe tener 8 digitos", "Mensaje de Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (tutorAux.correo.Contains("@") != true)
            {
                MessageBox.Show("Correo invalido", "Mensaje de Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                try
                {
                    int idTutor = daoTutor.insertarTutor(tutorAux);
                    if (idTutor != 0)
                    {
                        MessageBox.Show("Se ha registrado con exito", "Mensaje de Confirmacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        tutorAux.idPersona = idTutor;
                        formPlantilla.abrirFormulario(formAnterior.formOperacionPersona);
                    }


                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                }
            }

        }
    }
}
