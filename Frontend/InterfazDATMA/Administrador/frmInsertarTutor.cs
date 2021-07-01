using MaterialSkin.Controls;
using InterfazDATMA.plantilla;
using InterfazDATMA.validacion;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using InterfazDATMA.util;

namespace InterfazDATMA.Administrador
{
    public partial class frmInsertarTutor : MaterialSkin.Controls.MaterialForm 
    {
        private frmPlantillaGestion formPlantilla;
        public frmOperacionesPersona formOperacionPersona;

        private TutorWS.distrito distrito;
        private TutorWS.TutorWSClient daoTutor;

        public frmInsertarTutor(frmOperacionesPersona formOperacionPersona, frmPlantillaGestion formPlantilla)
        {
            this.DoubleBuffered = true;
            InitializeComponent();

            Design.Ini(this);
            this.formPlantilla = formPlantilla;
            this.formOperacionPersona = formOperacionPersona;

            txtDistrito.ReadOnly = true;
            daoTutor = new TutorWS.TutorWSClient();
            inicializarComponentes();
        }

        private void inicializarComponentes()
        {
            txtNombre.Text = "";
            txtApPat.Text = "";
            txtApMat.Text = "";
            txtCorreo.Text = "";
            txtDni.Text = "";
            txtTelf.Text = "";
            txtCel.Text = "";
            rbtnHombre.Checked = false;
            rbtnMujer.Checked = false;
        }

        private void rbtnMujer_Click(object sender, EventArgs e)
        {
            rbtnHombre.Checked = false;
            rbtnMujer.Checked = true;
        }

        private void rbtnHombre_Click(object sender, EventArgs e)
        {
            rbtnMujer.Checked = false;
            rbtnHombre.Checked = true;
        }

        private void nuevoDistrito_Click(object sender, EventArgs e)
        {
            frmInsertarDistrito frmDistrito = new frmInsertarDistrito();
            if (frmDistrito.ShowDialog() == DialogResult.OK)
            {
                if (frmDistrito.distrito != null)
                {
                    distrito = new TutorWS.distrito();
                    distrito.idDistrito = frmDistrito.distrito.idDistrito;
                    distrito.nombre = frmDistrito.distrito.nombre;
                    txtDistrito.Text = distrito.nombre;
                }
            }

        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            TutorWS.tutor tutor = new TutorWS.tutor();

            tutor.nombre = txtNombre.Text;
            tutor.apellidoPaterno = txtApPat.Text;
            tutor.apellidoMaterno = txtApMat.Text;
            tutor.correo = txtCorreo.Text;
            tutor.DNI = txtDni.Text;
            tutor.telefono = txtTelf.Text;
            tutor.celular = txtCel.Text;
            tutor.fechaNacimiento = dtpFechaNacimiento.Value;
            tutor.fechaNacimientoSpecified = true;
            tutor.distrito = new TutorWS.distrito();
            tutor.distrito = distrito;

            if (rbtnHombre.Checked == true)
            {
                tutor.genero = 'M';
            }
            else
            {
                tutor.genero = 'F';
            }


            //Validaciones:
            if (tutor.DNI.Length != 8)  // Si el DNI es una cadena diferente de longitud 8
            {
                MessageBox.Show("El DNI debe tener 8 digitos.", "Mensaje de Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (tutor.DNI[0] == '0')    // Si el DNI inicia con cero 
            {
                MessageBox.Show("El DNI no puede empezar con cero.", "Mensaje de Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (tutor.celular.Length != 9) // Si el celular es una cadena diferente de longitud 9
            {
                MessageBox.Show("El número de celular debe tener 9 digitos.", "Mensaje de Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (tutor.celular[0] != '9')   // Si el numero de celular no empieza con 9
            {
                MessageBox.Show("El número de celular debe empezar con nueve.", "Mensaje de Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (tutor.telefono.Length != 7)    // Si el número de telefono inicia con 7
            {
                MessageBox.Show("El telefono debe tener 7 digitos", "Mensaje de Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (tutor.telefono[0] == '0')       // Si el numero de telefono inicia con cero
            {
                MessageBox.Show("El número de teléfono no puede empezar con cero", "Mensaje de Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (!Char.IsLetter(tutor.correo[0]) || tutor.correo.Contains("@") != true || (tutor.correo.Contains(".com") || tutor.correo.Contains(".pe")) != true)       // El correo debe tener el @, iniciar con .com o .pe y además debe comenzar con una letra
            {
                MessageBox.Show("Correo invalido", "Mensaje de Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                int verificado = daoTutor.verificarDNI(tutor.DNI, tutor.nombre, tutor.apellidoPaterno, tutor.apellidoMaterno);
                if (verificado == -1)
                {
                    var resultado = MessageBox.Show("No se ha podido verificar el DNI. Quiere continuar?", "Mensaje de Confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (resultado == DialogResult.Yes)
                    {
                        formPlantilla.abrirFormulario(new frmInsertarPreferencias(this, formPlantilla, tutor));
                    }
                }
                else if (verificado == 0)
                    MessageBox.Show("El DNI no concuerda con los nombres", "Mensaje de Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                    formPlantilla.abrirFormulario(new frmInsertarPreferencias(this, formPlantilla, tutor));
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            formPlantilla.abrirFormulario(formOperacionPersona);

        }
    }
}
