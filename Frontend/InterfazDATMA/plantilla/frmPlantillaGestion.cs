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
        public string nombre;
        public string apP;
        public string apM;
        public MaterialSkinManager ThemeManager = MaterialSkinManager.Instance;
        bool seMuestra;
        public static bool pasoTutorial = false;
        public int tipoUser;
        private TutorWS.TutorWSClient daoTutor = new TutorWS.TutorWSClient();
        private PsicologoWS.PsicologoWSClient daoPsicologo = new PsicologoWS.PsicologoWSClient();

        public frmPlantillaGestion(UsuarioWS.usuario user)
        {
            InitializeComponent();
            Design.Ini(this);
            if (Design.tema == 'd') ThemeManager.Theme = MaterialSkinManager.Themes.DARK;
            else ThemeManager.Theme = MaterialSkinManager.Themes.LIGHT;
            PanelLateral.Width = 0;
            PanelLateral.Hide();
            frmPlantillaGestion.user = user;
            tipoUser = user.tipo;
            fecha.Text = DateTime.Now.ToLongDateString();
            
            //Psicologo
            if (tipoUser == 1)
            {
                psico = daoPsicologo.buscarPsicologoPorIdUsuario(user.idUsuario);
                nombre = psico.nombre;
                apM = psico.apellidoMaterno;
                apP = psico.apellidoPaterno;
                Usuario.Text = "Usuario:   " + nombre + "   " + apP+ "    " + apM;
                formInicial = new Bienvenida(this);
                abrirFormulario(formInicial);
                formPerfil = new frmPerfilPsicologo(this);
            }
            //Administrador
           
            else if (tipoUser == 2)
            {
                formInicial = new Bienvenida(this);
                abrirFormulario(formInicial);
                btnperfil.Enabled = false;
            }
            //Tutor
            else if (tipoUser == 0)
            {
                tutor = daoTutor.getTutorFromIdUsuario(user.idUsuario);
                formPerfil = new frmPerfilCuidador(this);
                nombre = tutor.nombre;
                apM = tutor.apellidoMaterno;
                apP = tutor.apellidoPaterno;
                Usuario.Text = "Usuario:   " + nombre + "   " + apP + "    " + apM;
                formInicial = new Bienvenida(this);
                abrirFormulario(formInicial);
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
                if (pasoTutorial)
                {
                    abrirFormulario(new frmListaCursoInscritos(this));
                } else
                {
                    abrirFormulario(formInicial);
                }
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
                if (PanelLateral.Width >= (this.Width * 0.02)) timer.Stop();
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

        

        private void btnTema_CheckedChanged(object sender, EventArgs e)
        { 
            if (ThemeManager.Theme == MaterialSkinManager.Themes.LIGHT)
            {
                Design.tema = 'd';
                ThemeManager.Theme = MaterialSkinManager.Themes.DARK;
                btnTema.Text = "          Oscuro";
                pictureBox4.Image = Properties.Resources.moon;
            }

            else
            {
                Design.tema = 'l';
                btnTema.Text = "          Claro";
                ThemeManager.Theme = MaterialSkinManager.Themes.LIGHT;
                pictureBox4.Image = Properties.Resources.sun;
            }
        }

        
    }

    public class TableStyles
    {
        private static DataGridView clone = new DataGridView();

        public static void CopyStyles(DataGridView src)
        {
            clone.DefaultCellStyle = src.DefaultCellStyle;
            clone.ColumnHeadersDefaultCellStyle = src.ColumnHeadersDefaultCellStyle;
            clone.BorderStyle = src.BorderStyle;
            clone.ColumnHeadersBorderStyle = src.ColumnHeadersBorderStyle;
            clone.RowHeadersDefaultCellStyle = src.RowHeadersDefaultCellStyle;
            clone.RowsDefaultCellStyle = src.RowsDefaultCellStyle;
            clone.BackgroundColor = src.BackgroundColor;
            clone.GridColor = src.GridColor;
            clone.EnableHeadersVisualStyles = src.EnableHeadersVisualStyles;
        }

        public static void ApplyStyles(DataGridView dest)
        {
            dest.DefaultCellStyle = clone.DefaultCellStyle;
            dest.ColumnHeadersDefaultCellStyle = clone.ColumnHeadersDefaultCellStyle;
            dest.BorderStyle = clone.BorderStyle;
            dest.ColumnHeadersBorderStyle = clone.ColumnHeadersBorderStyle;
            dest.RowHeadersDefaultCellStyle = clone.RowHeadersDefaultCellStyle;
            dest.RowsDefaultCellStyle = clone.RowsDefaultCellStyle;
            dest.BackgroundColor = clone.BackgroundColor;
            dest.GridColor = clone.GridColor;
            dest.EnableHeadersVisualStyles = clone.EnableHeadersVisualStyles;
        }
    }
}