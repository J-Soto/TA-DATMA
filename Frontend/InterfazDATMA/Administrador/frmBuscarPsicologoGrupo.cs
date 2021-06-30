using InterfazDATMA.util;

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
    public partial class frmBuscarPsicologoGrupo : MaterialSkin.Controls.MaterialForm 
    {

        private BindingList<PsicologoWS.psicologo> psicologos;
        private PsicologoWS.PsicologoWSClient daoPsicologo;
        private PsicologoWS.psicologo psicologoSelected = null;
        
        public PsicologoWS.psicologo PsicologoSelected { get => psicologoSelected; set => psicologoSelected = value; }

        public frmBuscarPsicologoGrupo()
        {
            this.DoubleBuffered = true;
            InitializeComponent();

            Design.Ini(this);
            dgvPsicologos.AutoGenerateColumns = false;
            dgvPsicologos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            txtNombrePsico.Text = "";
            daoPsicologo = new PsicologoWS.PsicologoWSClient();
            psicologos = new BindingList<PsicologoWS.psicologo>(daoPsicologo.listarTodosPsicologos().ToList());
            dgvPsicologos.DataSource = psicologos;
        }

        private void dgvPsicologos_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            PsicologoWS.psicologo auxPsicologo = dgvPsicologos.Rows[e.RowIndex].DataBoundItem as PsicologoWS.psicologo;

            dgvPsicologos.Rows[e.RowIndex].Cells["Nombre"].Value = auxPsicologo.nombre;
            dgvPsicologos.Rows[e.RowIndex].Cells["Apellidos"].Value = auxPsicologo.apellidoPaterno + " " + auxPsicologo.apellidoMaterno;
            dgvPsicologos.Rows[e.RowIndex].Cells["Correo"].Value = auxPsicologo.correo;
            dgvPsicologos.Rows[e.RowIndex].Cells["Celular"].Value = auxPsicologo.celular;
        }

        private void btnBuscarPsico_Click(object sender, EventArgs e)
        {
            if (txtNombrePsico.Text != "")
            {
                psicologos = new BindingList<PsicologoWS.psicologo>(daoPsicologo.listarPsicologosPorNombre(txtNombrePsico.Text).ToList());

                dgvPsicologos.DataSource = psicologos;
            }

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void btnAgregarPsico_Click(object sender, EventArgs e)
        {
            if (dgvPsicologos.RowCount != 0)
            {
                psicologoSelected = dgvPsicologos.CurrentRow.DataBoundItem as PsicologoWS.psicologo;
                this.DialogResult = DialogResult.OK;
            }

        }
    }
}
