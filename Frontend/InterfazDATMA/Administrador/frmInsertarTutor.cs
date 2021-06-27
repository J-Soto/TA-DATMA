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

            // Se inserta también el tutor para la siguiente pantalla
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

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            formPlantilla.abrirFormulario(formOperacionPersona);

        }
    }
}
