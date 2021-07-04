using InterfazDATMA.ActividadWS;
using InterfazDATMA.plantilla;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using InterfazDATMA.util;
using MaterialSkin;

namespace InterfazDATMA.psicologo
{
    public partial class frmInsertarActividad : MaterialSkin.Controls.MaterialForm
    {

        public MaterialSkinManager ThemeManager = MaterialSkinManager.Instance;
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
        
        //Grupo Actual:
        private int idGrupo;
        private GrupoWS.GrupoWSClient daoGrupo;

        //Asistencia:
        private AsistenciaWS.AsistenciaWSClient daoAsistencia;

        //Semana Actual:
        private SemanaWS.semana currentSemana;

        //Curso Actual:
        private string nombreCurso;

        public frmInsertarActividad(frmModificarPrograma formModificarPrograma, frmPlantillaGestion formPlantillaGestion, int idSemana, BindingList<SemanaWS.actividad> actividadesSemana, int idGrupo, SemanaWS.semana currentSemana, string nombreCurso)
        {
            InitializeComponent();
            
            dgvDocumentos.AutoGenerateColumns = false;
            dgvVideos.AutoGenerateColumns = false;
            this.idGrupo = idGrupo;

            lblCurso.Text = "Curso: " + nombreCurso + "   >   " + "Semana: " + currentSemana.nombre + "   >   Duracion: " + currentSemana.fechaInicio.ToString("dd/MM/yyyy") + " - " + currentSemana.fechaInicio.AddDays(6).ToString("dd/MM/yyyy") + "\n\nNueva Actividad:";


            Design.Ini(this);
            if (Design.tema == 'd') ThemeManager.Theme = MaterialSkinManager.Themes.DARK;
            else ThemeManager.Theme = MaterialSkinManager.Themes.LIGHT;
            this.formModificarPrograma = formModificarPrograma;
            this.formPlantillaGestion = formPlantillaGestion;

            //Curso:
            this.nombreCurso = nombreCurso;

            //Semana:
            this.idSemana = idSemana;
            this.currentSemana = currentSemana;

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
            daoGrupo = new GrupoWS.GrupoWSClient();
            daoAsistencia = new AsistenciaWS.AsistenciaWSClient();

            //Inicializar lista de documentos y videos:
            videosActividad = new BindingList<MaterialWS.video>();
            documentosActividad = new BindingList<MaterialWS.documento>();

            videosActividad.Clear();

            dgvVideos.DataSource = videosActividad;
            dgvDocumentos.DataSource = documentosActividad;

            this.actividadesSemana = actividadesSemana;
            //
            //dtpFechaReunion.MinDate = DateTime.Now;
        }



        private void btnGuardar_Click(object sender, EventArgs e)
        {
            DateTime auxFechaReu = dtpFechaReunion.Value;

            if(txtNombreAct.Text != ""  && txtLinkZoom.Text != "" && dtpHInicio.Value.TimeOfDay < dtpHFin.Value.TimeOfDay && currentSemana.fechaInicio.Date <= auxFechaReu.Date && auxFechaReu.Date < currentSemana.fechaInicio.AddDays(7))
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
                    txtNombreAct.Text = "";
                    dtpFechaReunion.Value = DateTime.Now;
                    dtpHInicio.Value = DateTime.Now;
                    dtpHFin.Value = DateTime.Now;
                    txtLinkZoom.Text = "";


                    SemanaWS.actividad auxActividad = new SemanaWS.actividad();
                    auxActividad.idActividad = resultado;
                    auxActividad.nombre = actividad.nombre;
                    auxActividad.fecha = actividad.fecha;
                    auxActividad.horaInicioStr = actividad.horaInicioStr;
                    auxActividad.horaFinStr = actividad.horaFinStr;
                    auxActividad.linkZoom = actividad.linkZoom;

                    actividadesSemana.Add(auxActividad);

                    foreach (MaterialWS.video recVideos in videosActividad)
                    {
                        recVideos.actividad = new MaterialWS.actividad();
                        recVideos.tipoMaterial = 1; //TIPO MATERIAL -> 1
                        recVideos.duracion = ""; //Duracion por defecto
                        recVideos.actividad.idActividad = resultado;
                        int aux = daoMaterial.insertarMaterialVideo(recVideos);
                    }

                    foreach (MaterialWS.documento recDocumentos in documentosActividad)
                    {
                        recDocumentos.actividad = new MaterialWS.actividad();
                        recDocumentos.tipoMaterial = 0; //TIPO MATERIAL -> 0
                        recDocumentos.actividad.idActividad = resultado;
                        daoMaterial.insertarMaterialDocumento(recDocumentos);
                    }

                    //Insertar tutores - asistencia:
                    var auxTutores = daoGrupo.listarTutoresPorIdGrupo(idGrupo);
                    BindingList<GrupoWS.tutor> tutores;

                    if (auxTutores != null)
                    {
                        tutores = new BindingList<GrupoWS.tutor>(auxTutores.ToList());
                    }
                    else
                    {
                        tutores = new BindingList<GrupoWS.tutor>();
                    }

                    foreach (GrupoWS.tutor recTutores in tutores)
                    {
                        AsistenciaWS.asistencia asist = new AsistenciaWS.asistencia();
                        asist.actividad = new AsistenciaWS.actividad();
                        asist.actividad.idActividad = resultado;
                        asist.usuario = new AsistenciaWS.usuario();
                        asist.usuario.idUsuario = recTutores.idUsuario;
                        asist.descripcion = "Nueva asistencia";
                        asist.tipo = 0; //0 -> no asistio y 1 -> asistio
                        int aux = daoAsistencia.insertarAsistencia(asist);
                    }

                    MessageBox.Show("Se ha guardado con exito", "Mensaje de Confimacion", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    videosActividad.Clear();
                    documentosActividad.Clear();

                    dgvDocumentos.Refresh();
                    dgvVideos.Refresh();
                }
            }
            else
            {
                if(txtNombreAct.Text == "")
                {
                    MessageBox.Show("Debe colocarle un nombre a la actividad", "Mensaje de Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if(txtLinkZoom.Text == "")
                {
                    MessageBox.Show("Debe colocar el link de zoom para la reunion", "Mensaje de Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (!(currentSemana.fechaInicio.Date <= auxFechaReu.Date && auxFechaReu.Date <
                currentSemana.fechaInicio.AddDays(7)))
                {
                    MessageBox.Show("Debe introducir una fecha dentro del rango permitido: \nFecha Inicio: "+currentSemana.fechaInicio.Date.ToString("dd/MM/yyyy") + " - Fecha Fin: "+currentSemana.fechaInicio.AddDays(6).ToString("dd/MM/yyyy"), "Mensaje de Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (dtpHInicio.Value.TimeOfDay >= dtpHFin.Value.TimeOfDay)
                {
                    MessageBox.Show("La Hora de Inicio de la actividad no puede ser mayor a la Hora de Fin.", "Mensaje de Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }

        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            formModificarPrograma.RefreshDataGridView();
            formPlantillaGestion.abrirFormulario(formModificarPrograma);
        }


        private void btnAgregarDoc_Click(object sender, EventArgs e)
        {
            frmInsertarDocumento formInsertarDocumento = new frmInsertarDocumento();
            if (formInsertarDocumento.ShowDialog() == DialogResult.OK && formInsertarDocumento.Documento != null)
            {
                documentosActividad.Add(formInsertarDocumento.Documento);
                dgvDocumentos.Refresh();
            }

        }

        private void btnEliminarDoc_Click(object sender, EventArgs e)
        {

            if (dgvDocumentos.RowCount != 0)
            {
                var rpt = MessageBox.Show("¿Esta seguro que desea eliminar el material seleccionado?","Mensaje de Confirmacion",MessageBoxButtons.YesNo,MessageBoxIcon.Warning);

                if(rpt == DialogResult.Yes)
                {
                    MaterialWS.documento auxDocumento = dgvVideos.CurrentRow.DataBoundItem as MaterialWS.documento;
                    documentosActividad.Remove(auxDocumento);
                    dgvDocumentos.Refresh();
                }
            }
        }

        private void btnAgregarVid_Click(object sender, EventArgs e)
        {

            frmAgregarMaterialPsicologo formAgregarVideo = new frmAgregarMaterialPsicologo();

            if (formAgregarVideo.ShowDialog() == DialogResult.OK && formAgregarVideo.Video != null)
            {
                videosActividad.Add(formAgregarVideo.Video);

                dgvVideos.Refresh();
            }

        }

        private void btnEliminarVid_Click(object sender, EventArgs e)
        {
            if (dgvVideos.RowCount != 0)
            {
                var rpt = MessageBox.Show("¿Esta seguro que desea eliminar el material seleccionado?", "Mensaje de Confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if(rpt == DialogResult.Yes)
                {
                    MaterialWS.video auxVideo = dgvVideos.CurrentRow.DataBoundItem as MaterialWS.video;
                    videosActividad.Remove(auxVideo);
                    dgvVideos.Refresh();
                }
            }
        }

        private void dgvVideos_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
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

        private void dgvVideos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 1)
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


        private void dgvDocumentos_CellFormatting_1(object sender, DataGridViewCellFormattingEventArgs e)
        {
            try
            {
                MaterialWS.documento auxDocumento = dgvDocumentos.Rows[e.RowIndex].DataBoundItem as MaterialWS.documento;
                if (auxDocumento != null)
                {
                    dgvDocumentos.Rows[e.RowIndex].Cells["DescripcionDoc"].Value = auxDocumento.descripcion;
                    dgvDocumentos.Rows[e.RowIndex].Cells["Documento"].Value = "Descargar";
                }
            }
            catch (Exception ex)
            {
            }
        }

        private void dgvDocumentos_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 1)
            {
                try
                {
                    MaterialWS.documento auxMaterial = dgvDocumentos.Rows[e.RowIndex].DataBoundItem as MaterialWS.documento;

                    sfdPDF.Title = "Guardar PDF";
                    sfdPDF.Filter = "Archivo PDF|*.pdf";
                    if (sfdPDF.ShowDialog() == DialogResult.OK)
                    {
                        string ruta = sfdPDF.FileName;
                        File.WriteAllBytes(ruta, auxMaterial.docPDF);
                        MessageBox.Show("Se ha guardo el archivo exitosamente", "Mensaje de Confirmacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al guardar el archivo", "Mensaje de Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
    }
}
