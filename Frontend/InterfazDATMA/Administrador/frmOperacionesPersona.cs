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
    public partial class frmOperacionesPersona : MaterialSkin.Controls.MaterialForm 
    {
        private frmPlantillaGestion formPlantilla;
        private frmGestionarModuloAdmin formGestionarModulos;

        private TutorWS.TutorWSClient daoTutor;
        private PsicologoWS.PsicologoWSClient daoPsicologo;
        private CursoWS.CursoWSClient daoCurso;

        public frmOperacionesPersona(frmGestionarModuloAdmin formGestionarModulos, frmPlantillaGestion formPlantilla)
        {
            this.DoubleBuffered = true;
            InitializeComponent();
            MaterialSkin.MaterialSkinManager skinManager = MaterialSkin.MaterialSkinManager.Instance;
            skinManager.AddFormToManage(this);
            skinManager.Theme = MaterialSkin.MaterialSkinManager.Themes.DARK;
            skinManager.ColorScheme = new MaterialSkin.ColorScheme(MaterialSkin.Primary.BlueGrey500, MaterialSkin.Primary.BlueGrey700, MaterialSkin.Primary.BlueGrey100, MaterialSkin.Accent.Teal700, MaterialSkin.TextShade.WHITE);

            daoTutor = new TutorWS.TutorWSClient();
            daoPsicologo = new PsicologoWS.PsicologoWSClient();
            daoCurso = new CursoWS.CursoWSClient();

            this.formPlantilla = formPlantilla;
            this.formGestionarModulos = formGestionarModulos;

            dgvTutores.AutoGenerateColumns = false;
            dgvTutores.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
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


            dgvPsicologos.AutoGenerateColumns = false;
            dgvPsicologos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            BindingList<PsicologoWS.psicologo> psicologos;
            BindingList<CursoWS.curso> cursos;

            try
            {
                psicologos = new BindingList<PsicologoWS.psicologo>(daoPsicologo.listarPsicologosPorNombre("").ToList());
            }
            catch (ArgumentNullException ex)
            {
                psicologos = new BindingList<PsicologoWS.psicologo>();
            }
            dgvPsicologos.DataSource = psicologos;

            inicializarTablas();
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
        }

        private void txtBusqTutor_MouseClick(object sender, MouseEventArgs e)
        {
            if (txtBusqTutor.Text == "Nombres y Apellidos")
                txtBusqTutor.Text = "";
        }

        private void txtBusqPsi_MouseClick(object sender, MouseEventArgs e)
        {
            if (txtBusqPsi.Text == "Nombres y Apellidos")
                txtBusqPsi.Text = "";
        }


        private void dgvPsicologos_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            PsicologoWS.psicologo psicologo = (PsicologoWS.psicologo)dgvPsicologos.Rows[e.RowIndex].DataBoundItem;
            
            dgvPsicologos.Rows[e.RowIndex].Cells["NombreCompleto"].Value = psicologo.nombre + " " + psicologo.apellidoPaterno + " " + psicologo.apellidoMaterno;
            dgvPsicologos.Rows[e.RowIndex].Cells["celular"].Value = psicologo.celular;
            /*Cursos Dictando*/
            try
            {
                dgvPsicologos.Rows[e.RowIndex].Cells["cantCursos"].Value = daoPsicologo.cursosDictandoPorPsicologo(psicologo.idPersona);
            }
            catch (Exception ex)
            {
                dgvPsicologos.Rows[e.RowIndex].Cells["cantCursos"].Value = 0;
            }
            /*---------------*//*
            dgvPsicologos.Rows[e.RowIndex].Cells["foto"].Value = psicologo.fotoPerfil;
            // Las filas deben tener un alto de 100 pixeles
            dgvPsicologos.RowTemplate.Height = 100;*/
        }



        private void dgvTutores_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            TutorWS.tutor tutor = (TutorWS.tutor)dgvTutores.Rows[e.RowIndex].DataBoundItem;

            dgvTutores.Rows[e.RowIndex].Cells["NombreCompletoTutor"].Value = tutor.nombre + " " + tutor.apellidoPaterno + " " + tutor.apellidoMaterno;
            dgvTutores.Rows[e.RowIndex].Cells["celularTutor"].Value = tutor.celular;
            /*Bajos Recursos Económicos*/
            if (tutor.bajoRecursos == 1)
            {
                dgvTutores.Rows[e.RowIndex].Cells["bajoRE"].Value = "Sí";
            }
            else
            {
                dgvTutores.Rows[e.RowIndex].Cells["bajoRE"].Value = "No";
            }
            
            /*---------------*//*
            dgvTutores.Rows[e.RowIndex].Cells["FotoTutor"].Value = tutor.fotoPerfil;
            // Las filas deben tener un alto de 100 pixeles
            dgvTutores.RowTemplate.Height = 100;*/
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

        private void btnBuscarPsi_Click_1(object sender, EventArgs e)
        {
            BindingList<PsicologoWS.psicologo> psicologos;
            try
            {
                psicologos = new BindingList<PsicologoWS.psicologo>(daoPsicologo.listarPsicologosPorNombre(txtBusqPsi.Text).ToList());
            }
            catch (ArgumentNullException ex)
            {
                psicologos = new BindingList<PsicologoWS.psicologo>();
            }
            dgvPsicologos.DataSource = psicologos;

        }

        private void btnInsertarPsi_Click_1(object sender, EventArgs e)
        {
            formPlantilla.abrirFormulario(new frmInsertarPsicologo(this, formPlantilla));

        }

        private void btnModificarPsi_Click_1(object sender, EventArgs e)
        {

            if (dgvPsicologos.RowCount != 0)
            {
                PsicologoWS.psicologo psicologo = (PsicologoWS.psicologo)dgvPsicologos.CurrentRow.DataBoundItem;
                frmModificarPsicologo formModificarPsicologo = new frmModificarPsicologo(this, formPlantilla, psicologo);

                formPlantilla.abrirFormulario(formModificarPsicologo);
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
            this.dgvTutores.Columns["FotoTutor"].Visible = false;
        }

        private void frmOperacionesPersona_Load(object sender, EventArgs e)
        {

        }
    }
}
