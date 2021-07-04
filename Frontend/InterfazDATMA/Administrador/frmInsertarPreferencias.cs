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

namespace InterfazDATMA.Administrador
{
    public partial class frmInsertarPreferencias : MaterialSkin.Controls.MaterialForm
    {
        private frmPlantillaGestion formPlantilla;
        private frmInsertarTutor formAnterior;
        private TutorWS.tutor tutorAux;

        public MaterialSkinManager ThemeManager = MaterialSkinManager.Instance;
        private TutorWS.TutorWSClient daoTutor;
        public frmInsertarPreferencias(frmInsertarTutor formAnterior, frmPlantillaGestion formPlantilla, TutorWS.tutor tutor)
        {
            this.DoubleBuffered = true;
            InitializeComponent();

            Design.Ini(this);
            if (Design.tema == 'd') ThemeManager.Theme = MaterialSkinManager.Themes.DARK;
            else ThemeManager.Theme = MaterialSkinManager.Themes.LIGHT;
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

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            formPlantilla.abrirFormulario(formAnterior);

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            // Insertar Dispositivos Electronicos
            if (chblDispositivos.CheckedItems.Count != 0)       // Si fue seleccionado al menos 1 dispositivo
            {
                string disp = "";
                for (int x = 0; x < chblDispositivos.Items.Count; x++)
                {
                    if (chblDispositivos.GetItemChecked(x))
                    {
                        disp += "2";
                        //tutorAux.dispositivos = tutorAux.dispositivos + (int)Math.Pow(10, x);
                    }
                    else disp += "1";
                }
                tutorAux.dispositivos = Int32.Parse(disp);
            }
            else
            {
                tutorAux.dispositivos = Int32.Parse(new String('1', chblDispositivos.Items.Count));
            }

            // Insertar Tipos de Internet
            if (chblInternet.CheckedItems.Count != 0)       // Si fue seleccionado al menos 1 tipo internet
            {
                string internet = "";
                for (int x = 0; x < chblDispositivos.Items.Count; x++)
                {
                    if (chblInternet.GetItemChecked(x))
                    {
                        internet += "2";
                    }
                    else internet += "1";
                }
                tutorAux.dispositivos = Int32.Parse(internet);
            }
            else
            {
                tutorAux.tiposConexion = Int32.Parse(new String('1', chblInternet.Items.Count));
            }

            // Insertar Turno
            if (chblTurno.CheckedItems.Count != 0)       // Si fue seleccionado al menos 1 turno
            {
                string turno = "";
                for (int x = 0; x < chblTurno.Items.Count; x++)
                {
                    if (chblTurno.GetItemChecked(x))
                    {
                        turno += "2";
                    }
                    else turno += "1";
                }
                tutorAux.turno = Int32.Parse(turno);
            }
            else
            {
                tutorAux.turno = Int32.Parse(new String('1', chblTurno.Items.Count));
            }

            // Insertar Dias Preferidos
            if (chblDias.CheckedItems.Count != 0)       // Si fue seleccionado al menos 1 dia
            {
                string dias = "";
                for (int x = 0; x < chblDias.Items.Count; x++)
                {
                    if (chblDias.GetItemChecked(x))
                    {
                        dias += "2";
                    }
                    else dias += "1";
                }
                tutorAux.dia = Int32.Parse(dias);
            }
            else
            {
                tutorAux.dia = Int32.Parse(new String('1', chblDias.Items.Count));
            }

            // Insertar Redes Sociales
            if (chblRedes.CheckedItems.Count != 0)       // Si fue seleccionado al menos 1 red social
            {
                string red = "";
                for (int x = 0; x < chblRedes.Items.Count; x++)
                {
                    if (chblRedes.GetItemChecked(x))
                    {
                        red += "2";
                    }
                    else red += "1";
                }
                tutorAux.redesSociales = Int32.Parse(red);
            }
            else
            {
                tutorAux.redesSociales = Int32.Parse(new String('1', chblRedes.Items.Count));
            }

            if (chbGestante.Checked) tutorAux.gestante = 1;
            else tutorAux.gestante = 0;
            if (chbRecursos.Checked) tutorAux.bajoRecursos = 1;
            else tutorAux.bajoRecursos = 0;

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
                    tutorAux.user = "0";
                    tutorAux.password = "admin";
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
