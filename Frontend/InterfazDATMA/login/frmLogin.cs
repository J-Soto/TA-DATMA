using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using InterfazDATMA.plantilla;
using InterfazDATMA;
using System.ServiceModel;


namespace InterfazDATMA
{
    public partial class frmLogin : MaterialForm
    {
        private string _user = null;
        private string _password = null;
        private Form formularioActivo = null;

        //private UsuarioWSClient daoUsuario;
        private UsuarioWS.UsuarioWSClient daoUsuario;
        public frmLogin()
        {
            InitializeComponent();
            MaterialSkin.MaterialSkinManager skinManager = MaterialSkin.MaterialSkinManager.Instance;
            skinManager.AddFormToManage(this);
            skinManager.Theme = MaterialSkin.MaterialSkinManager.Themes.DARK;
            skinManager.ColorScheme = new MaterialSkin.ColorScheme(MaterialSkin.Primary.BlueGrey500,MaterialSkin.Primary.BlueGrey700,MaterialSkin.Primary.BlueGrey100,MaterialSkin.Accent.Teal700,MaterialSkin.TextShade.WHITE);
            daoUsuario = new UsuarioWS.UsuarioWSClient();
        }

        private void clickUsuario(object sender, MouseEventArgs e)
        {            
            if(txtUsuario.Text=="Usuario")
                txtUsuario.Text = "";
        }

        private void ClickContraseña(object sender, MouseEventArgs e)
        {
            if (txtContraseña.Text == "Contraseña")
                txtContraseña.Text = "";
        }

        public void abrirFormulario(Form formularioMostrar)
        {
            //formularioActivo.Close();
            formularioActivo = formularioMostrar;/*
            formularioMostrar.TopLevel = false;
            formularioMostrar.FormBorderStyle = FormBorderStyle.None;
            formularioMostrar.Dock = DockStyle.Fill;
            panelContenedor.Controls.Add(formularioMostrar);
            panelContenedor.Tag = formularioMostrar;*/
            formularioMostrar.Show();
            this.Hide();
            if (checkBoxRecordarme.Checked)
            { 
                _user = txtUsuario.Text;
                _password = txtContraseña.Text;
            }
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            UsuarioWS.usuario user = daoUsuario.verificarUsuario(txtUsuario.Text, txtContraseña.Text);

            if (user is null)
            {
                MessageBox.Show("Datos incorrectos", "Mensaje de Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            abrirFormulario(new frmPlantillaGestion(user));
            //abrirFormulario(new frmWalkthrough());
            //0->cuidador
            //1->psicologo
            //2->admin

        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
