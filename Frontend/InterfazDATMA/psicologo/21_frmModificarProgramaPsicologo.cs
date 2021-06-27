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

        //Actividades:
        private BindingList<SemanaWS.actividad> actividadesSemana;
        private ActividadWS.ActividadWSClient daoActividad;

        //Semana:
        private SemanaWS.semana currentSemana;
  
        public frmModificarPrograma(frmConfigurarModuloPsicologo formConfigurarModuloPsicologo, frmPlantillaGestion formPlantillaGestion, GrupoWS.grupo auxGrupo, SemanaWS.semana auxSemana, CursoWS.curso auxCurso, string nombreTema)
        {
            InitializeComponent();
            Design.Ini(this);
        
            this.formConfigurarModuloPsicologo = formConfigurarModuloPsicologo;
            this.formPlantillaGestion = formPlantillaGestion;
            //this.idCurso = idCurso;

            currentSemana = auxSemana;

            daoSemana = new SemanaWS.SemanaWSClient();
            daoCurso = new CursoWS.CursoWSClient();
            daoActividad = new ActividadWS.ActividadWSClient();

            //this.semanas = new BindingList<CursoWS.semana>(
            //    daoCurso.listarSemanasPorIdCurso(idCurso).ToList());

            //Inicializar Pantalla
            rtxtDescripcion.Text = currentSemana.descripcion;
            rtxtTema.Text = currentSemana.nombre;
            lblTema.Text = "Tema: " + nombreTema;

            //Limitar edicion:
            rtxtDescripcion.ReadOnly = true;
            //rtxtDescripcion.Enabled = false;
            //rtxtTema.Enabled = false;

            dgvReuniones.AutoGenerateColumns = false;
            inicializarPantalla();
        }



        private void inicializarPantalla()
        {
            actividadesSemana = new BindingList<SemanaWS.actividad>(daoSemana.listarActividadesPorIdSemana(currentSemana.id).ToList());
            dgvReuniones.DataSource = actividadesSemana;
        }


        private void dgvReuniones_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex == 3)
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

        private void btnEditarDescrip_Click(object sender, EventArgs e)
        {
            rtxtDescripcion.ReadOnly = false;

        }

        private void frmModificarPrograma_Load(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            currentSemana.nombre = rtxtTema.Text;
            currentSemana.descripcion = rtxtDescripcion.Text;
            currentSemana.curso = new SemanaWS.curso();
            int resultado = daoSemana.modificarSemana(currentSemana);
            formConfigurarModuloPsicologo.refrescarDataGridView(currentSemana);

            //INSERTAR ACTIVIDADES: actividadesSemana
        }

        private void btnAsitencia_Click(object sender, EventArgs e)
        {
            formPlantillaGestion.abrirFormulario(new frmRegistrarAsistenciaCuidadores(this, formPlantillaGestion));


        }

        private void btnAgregarReunion_Click(object sender, EventArgs e) //INSERTAR ACTIVIDAD
        {
            frmInsertarActividad formInsertarActividad = new frmInsertarActividad(this, formPlantillaGestion, currentSemana.id, actividadesSemana);
            formPlantillaGestion.abrirFormulario(formInsertarActividad);
        }

        private void btnEliminarReunion_Click(object sender, EventArgs e) //Eliminar Actividad
        {
            if(dgvReuniones.RowCount != 0)
            {
                var resultado = MessageBox.Show("¿Desea borrar la actividad seleccionada?","Mensaje de Advertencia",MessageBoxButtons.YesNo,MessageBoxIcon.Warning);

                if(resultado == DialogResult.Yes)
                {
                    SemanaWS.actividad auxActividad = dgvReuniones.CurrentRow.DataBoundItem as SemanaWS.actividad;
                    daoActividad.eliminarActividad(auxActividad.idActividad);
                    actividadesSemana.Remove(auxActividad);
                    
                    dgvReuniones.Refresh();
                }
            }

        }

        private void bntConfigurarTiempo_Click(object sender, EventArgs e)
        {
            frmModificarActividad formModificarActividad = new frmModificarActividad(this, formPlantillaGestion);
            formPlantillaGestion.abrirFormulario(formModificarActividad);
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            formPlantillaGestion.abrirFormulario(formConfigurarModuloPsicologo);
        }

        private void dgvReuniones_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            try
            {
                SemanaWS.actividad actividad = dgvReuniones.Rows[e.RowIndex].DataBoundItem as SemanaWS.actividad;

                if(actividad != null)
                {
                    dgvReuniones.Rows[e.RowIndex].Cells["Fecha"].Value = actividad.fecha;
                    DateTime auxTime = Convert.ToDateTime(actividad.horaInicioStr);
                    dgvReuniones.Rows[e.RowIndex].Cells["HoraInicio"].Value = auxTime;
                    auxTime = Convert.ToDateTime(actividad.horaFinStr);
                    dgvReuniones.Rows[e.RowIndex].Cells["HoraFin"].Value = auxTime;
                    dgvReuniones.Rows[e.RowIndex].Cells["UnirseReunion"].Value = actividad.linkZoom;
                }

            }catch(Exception ex)
            {
            }

        }

        public void RefreshDataGridView()
        {
            dgvReuniones.Refresh();
        }

    }
}
