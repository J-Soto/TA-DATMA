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
    public partial class frmCrearTemaDeCurso : Form
    {
        private TemaWS.TemaWSClient daoTema;
        

        public frmCrearTemaDeCurso()
        {
            InitializeComponent();
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
