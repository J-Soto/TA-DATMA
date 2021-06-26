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

namespace InterfazDATMA.Administrador
{
    public partial class frmModificarPsicologo : MaterialSkin.Controls.MaterialForm 
    {
        private frmPlantillaGestion formPlantilla;
        public frmOperacionesPersona formOperacionPersona;
        private PsicologoWS.PsicologoWSClient daoPsicologo;

        private PsicologoWS.distrito distrito;
        private PsicologoWS.psicologo psicologo;
        private string rutaFoto = "";

        public PsicologoWS.psicologo Psicologo { get => psicologo; set => psicologo = value; }

        public frmModificarPsicologo(frmOperacionesPersona formOperacionPersona, frmPlantillaGestion formPlantilla, PsicologoWS.psicologo psicologo)
        {
            this.DoubleBuffered = true;
            InitializeComponent();
            this.psicologo = psicologo;
            this.formPlantilla = formPlantilla;
            this.formOperacionPersona = formOperacionPersona;

            daoPsicologo = new PsicologoWS.PsicologoWSClient();
            txtDistrito.ReadOnly = true;
            inicializarComponentes();
            completarDatosPsicologos();

            //txtUser.Enabled = false;
            //txtPass.Enabled = false;
            //txtConfirmarPass.Text = "";
            //txtConfirmarPass.Enabled = false;
        }

        private void inicializarComponentes()
        {
            txtNombre.Text = "";
            txtApellidoPat.Text = "";
            txtApellidoMat.Text = "";
            txtCorreo.Text = "";
            //txtUser.Text = "";
            //txtPass.Text = "";
            //txtConfirmarPass.Text = "";
            txtDni.Text = "";
            txtTelf.Text = "";
            txtCelular.Text = "";
            rbtnHombre.Checked = false;
            rbtnMujer.Checked = false;
            pbFoto.Image = null;
        }

        private void completarDatosPsicologos()
        {
            txtNombre.Text = psicologo.nombre;
            txtApellidoPat.Text = psicologo.apellidoPaterno;
            txtApellidoMat.Text = psicologo.apellidoMaterno;
            txtCorreo.Text = psicologo.correo;
            //txtUser.Text = psicologo.user;
            /* La contraseña no se muestra*/
            //txtPass.Text = psicologo.password;
            //txtConfirmarPass.Text = psicologo.password;
            /*----------------------------*/
            txtDni.Text = psicologo.DNI;
            txtTelf.Text = psicologo.telefono;
            txtCelular.Text = psicologo.celular;
            if (psicologo.genero == 'M')
            {
                rbtnHombre.Checked = true;
            }
            else
            {
                rbtnMujer.Checked = true;
            }
            // Si se tiene la foto de perfil guardada en BD, esta se carga en PictureBox
            if (psicologo.fotoPerfil != null)
            {
                MemoryStream ms = new MemoryStream(psicologo.fotoPerfil);
                pbFoto.Image = new Bitmap(ms);
            }
            // Distrito
            if (psicologo.distrito != null)
                txtDistrito.Text = psicologo.distrito.nombre;
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

        private void txtTelf_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            Validar.SoloNumeros(e);
        }

        private void txtCelular_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.SoloNumeros(e);
        }

        private void txtDni_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.SoloNumeros(e);
        }

        private void btnSubirFoto_Click(object sender, EventArgs e)
        {
            try
            {
                if (ofdSubirFoto.ShowDialog() == DialogResult.OK)
                {
                    rutaFoto = ofdSubirFoto.FileName;
                    //MessageBox.Show(rutaFoto);
                    pbFoto.Image = Image.FromFile(rutaFoto);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Seleccionar una imagen valida", "Mensaje de Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }


        private void frmModificarPsicologo_Load(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click_1(object sender, EventArgs e)
        {
            inicializarComponentes();
            formPlantilla.abrirFormulario(formOperacionPersona);

        }

        private void nuevoDistrito_Click_1(object sender, EventArgs e)
        {
            frmInsertarDistrito formDistrito = new frmInsertarDistrito();
            if (formDistrito.ShowDialog() == DialogResult.OK)
            {
                if (formDistrito.distrito != null)
                {
                    distrito = new PsicologoWS.distrito();
                    distrito.idDistrito = formDistrito.distrito.idDistrito;
                    distrito.nombre = formDistrito.distrito.nombre;
                    txtDistrito.Text = distrito.nombre;
                    psicologo.distrito = distrito;
                }
            }

        }

        private void btnGuardar_Click_1(object sender, EventArgs e)
        {
            psicologo.nombre = txtNombre.Text;
            psicologo.apellidoPaterno = txtApellidoPat.Text;
            psicologo.apellidoMaterno = txtApellidoMat.Text;
            psicologo.fechaNacimiento = dtpFechaNacimiento.Value;
            psicologo.fechaNacimientoSpecified = true;
            //psicologo.distrito = new PsicologoWS.distrito();
            //psicologo.distrito = distrito;
            psicologo.correo = txtCorreo.Text;

            psicologo.DNI = txtDni.Text;
            //MessageBox.Show(psicologo.distrito.idDistrito.ToString());


            psicologo.telefono = txtTelf.Text;
            psicologo.celular = txtCelular.Text;
            if (rbtnHombre.Checked == true)
            {
                psicologo.genero = 'M';
            }
            else
            {
                psicologo.genero = 'F';
            }


            //Foto es opcional:
            if (rutaFoto.Equals("") != true)
            {
                FileStream fs = new FileStream(rutaFoto, FileMode.Open, FileAccess.Read);
                BinaryReader br = new BinaryReader(fs);
                psicologo.fotoPerfil = br.ReadBytes((int)fs.Length);
            }



            //Validaciones:
            if (psicologo.DNI.Length != 8)
            {
                MessageBox.Show("El DNI debe tener 8 digitos", "Mensaje de Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (psicologo.correo.Contains("@") != true)
            {
                MessageBox.Show("Correo invalido", "Mensaje de Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                int verificado = daoPsicologo.verificarDNI(psicologo.DNI, psicologo.nombre, psicologo.apellidoPaterno, psicologo.apellidoMaterno);
                if (verificado == -1)
                {
                    var resultado = MessageBox.Show("No se ha podido verificar el DNI. Quiere continuar?", "Mensaje de Confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (resultado == DialogResult.Yes)
                    {
                        try
                        {
                            int idPsicologo = daoPsicologo.modificarPsicologo(psicologo);
                            MessageBox.Show("Se ha guardado con exito", "Mensaje de Confirmacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            formPlantilla.abrirFormulario(formOperacionPersona);
                        }
                        catch (Exception ex)
                        {
                            throw new Exception();
                        }
                    }
                }
                else if (verificado == 0)
                    MessageBox.Show("El DNI no concuerda con los nombres", "Mensaje de Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    try
                    {
                        int idPsicologo = daoPsicologo.modificarPsicologo(psicologo);
                        MessageBox.Show("Se ha guardado con exito", "Mensaje de Confirmacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        formPlantilla.abrirFormulario(formOperacionPersona);
                    }
                    catch (Exception ex)
                    {
                        throw new Exception();
                    }
                }

            }

        }
    }
}
