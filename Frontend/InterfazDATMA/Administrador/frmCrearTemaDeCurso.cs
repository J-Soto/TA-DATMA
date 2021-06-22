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

namespace InterfazDATMA.Administrador
{
    public partial class frmCrearTemaDeCurso : MaterialSkin.Controls.MaterialForm 
    {
        private TemaWS.TemaWSClient daoTema;
        

        public frmCrearTemaDeCurso()
        {
            InitializeComponent();
            MaterialSkin.MaterialSkinManager skinManager = MaterialSkin.MaterialSkinManager.Instance;
            skinManager.AddFormToManage(this);
            skinManager.Theme = MaterialSkin.MaterialSkinManager.Themes.DARK;
            skinManager.ColorScheme = new MaterialSkin.ColorScheme(MaterialSkin.Primary.BlueGrey500, MaterialSkin.Primary.BlueGrey700, MaterialSkin.Primary.BlueGrey100, MaterialSkin.Accent.Teal700, MaterialSkin.TextShade.WHITE);

            daoTema = new TemaWS.TemaWSClient();
            inicializarPantalla();
        }


        private void inicializarPantalla()
        {
            txtNombreTema.Text = "";
            txtDescripcionTema.Text = "";
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
        
        private void btnGuardarTema_Click(object sender, EventArgs e)
        {
            TemaWS.tema tema = new TemaWS.tema();
            tema.nombre = txtNombreTema.Text.Trim();
            tema.descripcion = txtDescripcionTema.Text.Trim();
            int resultado = daoTema.insertarTema(tema);
            if (resultado != 0)
            {
                MessageBox.Show("Se ha registrado el tema correctamente","Mensaje de Confirmacion",MessageBoxButtons.OK,MessageBoxIcon.Information);
                inicializarPantalla();
            }
        }

    }
}
