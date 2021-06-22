using MaterialSkin.Controls;
using InterfazDATMA.plantilla;
using InterfazDATMA.util;
using InterfazDATMA.validacion;
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
    public partial class frmModificarGrupoCurso : MaterialForm
    {

        private frmVerGruposCurso formVerGruposCurso;
        private frmPlantillaGestion formPlantillaGest;

        private BindingList<PsicologoWS.psicologo> psicologosGrupo; //Total
        private BindingList<PsicologoWS.psicologo> psicologoTemporales; //Se introducen al momento de guardar

        private Grupo_Curso grupo;
        private frmBuscarPsicologoGrupo formBuscarPsicologoGrupo;

        public frmModificarGrupoCurso(frmVerGruposCurso formVerGruposCurso, frmPlantillaGestion formPlantillaGest, Grupo_Curso grupo)
        {
            this.formVerGruposCurso = formVerGruposCurso;
            this.formPlantillaGest = formPlantillaGest;
            this.grupo = grupo;

            InitializeComponent();

            dgvPsicologos.AutoGenerateColumns = false;
            dgvPsicologos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            dgvTutores.AutoGenerateColumns = false;
            dgvTutores.SelectionMode = DataGridViewSelectionMode.FullRowSelect;


            inicializarPantalla();
        }

        private void inicializarPantalla()
        {
            psicologosGrupo = grupo.Psicologos;
            dgvPsicologos.DataSource = psicologosGrupo;

            txtMaxTutores.Text = grupo.Grupo.maxCantCuidadores.ToString();
            txtNombreGrupo.Text = grupo.Grupo.nombrePromocion;

            psicologoTemporales = new BindingList<PsicologoWS.psicologo>();
        }


        private void btnGuardar_Click(object sender, EventArgs e)
        {
            grupo.Grupo.maxCantCuidadores = Int32.Parse(txtMaxTutores.Text);
            grupo.Grupo.nombrePromocion = txtNombreGrupo.Text;
            grupo.Psicologos = psicologosGrupo;
            
            formPlantillaGest.abrirFormulario(formVerGruposCurso);
        }

        private void txtMaxTutores_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.SoloNumeros(e);
        }

        private void btnAgregarPsico_Click(object sender, EventArgs e)
        {
            formBuscarPsicologoGrupo = new frmBuscarPsicologoGrupo();
            int flag = 1;
            if (formBuscarPsicologoGrupo.ShowDialog() == DialogResult.OK)
            {
                foreach (PsicologoWS.psicologo recPsicologo in psicologosGrupo)
                {
                    if (recPsicologo.idPersona == formBuscarPsicologoGrupo.PsicologoSelected.idPersona)
                    {
                        flag = 0;
                        break;
                    }
                }

                if (flag == 1)
                {
                    psicologoTemporales.Add(formBuscarPsicologoGrupo.PsicologoSelected);
                    psicologosGrupo.Add(formBuscarPsicologoGrupo.PsicologoSelected);
                    dgvPsicologos.DataSource = psicologosGrupo;
                }
                else
                {
                    MessageBox.Show("El psicologo ya esta registrado", "Mensaje de Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btnEliminarPsico_Click(object sender, EventArgs e)
        {
            if (dgvPsicologos.RowCount != 0)
            {
                PsicologoWS.psicologo auxPsico = dgvPsicologos.CurrentRow.DataBoundItem as PsicologoWS.psicologo;

                for (int i = 0; i < dgvPsicologos.RowCount; i++)
                {
                    PsicologoWS.psicologo auxDGVPsico = dgvPsicologos.Rows[i].DataBoundItem as PsicologoWS.psicologo;

                    if (auxDGVPsico.idPersona == auxPsico.idPersona)
                    {
                        
                        dgvPsicologos.Rows.Remove(dgvPsicologos.Rows[i]);

                        break;
                    }
                }

                psicologosGrupo.Remove(auxPsico);
                dgvPsicologos.DataSource = psicologosGrupo;
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            foreach(PsicologoWS.psicologo recPsicologo in psicologoTemporales)
            {
                psicologosGrupo.Remove(recPsicologo);
            }

            formPlantillaGest.abrirFormulario(formVerGruposCurso);
        }

        private void dgvPsicologos_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            try
            {
                PsicologoWS.psicologo auxPsicologo = dgvPsicologos.Rows[e.RowIndex].DataBoundItem as PsicologoWS.psicologo;

                dgvPsicologos.Rows[e.RowIndex].Cells["Nombre"].Value = auxPsicologo.nombre;
                dgvPsicologos.Rows[e.RowIndex].Cells["Apellidos"].Value = auxPsicologo.apellidoPaterno + " " + auxPsicologo.apellidoMaterno;
                dgvPsicologos.Rows[e.RowIndex].Cells["DNI"].Value = auxPsicologo.DNI;
                dgvPsicologos.Rows[e.RowIndex].Cells["Correo"].Value = auxPsicologo.correo;
                dgvPsicologos.Rows[e.RowIndex].Cells["User"].Value = auxPsicologo.user;
                dgvPsicologos.Rows[e.RowIndex].Cells["Celular"].Value = auxPsicologo.celular;
            }catch(Exception ex)
            {
                
            }
                
        }

    }
}
