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
    public partial class frmModificarPsicologo : MaterialSkin.Controls.MaterialForm 
    {
        private frmPlantillaGestion formPlantilla;
        public frmOperacionesPersona formOperacionPersona;
        private PsicologoWS.PsicologoWSClient daoPsicologo;

        public MaterialSkinManager ThemeManager = MaterialSkinManager.Instance;

        private PsicologoWS.distrito distrito;
        private PsicologoWS.psicologo psicologo;
        private string rutaFoto = "";

        public PsicologoWS.psicologo Psicologo { get => psicologo; set => psicologo = value; }

        public frmModificarPsicologo(frmOperacionesPersona formOperacionPersona, frmPlantillaGestion formPlantilla, PsicologoWS.psicologo psicologo)
        {
            this.DoubleBuffered = true;
            InitializeComponent();

            Design.Ini(this);
            if (Design.tema == 'd') ThemeManager.Theme = MaterialSkinManager.Themes.DARK;
            else ThemeManager.Theme = MaterialSkinManager.Themes.LIGHT;
            this.psicologo = psicologo;
            this.formPlantilla = formPlantilla;
            this.formOperacionPersona = formOperacionPersona;

            daoPsicologo = new PsicologoWS.PsicologoWSClient();
            txtDistrito.ReadOnly = true;
            inicializarComponentes();
            completarDatosPsicologos();


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

        private void completarDatosPsicologos()
        {
            txtNombre.Text = psicologo.nombre;
            txtApellidoPat.Text = psicologo.apellidoPaterno;
            txtApellidoMat.Text = psicologo.apellidoMaterno;
            txtCorreo.Text = psicologo.correo;
            /* La contraseña no se muestra*/
            //txtPass.Text = psicologo.password;
            //txtConfirmarPass.Text = psicologo.password;
            /*----------------------------*/
            txtDni.Text = psicologo.DNI;
            txtTelf.Text = psicologo.telefono;
            txtCelular.Text = psicologo.celular;
            dtpFechaNacimiento.Value = psicologo.fechaNacimiento;
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

            // txtCelular
            if (psicologo.celular.Length != 9 || psicologo.celular[0] != '9')  // El telefono debe tener 7 dígitos
            {
                this.errorProvider.SetError(txtCelular, "El número de celular debe tener 9 dígitos y empezar con 9.");
                validacionCorrecta = false;
            }
            else
            {
                this.errorProvider.SetError(txtCelular, "");
            }

            // txtNombre
            if (psicologo.nombre == "")
            {
                this.errorProvider.SetError(txtNombre, "Es requerido ingresar el nombre.");
                validacionCorrecta = false;
            }
            else
            {
                this.errorProvider.SetError(txtNombre, "");
            }

            // txtApellidoPat
            if (psicologo.apellidoPaterno == "")
            {
                this.errorProvider.SetError(txtApellidoPat, "Es requerido ingresar el apellido paterno.");
                validacionCorrecta = false;
            }
            else
            {
                this.errorProvider.SetError(txtApellidoPat, "");
            }


            // dtpFechaNacimiento
            if (psicologo.fechaNacimiento.Year > 2003)
            {
                this.errorProvider.SetError(dtpFechaNacimiento, "Es requerido ingresar una fecha de nacimiento válida.");
                validacionCorrecta = false;
            }
            else
            {
                this.errorProvider.SetError(dtpFechaNacimiento, "");
            }

            // txtDistrito
            if (psicologo.distrito == null)
            {
                this.errorProvider.SetError(txtDistrito, "Es requerido ingresar un distrito.");
                validacionCorrecta = false;
            }
            else
            {
                this.errorProvider.SetError(txtDistrito, "");
            }

            // rbtnMujer
            if (psicologo.genero == 2)
            {
                this.errorProvider.SetError(rbtnMujer, "Es requerido seleccionar un género.");
                validacionCorrecta = false;
            }
            else
            {
                this.errorProvider.SetError(rbtnMujer, "");
            }

            // btnSubirFoto
            if (psicologo.fotoPerfil == null)
            {
                this.errorProvider.SetError(btnSubirFoto, "Debe ingresar una foto para el perfil del psicólogo.");
                validacionCorrecta = false;
            }
            else
            {
                this.errorProvider.SetError(btnSubirFoto, "");
            }

            // txtCorreo
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


            if (validacionCorrecta)
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
            else
            {
                MessageBox.Show("Faltan datos o están incorrectos. Revisar nuevamente.", "Mensaje de Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void txtCelular_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (txtCelular.Text.Length != 9 || txtCelular.Text[0] != '9')  // El telefono debe tener 7 dígitos
            {
                this.errorProvider.SetError(txtCelular, "El número de celular debe tener 9 dígitos y empezar con 9.");
            }
            else
            {
                this.errorProvider.SetError(txtCelular, "");
            }
        }

        private void txtNombre_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (txtNombre.Text == "")
            {
                this.errorProvider.SetError(txtNombre, "Es requerido ingresar el nombre.");
            }
            else
            {
                this.errorProvider.SetError(txtNombre, "");
            }
        }

        private void txtApellidoPat_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (txtApellidoPat.Text == "")
            {
                this.errorProvider.SetError(txtApellidoPat, "Es requerido ingresar el apellido paterno.");
            }
            else
            {
                this.errorProvider.SetError(txtApellidoPat, "");
            }
        }

        private void txtCorreo_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (txtCorreo.Text != "")
            {
                if (!Char.IsLetter(txtCorreo.Text[0]) || txtCorreo.Text.Contains("@") != true || !(txtCorreo.Text.IndexOf(".", txtCorreo.Text.IndexOf("@")) > txtCorreo.Text.IndexOf("@")))
                {
                    this.errorProvider.SetError(txtCorreo, "Ingrese un correo válido.");
                }
                else
                {
                    this.errorProvider.SetError(txtCorreo, "");
                }
            }
            else
            {
                this.errorProvider.SetError(txtCorreo, "Es requerido ingresar un correo.");
            }
        }

        private void dtpFechaNacimiento_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (dtpFechaNacimiento.Value.Year > 2003)
            {
                this.errorProvider.SetError(dtpFechaNacimiento, "Es requerido ingresar una fecha de nacimiento válida.");
            }
            else
            {
                this.errorProvider.SetError(dtpFechaNacimiento, "");
            }
        }

        private void txtDistrito_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (txtDistrito.Text == null)
            {
                this.errorProvider.SetError(txtDistrito, "Es requerido ingresar un distrito.");
            }
            else
            {
                this.errorProvider.SetError(txtDistrito, "");
            }
        }

        private void rbtnMujer_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (rbtnMujer.Checked == false && rbtnHombre.Checked == false)
            {
                this.errorProvider.SetError(rbtnMujer, "Es requerido seleccionar un género.");
            }
            else
            {
                this.errorProvider.SetError(rbtnMujer, "");
            }
        }

        private void btnSubirFoto_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (rutaFoto != "")
            {
                this.errorProvider.SetError(btnSubirFoto, "Debe ingresar una foto para el perfil del psicólogo.");
            }
            else
            {
                this.errorProvider.SetError(btnSubirFoto, "");
            }
        }

    }
}
