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
using MaterialSkin;

namespace InterfazDATMA.Administrador
{
    public partial class frmInsertarPsicologo : MaterialSkin.Controls.MaterialForm 
    {
        private frmPlantillaGestion formPlantilla;
        

        public MaterialSkinManager ThemeManager = MaterialSkinManager.Instance;
        public frmOperacionesPersona formOperacionPersona;

        private PsicologoWS.PsicologoWSClient daoPsicologo;
        private PsicologoWS.distrito distrito;
        private UsuarioWS.UsuarioWSClient daoUsuario;
        private string rutaFoto = "";

        public frmInsertarPsicologo(frmOperacionesPersona formOperacionPersona, frmPlantillaGestion formPlantilla)
        {
            this.DoubleBuffered = true;
            InitializeComponent();

            Design.Ini(this);
            if (Design.tema == 'd') ThemeManager.Theme = MaterialSkinManager.Themes.DARK;
            else ThemeManager.Theme = MaterialSkinManager.Themes.LIGHT;
            this.formPlantilla = formPlantilla;
            this.formOperacionPersona = formOperacionPersona;
            daoPsicologo = new PsicologoWS.PsicologoWSClient();
            daoUsuario = new UsuarioWS.UsuarioWSClient();

            txtDistrito.ReadOnly = true;
            inicializarComponentes();
        }

        private void inicializarComponentes()
        {
            txtNombre.Text = "";
            txtApellidoPat.Text = "";
            txtApellidoMat.Text = "";
            txtCorreo.Text = "";
            txtDni.Text = "";
            txtTelf.Text = "";
            txtCelular.Text = "";
            rbtnHombre.Checked = false;
            rbtnMujer.Checked = false;
            pbFoto.Image = null;
        }

        private void rbtnHombre_Click(object sender, EventArgs e)
        {
            rbtnMujer.Checked = false;
            rbtnHombre.Checked = true;
        }

        private void rbtnMujer_Click(object sender, EventArgs e)
        {
            rbtnHombre.Checked = false;
            rbtnMujer.Checked = true;
        }

        private void btnSubirFoto_Click(object sender, EventArgs e)
        {
            try
            {
                if (ofdSubirFoto.ShowDialog() == DialogResult.OK)
                {
                    rutaFoto = ofdSubirFoto.FileName;
                    pbFoto.Image = Image.FromFile(rutaFoto);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Seleccionar una imagen valida", "Mensaje de Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void txtDni_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.SoloNumeros(e);
        }

        private void txtTelf_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.SoloNumeros(e);
        }

        private void txtCelular_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.SoloNumeros(e);
        }

        private void dtpFechaNacimiento_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmInsertarDistrito frmDistrito = new frmInsertarDistrito();
            if (frmDistrito.ShowDialog() == DialogResult.OK)
            {
                if (frmDistrito.distrito != null)
                {
                    distrito = new PsicologoWS.distrito();
                    distrito.idDistrito = frmDistrito.distrito.idDistrito;
                    distrito.nombre = frmDistrito.distrito.nombre;
                    txtDistrito.Text = distrito.nombre;
                }
            }
        }

        private void nuevoDistrito_Click(object sender, EventArgs e)
        {
            frmInsertarDistrito frmDistrito = new frmInsertarDistrito();
            if (frmDistrito.ShowDialog() == DialogResult.OK)
            {
                if (frmDistrito.distrito != null)
                {
                    distrito = new PsicologoWS.distrito();
                    distrito.idDistrito = frmDistrito.distrito.idDistrito;
                    distrito.nombre = frmDistrito.distrito.nombre;
                    txtDistrito.Text = distrito.nombre;
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            inicializarComponentes();
            formPlantilla.abrirFormulario(formOperacionPersona);
        }


        private (string,string) generarUsuario()
        {
            string user = Guid.NewGuid().ToString("N");
            if (user.Length > 75)
                user = user.Substring(0, 75);
            string password = Guid.NewGuid().ToString("N");
            if (password.Length > 15)
                password = password.Substring(0, 15);
            return (user, password);
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            PsicologoWS.psicologo psicologo = new PsicologoWS.psicologo();

            psicologo.nombre = txtNombre.Text;
            psicologo.apellidoPaterno = txtApellidoPat.Text;
            psicologo.apellidoMaterno = txtApellidoMat.Text;
            psicologo.fechaNacimiento = dtpFechaNacimiento.Value;
            psicologo.fechaNacimientoSpecified = true;
            psicologo.distrito = new PsicologoWS.distrito();
            psicologo.distrito = distrito;
            psicologo.correo = txtCorreo.Text;

            psicologo.DNI = txtDni.Text;

            //Por defecto
            psicologo.tipo = 0;


            psicologo.telefono = txtTelf.Text;
            psicologo.celular = txtCelular.Text;
            if (rbtnHombre.Checked == true)
            {
                psicologo.genero = 'M';
            }
            else if (rbtnMujer.Checked == true)
            {
                psicologo.genero = 'F';
            }
            else
            {
                psicologo.genero = 2;
            }


            //Foto es opcional:
            if (rutaFoto.Equals("") != true)
            {
                FileStream fs = new FileStream(rutaFoto, FileMode.Open, FileAccess.Read);
                BinaryReader br = new BinaryReader(fs);
                psicologo.fotoPerfil = br.ReadBytes((int)fs.Length);
            }
            else
            {
                psicologo.fotoPerfil = null;
            }


            //Validaciones:
            bool validacionCorrecta = true;

            // txtDni
            if (psicologo.DNI.Length != 8 || psicologo.DNI[0] == '0')  // El DNI debe tener 8 dígitos
            {
                this.errorProvider.SetError(txtDni, "El DNI debe tener 8 dígitos.");
                validacionCorrecta = false;
            }
            else
            {
                this.errorProvider.SetError(txtDni, "");
            }

            // txtTelf
            if (psicologo.telefono.Length != 7 || psicologo.telefono[0] == '0')  // El telefono debe tener 7 dígitos
            {
                this.errorProvider.SetError(txtTelf, "El telefono debe tener 7 dígitos.");
                validacionCorrecta = false;
            }
            else
            {
                this.errorProvider.SetError(txtTelf, "");
            }

            if (psicologo.celular.Length != 9 || psicologo.celular[0] != '9')  // El telefono debe tener 7 dígitos
            {
                this.errorProvider.SetError(txtCelular, "El número de celular debe tener 9 dígitos y empezar con 9.");
                validacionCorrecta = false;
            }
            else
            {
                this.errorProvider.SetError(txtCelular, "");
            }

            if (psicologo.nombre == "")
            {
                this.errorProvider.SetError(txtNombre, "Es requerido ingresar el nombre.");
                validacionCorrecta = false;
            }
            else
            {
                this.errorProvider.SetError(txtNombre, "");
            }

            if (psicologo.apellidoPaterno == "")
            {
                this.errorProvider.SetError(txtApellidoPat, "Es requerido ingresar el apellido paterno.");
                validacionCorrecta = false;
            }
            else
            {
                this.errorProvider.SetError(txtApellidoPat, "");
            }

            if (psicologo.apellidoMaterno == "")
            {
                this.errorProvider.SetError(txtApellidoMat, "Es requerido ingresar el apellido materno.");
                validacionCorrecta = false;
            }
            else
            {
                this.errorProvider.SetError(txtApellidoMat, "");
            }

            if (psicologo.fechaNacimiento.Year > 2003)
            {
                this.errorProvider.SetError(dtpFechaNacimiento, "Es requerido ingresar una fecha de nacimiento válida.");
                validacionCorrecta = false;
            }
            else
            {
                this.errorProvider.SetError(dtpFechaNacimiento, "");
            }

            if (psicologo.distrito == null)
            {
                this.errorProvider.SetError(txtDistrito, "Es requerido ingresar un distrito.");
                validacionCorrecta = false;
            }
            else
            {
                this.errorProvider.SetError(txtDistrito, "");
            }

            if (psicologo.genero == 2)
            {
                this.errorProvider.SetError(rbtnMujer, "Es requerido ingresar un genéro.");
                validacionCorrecta = false;
            }
            else
            {
                this.errorProvider.SetError(rbtnMujer, "");
            }

            if (psicologo.fotoPerfil == null)
            {
                this.errorProvider.SetError(btnSubirFoto, "Debe ingresar una foto para el perfil del psicólogo.");
                validacionCorrecta = false;
            }
            else
            {
                this.errorProvider.SetError(btnSubirFoto, "");
            }

            if (psicologo.correo != "") 
            {
                if (!Char.IsLetter(psicologo.correo[0]) || psicologo.correo.Contains("@") != true || !(psicologo.correo.IndexOf(".", psicologo.correo.IndexOf("@")) > psicologo.correo.IndexOf("@")))
                {
                    this.errorProvider.SetError(txtCorreo, "Ingrese un correo válido.");
                    validacionCorrecta = false;
                }
                else
                {
                    this.errorProvider.SetError(txtCorreo, "");
                }
            }
            else
            {
                this.errorProvider.SetError(txtCorreo, "Es requerido ingresar un correo.");
                validacionCorrecta = false;
            }


            if(validacionCorrecta)
            {
                int verificado = daoPsicologo.verificarDNI(psicologo.DNI, psicologo.nombre, psicologo.apellidoPaterno, psicologo.apellidoMaterno);
                if (verificado == -1)
                {
                    var resultado = MessageBox.Show("No se ha podido verificar el DNI. Quiere continuar?", "Mensaje de Confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (resultado == DialogResult.Yes)
                    {
                        try
                        {
                            var credenciales = generarUsuario();
                            psicologo.user = credenciales.Item1;
                            psicologo.password = credenciales.Item2;
                            int idPsicologo = daoPsicologo.insertarPsicologo(psicologo);
                            if (idPsicologo > 0)
                            {
                                //var credenciales = generarUsuario();
                                string msgEnvioDatos = "";
                                if (this.daoUsuario.enviarDatosUsuario(psicologo.correo, psicologo.user, psicologo.password) == 1)
                                    msgEnvioDatos = ". Credenciales enviadas con exito.";
                                MessageBox.Show("Se ha registrado con exito"+ msgEnvioDatos, "Mensaje de Confirmacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                psicologo.idPersona = idPsicologo;
                                formPlantilla.abrirFormulario(formOperacionPersona);
                            }
                            else
                                MessageBox.Show("Registro fallido", "Mensaje de Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        }
                        catch (Exception ex)
                        {
                            throw new Exception(ex.Message);
                        }
                    }
                }
                else if (verificado == 0)
                    MessageBox.Show("El DNI no concuerda con los nombres", "Mensaje de Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    try
                    {
                        int idPsicologo = daoPsicologo.insertarPsicologo(psicologo);
                        if (idPsicologo != 0)
                        {
                            MessageBox.Show("Se ha registrado con exito", "Mensaje de Confirmacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            psicologo.idPersona = idPsicologo;
                            formOperacionPersona.inicializarTablas();
                            formPlantilla.abrirFormulario(formOperacionPersona);
                        }

                    }
                    catch (Exception ex)
                    {
                        throw new Exception();
                    }
                }

            }
            else
            {
                MessageBox.Show("Datos incorrectos. Revisar nuevamente.", "Mensaje de Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtDni_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (txtDni.Text.Length != 8 || txtDni.Text[0] == '0')  // El DNI debe tener 8 dígitos
            {
                this.errorProvider.SetError(txtDni, "El DNI debe tener 8 dígitos.");
            }
            else
            {
                this.errorProvider.SetError(txtDni, "");
            }
        }

        private void txtTelf_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (txtTelf.Text.Length != 7 || txtTelf.Text[0] == '0')  // El telefono debe tener 7 dígitos
            {
                this.errorProvider.SetError(txtTelf, "El telefono debe tener 7 dígitos.");
            }
            else
            {
                this.errorProvider.SetError(txtTelf, "");
            }
        }

    }
}
