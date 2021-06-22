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
    public partial class frmInsertarPsicologo : MaterialSkin.Controls.MaterialForm 
    {
        private frmPlantillaGestion formPlantilla;
        public frmOperacionesPersona formOperacionPersona;

        private PsicologoWS.PsicologoWSClient daoPsicologo;
        private PsicologoWS.distrito distrito;
        private string rutaFoto = "";

        public frmInsertarPsicologo(frmOperacionesPersona formOperacionPersona, frmPlantillaGestion formPlantilla)
        {
            InitializeComponent();
            MaterialSkin.MaterialSkinManager skinManager = MaterialSkin.MaterialSkinManager.Instance;
            skinManager.AddFormToManage(this);
            skinManager.Theme = MaterialSkin.MaterialSkinManager.Themes.DARK;
            skinManager.ColorScheme = new MaterialSkin.ColorScheme(MaterialSkin.Primary.BlueGrey500, MaterialSkin.Primary.BlueGrey700, MaterialSkin.Primary.BlueGrey100, MaterialSkin.Accent.Teal700, MaterialSkin.TextShade.WHITE);

            this.formPlantilla = formPlantilla;
            this.formOperacionPersona = formOperacionPersona;
            daoPsicologo = new PsicologoWS.PsicologoWSClient();

            txtDistrito.ReadOnly = true;
            inicializarComponentes();

        }

        private void inicializarComponentes()
        {
            txtNombre.Text = "";
            txtApellidoPat.Text = "";
            txtApellidoMat.Text = "";
            txtCorreo.Text = "";
            txtUser.Text = "";
            txtPass.Text = "";
            txtConfirmarPass.Text = "";
            txtDni.Text = "";
            txtTelf.Text = "";
            txtCelular.Text = "";
            rbtnHombre.Checked = false;
            rbtnMujer.Checked = false;
            pbFoto.Image = null;
        }


        private void btnCancelar_Click(object sender, EventArgs e)
        {
            inicializarComponentes();
            formOperacionPersona.inicializarTablas();
            formPlantilla.abrirFormulario(formOperacionPersona);
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

            psicologo.user = txtUser.Text;
            psicologo.password = txtPass.Text;

            //Validaciones:
            if (psicologo.DNI.Length != 8)
            {
                MessageBox.Show("El DNI debe tener 8 digitos", "Mensaje de Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (psicologo.password != txtConfirmarPass.Text)
            {
                MessageBox.Show("Las contraseñas deben coincidir", "Mensaje de Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                            int idPsicologo = daoPsicologo.insertarPsicologo(psicologo);
                            if (idPsicologo != 0)
                            {
                                MessageBox.Show("Se ha registrado con exito", "Mensaje de Confirmacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                psicologo.idPersona = idPsicologo;
                                formPlantilla.abrirFormulario(formOperacionPersona);
                            }

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
                        int idPsicologo = daoPsicologo.insertarPsicologo(psicologo);
                        if (idPsicologo != 0)
                        {
                            MessageBox.Show("Se ha registrado con exito", "Mensaje de Confirmacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            psicologo.idPersona = idPsicologo;
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

        private void btnNuevoDistrito_Click(object sender, EventArgs e)
        {
            frmInsertarDistrito frmDistrito = new frmInsertarDistrito();
            if (frmDistrito.ShowDialog() == DialogResult.OK)
            {

            }
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

        private void cboDistrito_SelectedIndexChanged(object sender, EventArgs e)
        {

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
    }
}
