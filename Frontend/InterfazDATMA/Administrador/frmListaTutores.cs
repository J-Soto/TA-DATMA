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
    public partial class frmListaTutores : MaterialSkin.Controls.MaterialForm 
    {
        private TutorWS.TutorWSClient daoTutor;
        public frmListaTutores()
        {
            this.DoubleBuffered = true;
            InitializeComponent();

            Design.Ini(this);
            daoTutor = new TutorWS.TutorWSClient();
            dgvTutor.AutoGenerateColumns = false;

            if (daoTutor.listarTodosTutores() != null)
            {
                dgvTutor.DataSource = new BindingList<TutorWS.tutor>(daoTutor.listarTodosTutores().ToList());
            }
        }

        private void btnBuscar_Click_1(object sender, EventArgs e)
        {
            BindingList<TutorWS.tutor> tutores;
            try
            {
                tutores = new BindingList<TutorWS.tutor>(daoTutor.listarTutoresPorNombre(txtBuscar.Text).ToList());
            }
            catch (ArgumentNullException ex)
            {
                tutores = new BindingList<TutorWS.tutor>();
            }
            dgvTutor.DataSource = tutores;
            TutorWS.tutor tutor;

            for (int i = 0; i < dgvTutor.RowCount - 1; i++)
            {
                tutor = (TutorWS.tutor)dgvTutor.Rows[i].DataBoundItem;

                dgvTutor.Rows[i].Cells[0].Value = tutor.nombre;
                dgvTutor.Rows[i].Cells[1].Value = tutor.apellidoMaterno;
                dgvTutor.Rows[i].Cells[2].Value = tutor.apellidoPaterno;
                dgvTutor.Rows[i].Cells[3].Value = tutor.DNI;
                dgvTutor.Rows[i].Cells[4].Value = tutor.fechaNacimiento;
                dgvTutor.Rows[i].Cells[5].Value = tutor.edad;
                dgvTutor.Rows[i].Cells[6].Value = tutor.telefono;
                dgvTutor.Rows[i].Cells[7].Value = tutor.celular;
                dgvTutor.Rows[i].Cells[8].Value = tutor.correo;
            }
        }
    }
}
