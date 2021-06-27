using InterfazDATMA.ActividadWS;
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

namespace InterfazDATMA.psicologo
{
    public partial class frmInsertarActividad : MaterialSkin.Controls.MaterialForm
    {

        private frmModificarPrograma formModificarPrograma;
        private frmPlantillaGestion formPlantillaGestion;

        private ActividadWS.actividad actividad = null;
        private ActividadWS.ActividadWSClient daoActividad;

        //Semana:
        private int idSemana;
        private BindingList<SemanaWS.actividad> actividadesSemana;


        //Material
        private MaterialWS.MaterialWSClient daoMaterial;

        //Videos:
        BindingList<MaterialWS.video> videosActividad;

        //Documentos:
        BindingList<MaterialWS.documento> documentosActividad;

        public frmInsertarActividad(frmModificarPrograma formModificarPrograma, frmPlantillaGestion formPlantillaGestion, int idSemana, BindingList<SemanaWS.actividad> actividadesSemana)
        {
            InitializeComponent();

            this.formModificarPrograma = formModificarPrograma;
            this.formPlantillaGestion = formPlantillaGestion;

            this.idSemana = idSemana;

            dtpHInicio.CustomFormat = "hh:mm tt";
            dtpHInicio.Format = DateTimePickerFormat.Custom;
            dtpHInicio.ShowUpDown = true;

            dtpHFin.CustomFormat = "hh:mm tt";
            dtpHFin.Format = DateTimePickerFormat.Custom;
            dtpHFin.ShowUpDown = true;

            dtpFechaReunion.CustomFormat = "dd/MM/yyyy";
            dtpFechaReunion.Format = DateTimePickerFormat.Custom;

            daoActividad = new ActividadWS.ActividadWSClient();
            daoMaterial = new MaterialWS.MaterialWSClient();

            //Inicializar lista de documentos y videos:
            videosActividad = new BindingList<MaterialWS.video>();
            documentosActividad = new BindingList<MaterialWS.documento>();

            videosActividad.Clear();

            dgvVideos.DataSource = videosActividad;
            dgvDocumentos.DataSource = documentosActividad;

            this.actividadesSemana = actividadesSemana;
        }




        private void btnRegresar_Click(object sender, EventArgs e)
        {
            formModificarPrograma.RefreshDataGridView();
            formPlantillaGestion.abrirFormulario(formModificarPrograma);
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            //Inicializar la actividad:
            actividad = new ActividadWS.actividad();

            actividad.nombre = txtNombreAct.Text;
            actividad.fecha = dtpFechaReunion.Value;
            actividad.fechaSpecified = true;
            actividad.horaInicioStr = dtpHInicio.Value.ToString();
            actividad.horaFinStr = dtpHFin.Value.ToString();
            actividad.linkZoom = txtLinkZoom.Text;

         
            int resultado = daoActividad.insertarActividad(actividad, idSemana);
            
            if (resultado != 0)
            {
                MessageBox.Show("Se ha guardado con exito","Mensaje de Confimacion",MessageBoxButtons.OK,MessageBoxIcon.Information);

                txtNombreAct.Text = "";
                dtpFechaReunion.Value = DateTime.Now;
                dtpHInicio.Value = DateTime.Now;
                dtpHFin.Value = DateTime.Now;
                txtLinkZoom.Text = "";


                SemanaWS.actividad auxActividad = new SemanaWS.actividad();
                auxActividad.idSemana = resultado;
                auxActividad.nombre = actividad.nombre;
                auxActividad.fecha = actividad.fecha;
                auxActividad.horaInicioStr = actividad.horaInicioStr;
                auxActividad.horaFinStr = actividad.horaFinStr;
                auxActividad.linkZoom = actividad.linkZoom;

                actividadesSemana.Add(auxActividad);
            }
        }

        private void btnAgregarVid_Click(object sender, EventArgs e) //Agregar Video
        {
            frmAgregarMaterialPsicologo formAgregarVideo = new frmAgregarMaterialPsicologo();

            if(formAgregarVideo.ShowDialog() == DialogResult.OK && formAgregarVideo.Video != null)
            {
                videosActividad.Add(formAgregarVideo.Video);

                dgvVideos.Refresh();
            }

        }

        private void dgvVideos_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e) //DGV_Videos
        {
            try
            {
                MaterialWS.video auxVideo = dgvVideos.Rows[e.RowIndex].DataBoundItem as MaterialWS.video;
                if (auxVideo != null)
                {
                    dgvVideos.Rows[e.RowIndex].Cells["Descripcion"].Value = auxVideo.descripcion;
                    dgvVideos.Rows[e.RowIndex].Cells["Link"].Value = auxVideo.linkVideo;
                }
            }
            catch (Exception ex)
            {
            }

        }

        private void btnEliminarVid_Click(object sender, EventArgs e)
        {
            if(dgvVideos.RowCount != 0)
            {
                MaterialWS.video auxVideo = dgvVideos.CurrentRow.DataBoundItem as MaterialWS.video;
                videosActividad.Remove(auxVideo);

                

                dgvVideos.Refresh();
            }
        }

        private void dgvVideos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex == 1)
            {
                try
                {
                    System.Diagnostics.Process.Start(dgvVideos.Rows[e.RowIndex].Cells["Link"].Value.ToString());
                }
                catch (Exception ex)
                {
                }
            }
        }
    }
}
