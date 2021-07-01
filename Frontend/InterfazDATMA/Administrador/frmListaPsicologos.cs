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
            
            BindingList<PsicologoWS.psicologo> psicologos;
            psicologos = new BindingList<PsicologoWS.psicologo>(daoPsicologo.listarTodosPsicologos().ToList());
            
            dgvPsico.DataSource = psicologos;
            PsicologoWS.psicologo psicologo;

            for (int i = 0; i < dgvPsico.RowCount-1; i++)
            {
                psicologo = (PsicologoWS.psicologo)dgvPsico.Rows[i].DataBoundItem;

                dgvPsico.Rows[i].Cells[0].Value = psicologo.nombre;
                dgvPsico.Rows[i].Cells[1].Value = psicologo.apellidoMaterno;
                dgvPsico.Rows[i].Cells[2].Value = psicologo.apellidoPaterno;
                dgvPsico.Rows[i].Cells[3].Value = psicologo.DNI;
                dgvPsico.Rows[i].Cells[4].Value = psicologo.fechaNacimiento;
                dgvPsico.Rows[i].Cells[5].Value = psicologo.edad;
                dgvPsico.Rows[i].Cells[6].Value = psicologo.telefono;
                dgvPsico.Rows[i].Cells[7].Value = psicologo.celular;
                dgvPsico.Rows[i].Cells[8].Value = psicologo.correo;
            }
        }


        private void btnBuscar_Click_1(object sender, EventArgs e)
        {
            BindingList<PsicologoWS.psicologo> psicologos;
            try
            {
                psicologos = new BindingList<PsicologoWS.psicologo>(daoPsicologo.listarPsicologosPorNombre(txtBuscar.Text).ToList());
            }
            catch (ArgumentNullException ex)
            {
                psicologos = new BindingList<PsicologoWS.psicologo>();
            }
            dgvPsico.DataSource = psicologos;
            PsicologoWS.psicologo psicologo;

            for (int i = 0; i < dgvPsico.RowCount - 1; i++)
            {
                psicologo = (PsicologoWS.psicologo)dgvPsico.Rows[i].DataBoundItem;

                dgvPsico.Rows[i].Cells[0].Value = psicologo.nombre;
                dgvPsico.Rows[i].Cells[1].Value = psicologo.apellidoMaterno;
                dgvPsico.Rows[i].Cells[2].Value = psicologo.apellidoPaterno;
                dgvPsico.Rows[i].Cells[3].Value = psicologo.DNI;
                dgvPsico.Rows[i].Cells[4].Value = psicologo.fechaNacimiento;
                dgvPsico.Rows[i].Cells[5].Value = psicologo.edad;
                dgvPsico.Rows[i].Cells[6].Value = psicologo.telefono;
                dgvPsico.Rows[i].Cells[7].Value = psicologo.celular;
                dgvPsico.Rows[i].Cells[8].Value = psicologo.correo;
            }
        }
    }

}
