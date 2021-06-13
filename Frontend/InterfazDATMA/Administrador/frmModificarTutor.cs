using InterfazDATMA.plantilla;
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
    public partial class frmModificarTutor : Form
    {
        private frmPlantillaGestion formPlantilla;
        public frmOperacionesPersona formOperacionPersona;

        private TutorWS.TutorWSClient daoTutor;

        private TutorWS.tutor tutor;
        public frmModificarTutor(frmOperacionesPersona formOperacionPersona, frmPlantillaGestion formPlantilla, TutorWS.tutor tutor)
        {
            InitializeComponent();
            this.tutor = tutor;
            this.formPlantilla = formPlantilla;
            this.formOperacionPersona = formOperacionPersona;

            daoTutor = new TutorWS.TutorWSClient();
            inicializarComponentes();
            completarDatosTutores();
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
            txtUser.Text = "";
            txtPass.Text = "";
            rbtnHombre.Checked = false;
            rbtnMujer.Checked = false;
        }

        private void completarDatosTutores()
        {
            txtNombre.Text = tutor.nombre;
            txtApPat.Text = tutor.apellidoPaterno;
            txtApMat.Text = tutor.apellidoMaterno;
            txtCorreo.Text = tutor.correo;
            txtUser.Text = tutor.user;
            txtPass.Text = tutor.password;
            txtConfirmarPass.Text = tutor.password;
            txtDni.Text = tutor.DNI;
            txtTelf.Text = tutor.telefono;
            txtCel.Text = tutor.celular;
            if (tutor.genero == 'M')
            {
                rbtnHombre.Checked = true;
            }
            else
            {
                rbtnMujer.Checked = true;
            }

            if (tutor.fotoPerfil != null)
            {
                MemoryStream ms = new MemoryStream(tutor.fotoPerfil);
                pbFoto.Image = new Bitmap(ms);
            }

            DistritoWS.distrito distrito = new DistritoWS.distrito();

            distrito.nombre = tutor.distrito.nombre;
            cboDistrito.SelectedItem = distrito;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            formPlantilla.abrirFormulario(formOperacionPersona);
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
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
            formPlantilla.abrirFormulario(new frmModificarPreferencias(this,formPlantilla, tutor));
        }

        private void btnNuevoDistrito_Click(object sender, EventArgs e)
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
