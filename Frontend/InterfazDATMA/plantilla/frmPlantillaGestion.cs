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
using InterfazDATMA.Administrador;
using InterfazDATMA.cuidador;
using InterfazDATMA.psicologo;

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

        public frmPlantillaGestion(UsuarioWS.usuario user)
        {
            InitializeComponent();
            MaterialSkin.MaterialSkinManager skinManager = MaterialSkin.MaterialSkinManager.Instance;
            skinManager.AddFormToManage(this);
            skinManager.Theme = MaterialSkin.MaterialSkinManager.Themes.DARK;
            skinManager.ColorScheme = new MaterialSkin.ColorScheme(MaterialSkin.Primary.BlueGrey500, MaterialSkin.Primary.BlueGrey700, MaterialSkin.Primary.BlueGrey100, MaterialSkin.Accent.Teal700, MaterialSkin.TextShade.WHITE);

            frmPlantillaGestion.user = user;
            int tipoUser = user.tipo;
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
                btnPerfil.Enabled = false;
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

        MaterialSkinManager ThemeManager = MaterialSkinManager.Instance;
        private void button2_Click(object sender, EventArgs e)
        {
            if (ThemeManager.Theme == MaterialSkinManager.Themes.LIGHT) ThemeManager.Theme = MaterialSkinManager.Themes.DARK;
            else ThemeManager.Theme = MaterialSkinManager.Themes.LIGHT;
        }
    }
}
