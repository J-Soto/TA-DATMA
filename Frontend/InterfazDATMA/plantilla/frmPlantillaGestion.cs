using MaterialSkin.Controls;
using MaterialSkin;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using InterfazDATMA.cuidador;
using InterfazDATMA.psicologo;
using InterfazDATMA.util;
using InterfazDATMA.Administrador;

namespace InterfazDATMA.plantilla
{
    public partial class frmPlantillaGestion : MaterialSkin.Controls.MaterialForm 
    {
        private MaterialForm  formularioActivo = null;
        private MaterialForm  formLogout;
        private MaterialForm  formInicial;
        private MaterialForm  formPerfil;
        public static UsuarioWS.usuario user = null;
        public static PsicologoWS.psicologo psico = null;
        public static TutorWS.tutor tutor = null;

        bool seMuestra;
        public frmPlantillaGestion(UsuarioWS.usuario user)
        {
            InitializeComponent();
            Design.Ini(this);
            PanelLateral.Width = 0;
            PanelLateral.Hide();
            frmPlantillaGestion.user = user;
            int tipoUser = user.tipo;
            Usuario.Text = "Usuario:   " + user.nombre + "   " + user.apellidoPaterno + "    "+ user.apellidoMaterno;
            fecha.Text = DateTime.Now.ToLongDateString();
            //Psicologo
            if(tipoUser == 1)
            {
                formInicial = new frmGestionarModulosPsicologo(this);
                abrirFormulario(formInicial);
                formPerfil = new frmPerfilPsicologo(this);
            }
            //Administrador
           
            else if (tipoUser == 2)
            {
                formInicial = new frmGestionarModuloAdmin(this);
                abrirFormulario(formInicial);
                btnperfil.Enabled = false;
            }
            //Tutor
            else if (tipoUser == 0)
            {
                formInicial = new frmWalkthrough(this);
                abrirFormulario(formInicial);
                formPerfil = new frmPerfilCuidador(this);
            }
        }

        public void abrirFormulario(MaterialForm formularioAbrir)
        {
            if (formularioActivo != null) formularioActivo.Hide();
            formularioActivo = formularioAbrir;

            pnlContenedor.Controls.Clear();
            formularioAbrir.TopLevel = false;
            formularioAbrir.FormBorderStyle = FormBorderStyle.None;
            formularioAbrir.Dock = DockStyle.Fill;
            pnlContenedor.Controls.Add(formularioAbrir);

            try
            {
                formularioAbrir.Show();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        private void frmPlantillaGestion_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnInicio_Click_1(object sender, EventArgs e)
        {
            int tipoUser = user.tipo;
            //Psicologo
            if (tipoUser == 1)
            {
                formInicial = new frmGestionarModulosPsicologo(this);
                abrirFormulario(formInicial);
            }
            //Administrador
            else if (tipoUser == 2)
            {
                formInicial = new frmGestionarModuloAdmin(this);
                abrirFormulario(formInicial);
            }
            //Tutor
            else if (tipoUser == 0)
            {
                formInicial = new frmWalkthrough(this);
                abrirFormulario(formInicial);
            }
            
        }

        private void btnPerfil_Click_1(object sender, EventArgs e)
        {
            abrirFormulario(formPerfil);
        }

        private void btnSalir_Click_1(object sender, EventArgs e)
        {
            formLogout = new login.frmLogout();
            formularioActivo.Close();
            formLogout.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (PanelLateral.Visible)
            {
                seMuestra = false;
                PanelLateral.Hide();
                timer.Start();
            }
            else 
            {
                seMuestra = true;
                PanelLateral.Show();
                timer.Start();
            }
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            if (seMuestra)
            {
                if (PanelLateral.Width >= (this.Width * 0.01)) timer.Stop();
                PanelLateral.Width += 200;
            }
            else
            {
                if (PanelLateral.Width <= 0.0) timer.Stop();
                PanelLateral.Width -= 200;
            }
        }

        private void clock_Tick(object sender, EventArgs e)
        {
            reloj.Text = DateTime.Now.ToLongTimeString();
        }

        MaterialSkinManager ThemeManager = MaterialSkinManager.Instance;

        private void btnTema_CheckedChanged(object sender, EventArgs e)
        {
            if (ThemeManager.Theme == MaterialSkinManager.Themes.LIGHT)
            {
                ThemeManager.Theme = MaterialSkinManager.Themes.DARK;
                pictureBox4.Image = Properties.Resources.moon;
            }

            else
            {
                ThemeManager.Theme = MaterialSkinManager.Themes.LIGHT;
                pictureBox4.Image = Properties.Resources.sun;
            }
        }

        
    }
}