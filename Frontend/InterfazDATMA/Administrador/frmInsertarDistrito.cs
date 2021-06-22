using MaterialSkin.Controls;
using InterfazDATMA.plantilla;
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
    public partial class frmInsertarDistrito : MaterialSkin.Controls.MaterialForm 
    {
        private DistritoWS.DistritoWSClient daoDistrito;
        public DistritoWS.distrito distrito;
        public frmInsertarDistrito()
        {
            InitializeComponent();
            MaterialSkin.MaterialSkinManager skinManager = MaterialSkin.MaterialSkinManager.Instance;
            skinManager.AddFormToManage(this);
            skinManager.Theme = MaterialSkin.MaterialSkinManager.Themes.DARK;
            skinManager.ColorScheme = new MaterialSkin.ColorScheme(MaterialSkin.Primary.BlueGrey500, MaterialSkin.Primary.BlueGrey700, MaterialSkin.Primary.BlueGrey100, MaterialSkin.Accent.Teal700, MaterialSkin.TextShade.WHITE);

            daoDistrito = new DistritoWS.DistritoWSClient();

            dgvDistrito.AutoGenerateColumns = false;
            dgvDistrito.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDistrito.DataSource = new BindingList<DistritoWS.distrito>(
                daoDistrito.listarDistritos("").ToList());
            
        }

        

        private void dgvDistrito_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvDistrito.Columns[e.ColumnIndex].Name == "NombreDistrito")
            {
                DistritoWS.distrito distrito = (DistritoWS.distrito)dgvDistrito.Rows[dgvDistrito.SelectedCells[0].RowIndex].DataBoundItem;
                daoDistrito.modificarDistrito(distrito);
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {/*
            BindingList<DistritoWS.distrito> distritos = new BindingList<DistritoWS.distrito>(
                daoDistrito.listarDistritos(txtBuscar.Text).ToList());
            dgvDistrito.DataSource = distritos;*/
            BindingList<DistritoWS.distrito> distritos = new BindingList<DistritoWS.distrito>(
                daoDistrito.lisrarTodosDistritos().ToList());
            for (int i = 0; i < distritos.Count; i++)
            {
                if (!distritos[i].nombre.Contains(txtBuscar.Text))
                {
                    distritos.RemoveAt(i);
                    i--;
                }
            }
            dgvDistrito.DataSource = distritos;

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            distrito = new DistritoWS.distrito();
            distrito = (DistritoWS.distrito)dgvDistrito.SelectedRows[0].DataBoundItem;
            this.DialogResult = DialogResult.OK;

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
