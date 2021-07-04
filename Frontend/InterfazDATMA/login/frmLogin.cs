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
using InterfazDATMA.util;
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
            Design.Ini(this);
            daoUsuario = new UsuarioWS.UsuarioWSClient();
            this.AcceptButton = btnIngresar; 
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

        private void frmLogin_Load(object sender, EventArgs e)
        {
             
        }

        private void btnIngresar_Click_1(object sender, EventArgs e)
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

        private void materialButton2_Click(object sender, EventArgs e)
        {

        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "Usuario") txtUsuario.Text = "";
            
        }

        private void txtContraseña_TextChanged(object sender, EventArgs e)
        {
           if (txtContraseña.Text == "Password") txtContraseña.Text = "";
        }
    }
}
