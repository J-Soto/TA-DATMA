using MaterialSkin.Controls;
using InterfazDATMA;
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
using InterfazDATMA.psicologo;
using InterfazDATMA.util;
namespace InterfazDATMA
{
    public partial class frmModificarPrograma : MaterialSkin.Controls.MaterialForm 
    {
        private frmConfigurarModuloPsicologo formConfigurarModuloPsicologo;
        private frmPlantillaGestion formPlantillaGestion;

        private SemanaWS.SemanaWSClient daoSemana;
        private CursoWS.CursoWSClient daoCurso;
        private int idCurso;
        private int [] idsActividad;

        //Actividades:
        private BindingList<SemanaWS.actividad> actividadesSemana;
        private ActividadWS.ActividadWSClient daoActividad;

        //Semana:
        private SemanaWS.semana currentSemana;

        //Grupo Actual:
        private int idGrupo;

        //Curso Actual:
        CursoWS.curso currentCurso;

        public frmModificarPrograma(frmConfigurarModuloPsicologo formConfigurarModuloPsicologo, frmPlantillaGestion formPlantillaGestion, GrupoWS.grupo auxGrupo, SemanaWS.semana auxSemana, CursoWS.curso auxCurso, string nombreTema)
        {
            InitializeComponent();
            Design.Ini(this);
            idGrupo = auxGrupo.idGrupo;

            this.formConfigurarModuloPsicologo = formConfigurarModuloPsicologo;
            this.formPlantillaGestion = formPlantillaGestion;
            //this.idCurso = idCurso;

            //Semana Actual:
            this.currentSemana = auxSemana;

            //Curso Actual:
            this.currentCurso = auxCurso;

            daoSemana = new SemanaWS.SemanaWSClient();
            daoCurso = new CursoWS.CursoWSClient();
            daoActividad = new ActividadWS.ActividadWSClient();

            //this.semanas = new BindingList<CursoWS.semana>(
            //    daoCurso.listarSemanasPorIdCurso(idCurso).ToList());

            //Inicializar Pantalla
            rtxtDescripcion.Text = currentSemana.descripcion;
            rtxtTema.Text = currentSemana.nombre;
            lblTema.Text = "Curso: " + auxCurso.descripcion + "   >   " + "Semana: " + currentSemana.nombre + "   >   Duracion: " + currentSemana.fechaInicio.ToString("dd/MM/yyyy") + " - " + currentSemana.fechaInicio.AddDays(6).ToString("dd/MM/yyyy");

            //Limitar edicion:
            rtxtDescripcion.ReadOnly = true;
            rtxtTema.ReadOnly = true;
            //rtxtDescripcion.Enabled = false;
            //rtxtTema.Enabled = false;

            dgvReuniones.AutoGenerateColumns = false;

            //dgvReuniones.Sort(dgvReuniones.Columns[1], ListSortDirection.Ascending);
            inicializarPantalla();
        }


        private void inicializarPantalla()
        {
            try
            {
                actividadesSemana = new BindingList<SemanaWS.actividad>(daoSemana.listarActividadesPorIdSemana(currentSemana.id).OrderBy(x=>x.fecha).ToList());
            }
            catch (Exception ex)
            {
                actividadesSemana = new BindingList<SemanaWS.actividad>();
            }

            dgvReuniones.DataSource = actividadesSemana;
        }


        private void frmModificarPrograma_Load(object sender, EventArgs e)
        {

        }

        public void RefreshDataGridView()
        {
            dgvReuniones.Refresh();
            var aux = actividadesSemana.ToList();
            actividadesSemana = new BindingList<SemanaWS.actividad>(aux.OrderBy(x=>x.fecha).ToList());
            dgvReuniones.DataSource = actividadesSemana;
        }

        public void refreshDGVModificado()
        {
            actividadesSemana = new BindingList<SemanaWS.actividad>(daoSemana.listarActividadesPorIdSemana(currentSemana.id).OrderBy(x => x.fecha).ToList());
            dgvReuniones.DataSource = actividadesSemana;
            dgvReuniones.Refresh();
        }

        private void materialButton8_Click(object sender, EventArgs e) //Boton Asistencia
        {
            if (dgvReuniones.RowCount != 0)
            {
                SemanaWS.actividad auxActividad = dgvReuniones.CurrentRow.DataBoundItem as SemanaWS.actividad;

                formPlantillaGestion.abrirFormulario(new frmRegistrarAsistenciaCuidadores(this, formPlantillaGestion, auxActividad.idActividad, idGrupo, auxActividad, currentCurso.descripcion));
            }

        }

        private void materialButton7_Click(object sender, EventArgs e) //Modificar Actvidad
        {

            if (dgvReuniones.RowCount != 0)
            {
                SemanaWS.actividad auxActividad = dgvReuniones.CurrentRow.DataBoundItem as SemanaWS.actividad;
                frmModificarActividad formModificarActividad = new frmModificarActividad(this, formPlantillaGestion, auxActividad, currentSemana, currentCurso.descripcion);

                formPlantillaGestion.abrirFormulario(formModificarActividad);
            }
        }

        private void materialButton4_Click(object sender, EventArgs e)  //Insertar Actvidad
        {
            frmInsertarActividad formInsertarActividad = new frmInsertarActividad(this, formPlantillaGestion, currentSemana.id, actividadesSemana, idGrupo, currentSemana, currentCurso.descripcion);
            formPlantillaGestion.abrirFormulario(formInsertarActividad);
        }

        private void materialButton5_Click(object sender, EventArgs e) //Eliminar Actividad
        {
            if (dgvReuniones.RowCount != 0)
            {
                var resultado = MessageBox.Show("¿Desea borrar la actividad seleccionada?", "Mensaje de Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (resultado == DialogResult.Yes)
                {
                    SemanaWS.actividad auxActividad = dgvReuniones.CurrentRow.DataBoundItem as SemanaWS.actividad;
                    daoActividad.eliminarActividad(auxActividad.idActividad);
                    actividadesSemana.Remove(auxActividad);

                    dgvReuniones.Refresh();
                }
            }


        }

        private void materialButton6_Click(object sender, EventArgs e)
        {
            formPlantillaGestion.abrirFormulario(formConfigurarModuloPsicologo);
        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
            rtxtTema.ReadOnly = false;
            rtxtDescripcion.ReadOnly = false;
        }

        private void materialButton3_Click(object sender, EventArgs e)
        {
            if(rtxtTema.Text != "" && rtxtDescripcion.Text != "")
            {
                currentSemana.nombre = rtxtTema.Text;
                currentSemana.descripcion = rtxtDescripcion.Text;
                currentSemana.curso = new SemanaWS.curso();
                int resultado = daoSemana.modificarSemana(currentSemana);
                formConfigurarModuloPsicologo.refrescarDataGridView(currentSemana);

                lblTema.Text = "Curso: " + currentCurso.descripcion + "   >   " + "Semana: " + currentSemana.nombre + "   >   Duracion: " + currentSemana.fechaInicio.ToString("dd/MM/yyyy") + " - " + currentSemana.fechaInicio.AddDays(6).ToString("dd/MM/yyyy");
            }
            else
            {
                if(rtxtDescripcion.Text == "")
                {
                    MessageBox.Show("Debe introducir una descripcion para la semana.","Mensaje de Advertencia",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                }else if (rtxtTema.Text == "")
                {
                    MessageBox.Show("Debe introducir un nombre para la semana", "Mensaje de Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void ListReuniones_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dgvReuniones_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 4)
            {
                try
                {
                    System.Diagnostics.Process.Start(dgvReuniones.Rows[e.RowIndex].Cells["UnirseReunion"].Value.ToString());
                }
                catch (Exception ex)
                {
                }
            }
        }

        private void dgvReuniones_CellFormatting_1(object sender, DataGridViewCellFormattingEventArgs e)
        {
            try
            {
                SemanaWS.actividad actividad = dgvReuniones.Rows[e.RowIndex].DataBoundItem as SemanaWS.actividad;

                if (actividad != null)
                {
                    dgvReuniones.Rows[e.RowIndex].Cells["Nombre"].Value = actividad.nombre;
                    dgvReuniones.Rows[e.RowIndex].Cells["Fecha"].Value = actividad.fecha;
                    DateTime auxTime = Convert.ToDateTime(actividad.horaInicioStr);
                    dgvReuniones.Rows[e.RowIndex].Cells["HoraInicio"].Value = auxTime;
                    auxTime = Convert.ToDateTime(actividad.horaFinStr);
                    dgvReuniones.Rows[e.RowIndex].Cells["HoraFin"].Value = auxTime;
                    dgvReuniones.Rows[e.RowIndex].Cells["UnirseReunion"].Value = actividad.linkZoom;
                }

            }
            catch (Exception ex)
            {
            }
        }
    }
}
