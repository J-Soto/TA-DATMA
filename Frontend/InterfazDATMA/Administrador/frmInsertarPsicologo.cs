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
    public partial class frmInsertarPsicologo : MaterialSkin.Controls.MaterialForm 
    {
        private frmPlantillaGestion formPlantilla;
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

        private void txtNombre_TextChanged(object sender, EventArgs e)
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
            else
            {
                psicologo.fotoPerfil = null;
            }


            //Validaciones:
            if (psicologo.DNI.Length != 8)  // Si el DNI es una cadena diferente de longitud 8
            {
                MessageBox.Show("El DNI debe tener 8 digitos.", "Mensaje de Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (psicologo.DNI[0] == '0')    // Si el DNI inicia con cero 
            {
                MessageBox.Show("El DNI no puede empezar con cero.", "Mensaje de Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (psicologo.celular.Length != 9) // Si el celular es una cadena diferente de longitud 9
            {
                MessageBox.Show("El número de celular debe tener 9 digitos.", "Mensaje de Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (psicologo.celular[0] != '9')   // Si el numero de celular no empieza con 9
            {
                MessageBox.Show("El número de celular debe empezar con nueve.", "Mensaje de Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (psicologo.telefono.Length != 7)    // Si el número de telefono inicia con 7
            {
                MessageBox.Show("El telefono debe tener 7 digitos", "Mensaje de Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (psicologo.telefono[0] == '0')       // Si el numero de telefono inicia con cero
            {
                MessageBox.Show("El número de teléfono no puede empezar con cero", "Mensaje de Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (!Char.IsLetter(psicologo.correo[0]) || psicologo.correo.Contains("@") != true || (psicologo.correo.Contains(".com") || psicologo.correo.Contains(".pe")) != true)       // El correo debe tener el @, iniciar con .com o .pe y además debe comenzar con una letra
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

        }

        private void frmInsertarPsicologo_Load(object sender, EventArgs e)
        {

        }
    }
}
