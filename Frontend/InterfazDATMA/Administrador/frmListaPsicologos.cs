using MaterialSkin.Controls;
using InterfazDATMA.PsicologoWS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using InterfazDATMA.util;

namespace InterfazDATMA.Administrador
{
    public partial class Header : MaterialSkin.Controls.MaterialForm 
    {
        private PsicologoWS.PsicologoWSClient daoPsicologo;

        public Header()
        {
            this.DoubleBuffered = true;
            InitializeComponent();

            Design.Ini(this);
            daoPsicologo = new PsicologoWS.PsicologoWSClient();
            dgvPsico.AutoGenerateColumns = false;
            dgvPsico.DataSource = new BindingList<PsicologoWS.psicologo>(daoPsicologo.listarTodosPsicologos().ToList());
        }


        private void btnBuscar_Click_1(object sender, EventArgs e)
        {
            BindingList<PsicologoWS.psicologo> psicos = new BindingList<PsicologoWS.psicologo>(daoPsicologo.listarTodosPsicologos().ToList());
            for (int i = 0; i < psicos.Count; i++)
            {
                if (!psicos[i].nombre.Contains(txtBuscar.Text))
                {
                    psicos.RemoveAt(i);
                    i--;
                }
            }
            dgvPsico.DataSource = psicos;

        }
    }

}
