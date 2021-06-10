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

namespace InterfazDATMA.Administrador
{
    public partial class frmInsertarTutor : Form
    {
        private frmPlantillaGestion formPlantilla;
        public frmOperacionesPersona formOperacionPersona;

        public frmInsertarTutor(frmOperacionesPersona formOperacionPersona, frmPlantillaGestion formPlantilla)
        {
            InitializeComponent();
            this.formPlantilla = formPlantilla;
            this.formOperacionPersona = formOperacionPersona;

            inicializarComponentes();
        }

        private void inicializarComponentes()
        {
            //Inicializar el combo box para distrito
            DistritoWS.DistritoWSClient daoDistrito = new DistritoWS.DistritoWSClient();
            BindingList<DistritoWS.distrito> distritos = new BindingList<DistritoWS.distrito>(daoDistrito.lisrarTodosDistritos().ToList());
            cboDistrito.DataSource = distritos;
            cboDistrito.DisplayMember = "nombre";

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
            DistritoWS.distrito distritoSelected = cboDistrito.SelectedItem as DistritoWS.distrito;
            tutor.distrito = new TutorWS.distrito();
            tutor.distrito.idDistrito = distritoSelected.idDistrito;

            if (rbtnHombre.Checked == true)
            {
                tutor.genero = 'M';
            }
            else
            {
                tutor.genero = 'F';
            }

            // Se inserta también el tutor para la siguiente pantalla
            formPlantilla.abrirFormulario(new frmInsertarPreferencias(this, formPlantilla, tutor));
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            formPlantilla.abrirFormulario(formOperacionPersona);
        }

        private void btnNuevoDistrito_Click(object sender, EventArgs e)
        {
            frmInsertarDistrito frmDistrito = new frmInsertarDistrito();
            if (frmDistrito.ShowDialog() == DialogResult.OK)
            {
                
            }
        }

        private void lblGenero_Click(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void cboDistrito_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void dtpFechaNacimiento_ValueChanged(object sender, EventArgs e)
        {

        }

        private void rbtnHombre_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rbtnMujer_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblApMat_Click(object sender, EventArgs e)
        {

        }

        private void lblCorreo_Click(object sender, EventArgs e)
        {

        }

        private void lblDni_Click(object sender, EventArgs e)
        {

        }

        private void lblDistrito_Click(object sender, EventArgs e)
        {

        }

        private void lblCelular_Click(object sender, EventArgs e)
        {

        }

        private void lblApPat_Click(object sender, EventArgs e)
        {

        }

        private void lblFechaNacimiento_Click(object sender, EventArgs e)
        {

        }

        private void lblTelefono_Click(object sender, EventArgs e)
        {

        }

        private void lblTutores_Click(object sender, EventArgs e)
        {

        }

        private void nuevoDistrito_Click(object sender, EventArgs e)
        {
            frmInsertarDistrito frmDistrito = new frmInsertarDistrito();
            if (frmDistrito.ShowDialog() == DialogResult.OK)
            {
                DistritoWS.DistritoWSClient daoDistrito = new DistritoWS.DistritoWSClient();
                BindingList<DistritoWS.distrito> distritos = new BindingList<DistritoWS.distrito>(daoDistrito.lisrarTodosDistritos().ToList());
                cboDistrito.DataSource = distritos;
                cboDistrito.DisplayMember = "nombre";
            }
        }
    }
}
