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
using InterfazDATMA.util;

namespace InterfazDATMA.Administrador
{
    public partial class frmOperacionesPersona : MaterialSkin.Controls.MaterialForm 
    {
        private frmPlantillaGestion formPlantilla;
        private frmGestionarModuloAdmin formGestionarModulos;

        private TutorWS.TutorWSClient daoTutor;
        private PsicologoWS.PsicologoWSClient daoPsicologo;
        private int cantidadFilas;

        public frmOperacionesPersona(frmGestionarModuloAdmin formGestionarModulos, frmPlantillaGestion formPlantilla)
        {
            this.DoubleBuffered = true;
            InitializeComponent();
            Design.Ini(this);
            daoTutor = new TutorWS.TutorWSClient();
            daoPsicologo = new PsicologoWS.PsicologoWSClient();

            this.formPlantilla = formPlantilla;
            this.formGestionarModulos = formGestionarModulos;
            // dgvTutores
            dgvTutores.AutoGenerateColumns = false;
            dgvTutores.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            // dgvPsicologos
            dgvPsicologos.AutoGenerateColumns = false;
            dgvPsicologos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            // "psicologos" es una coleción genérica
            BindingList<PsicologoWS.psicologo> psicologos;
            try
            {
                psicologos = new BindingList<PsicologoWS.psicologo>(daoPsicologo.listarTodosPsicologos().ToList());
            }
            catch (ArgumentNullException ex)
            {
                psicologos = new BindingList<PsicologoWS.psicologo>();
            }
            dgvPsicologos.DataSource = psicologos;
            PsicologoWS.psicologo psicologo;

            // "tutores" es una coleción genérica
            BindingList<TutorWS.tutor> tutores;
            try
            {
                tutores = new BindingList<TutorWS.tutor>(daoTutor.listarTutoresPorNombre("").ToList());
            }
            catch (ArgumentNullException ex)
            {
                tutores = new BindingList<TutorWS.tutor>();
            }
            dgvTutores.DataSource = tutores;

            TutorWS.tutor tutor;


            cantidadFilas = dgvPsicologos.RowCount + dgvTutores.RowCount;
            dgvUsuario.RowCount = cantidadFilas;

            int i;
            for (i=0; i < dgvPsicologos.RowCount; i++)
            {
                psicologo = (PsicologoWS.psicologo)dgvPsicologos.Rows[i].DataBoundItem;
                dgvUsuario.Rows[i].Cells[0].Value = psicologo.apellidoPaterno + " " + psicologo.apellidoMaterno + " " + psicologo.nombre;
                dgvUsuario.Rows[i].Cells[1].Value = psicologo.celular;
                dgvUsuario.Rows[i].Cells[2].Value = psicologo.correo;
                dgvUsuario.Rows[i].Cells[3].Value = "Psicologo";
                if (psicologo.activoPsicologo == 1)
                {
                    dgvUsuario.Rows[i].Cells[4].Value = "Sí";
                }
                else
                {
                    dgvUsuario.Rows[i].Cells[4].Value = "No";
                }
                dgvUsuario.Rows[i].Cells[5].Value = psicologo.fotoPerfil;
            }



            for (int j = i; j < dgvTutores.RowCount+i; j++)
            {
                tutor = (TutorWS.tutor)dgvTutores.Rows[j-i].DataBoundItem;
                dgvUsuario.Rows[j].Cells[0].Value = tutor.apellidoPaterno + " " + tutor.apellidoMaterno + " " + tutor.nombre;
                dgvUsuario.Rows[j].Cells[1].Value = tutor.celular;
                dgvUsuario.Rows[j].Cells[2].Value = tutor.correo;
                dgvUsuario.Rows[j].Cells[3].Value = "Tutor";
                if (tutor.activoTutor == 1)
                {
                    dgvUsuario.Rows[j].Cells[4].Value = "Sí";
                }
                else
                {
                    dgvUsuario.Rows[j].Cells[4].Value = "No";
                }
                dgvUsuario.Rows[j].Cells[5].Value = tutor.fotoPerfil;
            }

            dgvUsuario.RowTemplate.Height = 200;

            dgvUsuario.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            // Ordenar Alfabeticamente el DatagridView
            this.dgvUsuario.Sort(this.dgvUsuario.Columns[0], ListSortDirection.Ascending);
        }


        public void inicializarTablas()
        {
            BindingList<PsicologoWS.psicologo> psicologos;
            try
            {
                psicologos = new BindingList<PsicologoWS.psicologo>(daoPsicologo.listarTodosPsicologos().ToList());
            }
            catch (ArgumentNullException ex)
            {
                psicologos = new BindingList<PsicologoWS.psicologo>();
            }
            dgvPsicologos.DataSource = psicologos;

        }

        private void txtBusqTutor_MouseClick(object sender, MouseEventArgs e)
        {
            if (txtBusqTutor.Text == "Nombres y Apellidos")
                txtBusqTutor.Text = "";
        }


        private void dgvPsicologos_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {

        }

        private void dgvUsuario_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {

        }


        private void dgvTutores_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {

        }


        private void dgvTutores_SelectionChanged(object sender, EventArgs e)
        {
            dgvPsicologos.ClearSelection();
        }

        private void dgvPsicologos_SelectionChanged(object sender, EventArgs e)
        {
            dgvTutores.ClearSelection();
        }

        private void btnBuscarTutor_Click_1(object sender, EventArgs e)
        {
            BindingList<TutorWS.tutor> tutores;
            try
            {
                tutores = new BindingList<TutorWS.tutor>(daoTutor.listarTutoresPorNombre(txtBusqTutor.Text).ToList());
            }
            catch (ArgumentNullException ex)
            {
                tutores = new BindingList<TutorWS.tutor>();
            }
            dgvTutores.DataSource = tutores;

        }

        private void btnInsertarTutor_Click_1(object sender, EventArgs e)
        {
            formPlantilla.abrirFormulario(new frmInsertarTutor(this, formPlantilla));

        }

        private void btnModificarTutor_Click_1(object sender, EventArgs e)
        {

            if (dgvTutores.RowCount != 0)
            {
                TutorWS.tutor tutor = (TutorWS.tutor)dgvTutores.CurrentRow.DataBoundItem;
                frmModificarTutor formModificarTutor = new frmModificarTutor(this, formPlantilla, tutor);

                formPlantilla.abrirFormulario(new frmModificarTutor(this, formPlantilla, tutor));
            }

        }

        private void btnInsertarPsi_Click_1(object sender, EventArgs e)
        {
            formPlantilla.abrirFormulario(new frmInsertarPsicologo(this, formPlantilla));

        }

        private void btnModificarPsi_Click_1(object sender, EventArgs e)
        {
            // ¿el usuario es psicologo o tutor?
            if (dgvUsuario.CurrentRow.Cells[3].Value.ToString() == "Psicologo")     // Si es Psicologo
            {
                if (dgvPsicologos.RowCount != 0)
                {
                    BindingList<PsicologoWS.psicologo> psicologos;
                    psicologos = new BindingList<PsicologoWS.psicologo>(daoPsicologo.listarPsicologosPorNombre(dgvUsuario.CurrentRow.Cells[0].Value.ToString()).ToList());
                    dgvPsicologos.DataSource = psicologos;

                    PsicologoWS.psicologo psicologo = (PsicologoWS.psicologo)dgvPsicologos.Rows[0].DataBoundItem;
                    frmModificarPsicologo formModificarPsicologo = new frmModificarPsicologo(this, formPlantilla, psicologo);

                    formPlantilla.abrirFormulario(formModificarPsicologo);
                }
            }
            else  // Si es Tutor
            {
                if (dgvTutores.RowCount != 0)
                {
                    BindingList<TutorWS.tutor> tutores;
                    tutores = new BindingList<TutorWS.tutor>(daoTutor.listarTutoresPorNombre(dgvUsuario.CurrentRow.Cells[0].Value.ToString()).ToList());
                    dgvTutores.DataSource = tutores;

                    TutorWS.tutor tutor = (TutorWS.tutor)dgvTutores.Rows[0].DataBoundItem;
                    frmModificarTutor formModificarTutor = new frmModificarTutor(this, formPlantilla, tutor);

                    formPlantilla.abrirFormulario(formModificarTutor);
                }
            }
        }

        private void btnListarTut_Click_1(object sender, EventArgs e)
        {
            formPlantilla.abrirFormulario(new frmListaTutores());
        }

        private void btnListarPsi_Click_1(object sender, EventArgs e)
        {
            formPlantilla.abrirFormulario(new Header());
        }

        private void btnDeshabilitar_Click_1(object sender, EventArgs e)
        {
            if (dgvPsicologos.SelectedRows.Count > 0)
            {
                var resultado = MessageBox.Show("Se eliminará esta persona del sistema. Quiere Continuar", "Mensaje de Confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (resultado == DialogResult.Yes)
                {
                    PsicologoWS.psicologo psicologo = new PsicologoWS.psicologo();
                    psicologo = (PsicologoWS.psicologo)dgvPsicologos.SelectedRows[0].DataBoundItem;
                    daoPsicologo.eliminarPsicologo(psicologo.idPersona, psicologo.idUsuario);
                }

            }
            else if (dgvTutores.SelectedRows.Count > 0)
            {
                var resultado = MessageBox.Show("Se eliminará esta persona del sistema. Quiere Continuar", "Mensaje de Confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (resultado == DialogResult.Yes)
                {
                    TutorWS.tutor tutor = new TutorWS.tutor();
                    tutor = (TutorWS.tutor)dgvTutores.SelectedRows[0].DataBoundItem;
                    daoTutor.eliminarTutor(tutor.idPersona, tutor.idUsuario);
                }
            }

        }

        private void materialFlatButton1_Click(object sender, EventArgs e)
        {
            if (this.dgvUsuario.Columns[5].Visible == true)
            {
                this.btnMostrarFoto.Text = "Mostrar Foto";
                this.dgvUsuario.Columns[5].Visible = false;
            }
            else
            {
                this.btnMostrarFoto.Text = "Ocultar Foto";
                this.dgvUsuario.Columns[5].Visible = true;
            }
        }

        private void txtBusqTutor_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkSoloPsicologos_CheckedChanged(object sender, EventArgs e)
        {
            if (this.checkSoloPsicologos.Checked)
            {
                this.checkSoloTutores.Enabled = false;
                this.dgvUsuario.Columns[3].Visible = false;     // Oculto la columna de Tipo de Usuario
                for (int i=0; i < cantidadFilas; i++)
                {
                    if (this.dgvUsuario.Rows[i].Cells[3].Value != null)
                    {
                        if (this.dgvUsuario.Rows[i].Cells[3].Value.ToString() == "Tutor")
                        {
                            this.dgvUsuario.Rows[i].Visible = false;
                        }
                    }
                }
            }
            else
            {
                this.checkSoloTutores.Enabled = true;
                this.dgvUsuario.Columns[3].Visible = true;     // Muestro la columna de Tipo de Usuario
                for (int i = 0; i < cantidadFilas; i++)
                {
                    if (this.dgvUsuario.Rows[i].Cells[3].Value != null)
                    {
                        if (this.dgvUsuario.Rows[i].Cells[3].Value.ToString() == "Tutor")
                        {
                            this.dgvUsuario.Rows[i].Visible = true;
                        }
                    }
                }
            }
        }

        private void checkSoloTutores_CheckedChanged(object sender, EventArgs e)
        {
            if (this.checkSoloTutores.Checked)
            {
                this.checkSoloPsicologos.Enabled = false;      
                this.dgvUsuario.Columns[3].Visible = false;     // Oculto la columna de Tipo de Usuario
                for (int i = 0; i < cantidadFilas; i++)
                {
                    if (this.dgvUsuario.Rows[i].Cells[3].Value != null)
                    {
                        if (this.dgvUsuario.Rows[i].Cells[3].Value.ToString() == "Psicologo")
                        {
                            this.dgvUsuario.Rows[i].Visible = false;
                        }
                    }
                }
            }
            else
            {
                this.checkSoloPsicologos.Enabled = true;
                this.dgvUsuario.Columns[3].Visible = true;     // Muestro la columna de Tipo de Usuario
                for (int i = 0; i < cantidadFilas; i++)
                {
                    if (this.dgvUsuario.Rows[i].Cells[3].Value != null)
                    {
                        if (this.dgvUsuario.Rows[i].Cells[3].Value.ToString() == "Psicologo")
                        {
                            this.dgvUsuario.Rows[i].Visible = true;
                        }
                    }
                }
            }
        }
    }
}
