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
using System.IO;
using MaterialSkin;

namespace InterfazDATMA.psicologo
{
    public partial class frmModificarActividad : MaterialSkin.Controls.MaterialForm
    {

        public MaterialSkinManager ThemeManager = MaterialSkinManager.Instance;
        private frmModificarPrograma formModificarPrograma;
        private frmPlantillaGestion formPlantillaGestion;

        //Actividad:
        private SemanaWS.actividad currentActividad; //Actividad de semana
        private ActividadWS.ActividadWSClient daoActividad;

        //Videos:
        private BindingList<ActividadWS.video> videosActividad;
        private BindingList<ActividadWS.video> videosEliminados;

        //Documentos:
        private BindingList<ActividadWS.documento> documentosActividad;
        private BindingList<ActividadWS.documento> documentosEliminados;

        //Material:
        private MaterialWS.MaterialWSClient daoMaterial;

        //Semana Actual:
        private SemanaWS.semana currentSemana;

        //Curso Actual:
        private string nombreCurso;

        public frmModificarActividad(frmModificarPrograma formModificarPrograma, frmPlantillaGestion formPlantillaGestion, SemanaWS.actividad auxActividad, SemanaWS.semana currentSemana, string nombreCurso)
        {
            InitializeComponent();
            Design.Ini(this);
            if (Design.tema == 'd') ThemeManager.Theme = MaterialSkinManager.Themes.DARK;
            else ThemeManager.Theme = MaterialSkinManager.Themes.LIGHT;

            dgvDocumentos.AutoGenerateColumns = false;
            dgvDocumentos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvVideos.AutoGenerateColumns = false;
            dgvVideos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            MaterialSkin.MaterialSkinManager skinManager = MaterialSkin.MaterialSkinManager.Instance;
            skinManager.AddFormToManage(this);
            skinManager.Theme = MaterialSkin.MaterialSkinManager.Themes.DARK;
            skinManager.ColorScheme = new MaterialSkin.ColorScheme(MaterialSkin.Primary.BlueGrey500, MaterialSkin.Primary.BlueGrey700, MaterialSkin.Primary.BlueGrey100, MaterialSkin.Accent.Teal700, MaterialSkin.TextShade.WHITE);

            this.formModificarPrograma = formModificarPrograma;
            this.formPlantillaGestion = formPlantillaGestion;

            lblCurso.WidgetText = "Curso: " + nombreCurso + "   >   " + "Semana: " + currentSemana.nombre + "   >   Duracion: " + currentSemana.fechaInicio.ToString("dd/MM/yyyy") + " - " + currentSemana.fechaInicio.AddDays(6).ToString("dd/MM/yyyy") + "\nEditar Actividad:";

            videosEliminados = new BindingList<ActividadWS.video>();
            documentosEliminados = new BindingList<ActividadWS.documento>();

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

            //Actividad:
            currentActividad = auxActividad;

            //Semana:
            this.currentSemana = currentSemana;

            //Curso:
            this.nombreCurso = nombreCurso;

            //
            //dtpFechaReunion.MinDate = DateTime.Now;

            inicializarPantalla();

        }

        private void inicializarPantalla()
        {
            txtNombreAct.Text = currentActividad.nombre;
            txtLinkZoom.Text = currentActividad.linkZoom;
            dtpFechaReunion.Value = currentActividad.fecha;
            DateTime auxTime = Convert.ToDateTime(currentActividad.horaInicioStr);
            dtpHInicio.Value = auxTime;
            auxTime = Convert.ToDateTime(currentActividad.horaFinStr);
            dtpHFin.Value = auxTime;




            var auxVideos = daoActividad.listarVideosPorIdActividad(currentActividad.idActividad);
            if (auxVideos != null)
            {
                videosActividad = new BindingList<ActividadWS.video>(auxVideos.ToList());
            }
            else
            {
                videosActividad = new BindingList<ActividadWS.video>();
            }
            dgvVideos.DataSource = videosActividad;

            var auxDocumentos = daoActividad.listarDocumentosPorIdActividad(currentActividad.idActividad);
            if (auxDocumentos != null)
            {
                documentosActividad = new BindingList<ActividadWS.documento>(auxDocumentos.ToList());
            }
            else
            {
                documentosActividad = new BindingList<ActividadWS.documento>();
            }
            dgvDocumentos.DataSource = documentosActividad;

        }
        private void frmModificarActividad_Load(object sender, EventArgs e)
        {

        }
        

        private void materialButton1_Click(object sender, EventArgs e) //GUARDAR
        {
            DateTime auxFechaReu = dtpFechaReunion.Value;

            if (txtNombreAct.Text.Trim() != "" && txtLinkZoom.Text.Trim() != "" && dtpHInicio.Value.TimeOfDay < dtpHFin.Value.TimeOfDay && currentSemana.fechaInicio.Date <= auxFechaReu.Date && auxFechaReu.Date < currentSemana.fechaInicio.AddDays(7))
            {
                ActividadWS.actividad actividad = new ActividadWS.actividad();

                actividad.idActividad = currentActividad.idActividad;
                actividad.nombre = txtNombreAct.Text;
                actividad.fecha = dtpFechaReunion.Value;
                actividad.fechaSpecified = true;
                actividad.horaInicioStr = dtpHInicio.Value.ToString();
                actividad.horaFinStr = dtpHFin.Value.ToString();
                actividad.linkZoom = txtLinkZoom.Text;

                int resultado = daoActividad.modificarActividad(actividad);

                if (resultado == 1)
                {
                    
                    //Eliminar material
                    foreach (ActividadWS.video recVideos in videosEliminados)
                    {
                        daoMaterial.eliminarMaterial(recVideos.idMaterial);
                    }
                    foreach (ActividadWS.documento recDocumentos in documentosEliminados)
                    {
                        daoMaterial.eliminarMaterial(recDocumentos.idMaterial);
                    }


                    //Agregar nuevo material
                    foreach (ActividadWS.video recVideos in videosActividad)
                    {
                        if (recVideos.idMaterial == -1)
                        {

                            MaterialWS.video auxVideo = new MaterialWS.video();
                            auxVideo.actividad = new MaterialWS.actividad();
                            auxVideo.actividad.idActividad = actividad.idActividad;
                            auxVideo.descripcion = recVideos.descripcion;
                            auxVideo.linkVideo = recVideos.linkVideo;
                            auxVideo.nombre = recVideos.nombre;
                            auxVideo.tipoMaterial = recVideos.tipoMaterial;
                            auxVideo.duracion = "";

                            daoMaterial.insertarMaterialVideo(auxVideo);
                        }
                    }

                    foreach (ActividadWS.documento recDocumento in documentosActividad)
                    {
                        if (recDocumento.idMaterial == -1)
                        {
                            MaterialWS.documento auxDocumento = new MaterialWS.documento();
                            auxDocumento.actividad = new MaterialWS.actividad();
                            auxDocumento.actividad.idActividad = actividad.idActividad;
                            auxDocumento.descripcion = recDocumento.descripcion;
                            auxDocumento.docPDF = recDocumento.docPDF;
                            auxDocumento.nombre = recDocumento.nombre;
                            auxDocumento.tipoMaterial = recDocumento.tipoMaterial;

                            daoMaterial.insertarMaterialDocumento(auxDocumento);
                        }
                    }

                    MessageBox.Show("Se ha modificado con exito", "Mensaje de Confimacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                if (txtNombreAct.Text.Trim() == "")
                {
                    MessageBox.Show("Debe colocarle un nombre a la actividad", "Mensaje de Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (txtLinkZoom.Text.Trim() == "")
                {
                    MessageBox.Show("Debe colocar el link de zoom para la reunion", "Mensaje de Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }else if (!(currentSemana.fechaInicio.Date <= auxFechaReu.Date && auxFechaReu.Date <
                currentSemana.fechaInicio.AddDays(7)))
                {
                    MessageBox.Show("Debe introducir una fecha dentro del rango permitido: \nFecha Inicio: " + currentSemana.fechaInicio.Date.ToString("dd/MM/yyyy") + " - Fecha Fin: " + currentSemana.fechaInicio.AddDays(6).ToString("dd/MM/yyyy"), "Mensaje de Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (dtpHInicio.Value.TimeOfDay >= dtpHFin.Value.TimeOfDay)
                {
                    MessageBox.Show("La Hora de Inicio de la actividad no puede ser mayor a la Hora de Fin.", "Mensaje de Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }

        }

        //REGRESAR
        private void materialButton4_Click(object sender, EventArgs e)
        {
            formModificarPrograma.refreshDGVModificado();
            formPlantillaGestion.abrirFormulario(formModificarPrograma);
        }

        private void materialButton2_Click(object sender, EventArgs e) //Agregar Documento
        {
            frmInsertarDocumento formInsertarDocumento = new frmInsertarDocumento();
            if (formInsertarDocumento.ShowDialog() == DialogResult.OK && formInsertarDocumento.Documento != null)
            {
                ActividadWS.documento auxDoc = new ActividadWS.documento();
                auxDoc.idMaterial = -1;
                auxDoc.descripcion = formInsertarDocumento.Documento.descripcion;
                auxDoc.docPDF = formInsertarDocumento.Documento.docPDF;
                auxDoc.nombre = "";
                auxDoc.tipoMaterial = 0;

                documentosActividad.Add(auxDoc);
                dgvDocumentos.Refresh();
            }
        }

        private void materialButton5_Click(object sender, EventArgs e) //Eliminar Documento
        {
            if (dgvDocumentos.RowCount != 0)
            {
                var rpt = MessageBox.Show("¿Esta seguro que desea eliminar el material seleccionado?", "Mensaje de Confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if(rpt == DialogResult.Yes)
                {
                    ActividadWS.documento auxDocumento = dgvDocumentos.CurrentRow.DataBoundItem as ActividadWS.documento;
                    //MessageBox.Show(auxDocumento.idMaterial.ToString());
                    if (auxDocumento.idMaterial != -1)
                    {
                        documentosEliminados.Add(auxDocumento);
                    }
                    documentosActividad.Remove(auxDocumento);

                    dgvDocumentos.Refresh();
                }
            }
        }

        private void materialButton6_Click(object sender, EventArgs e) //Eliminar Video
        {

            if (dgvVideos.RowCount != 0)
            {

                var rpt = MessageBox.Show("¿Esta seguro que desea eliminar el material seleccionado?", "Mensaje de Confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if(rpt == DialogResult.Yes)
                {
                    ActividadWS.video auxVideo = dgvVideos.CurrentRow.DataBoundItem as ActividadWS.video;

                    if (auxVideo.idMaterial != -1)
                    {
                        videosEliminados.Add(auxVideo);
                    }
                    videosActividad.Remove(auxVideo);

                    dgvVideos.Refresh();

                }
            }
        }

        private void materialButton3_Click(object sender, EventArgs e) //Agregar Video
        {
            frmAgregarMaterialPsicologo formAgregarVideo = new frmAgregarMaterialPsicologo();

            if (formAgregarVideo.ShowDialog() == DialogResult.OK && formAgregarVideo.Video != null)
            {
                ActividadWS.video auxVideo = new ActividadWS.video();
                auxVideo.idMaterial = -1;
                auxVideo.descripcion = formAgregarVideo.Video.descripcion;
                auxVideo.linkVideo = formAgregarVideo.Video.linkVideo;
                auxVideo.nombre = "";
                auxVideo.tipoMaterial = 1;
                auxVideo.duracion = "";

                videosActividad.Add(auxVideo);

                dgvVideos.Refresh();
            }
        }
             
        private void dgvDocumentos_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 1)
            {
                try
                {
                    ActividadWS.documento auxMaterial = dgvDocumentos.Rows[e.RowIndex].DataBoundItem as ActividadWS.documento;

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

        private void dgvDocumentos_CellFormatting_1(object sender, DataGridViewCellFormattingEventArgs e)
        {
            try
            {
                ActividadWS.documento auxDocumento = dgvDocumentos.Rows[e.RowIndex].DataBoundItem as ActividadWS.documento;
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

        private void dgvVideos_CellFormatting_1(object sender, DataGridViewCellFormattingEventArgs e)
        {
            try
            {
                ActividadWS.video auxVideo = dgvVideos.Rows[e.RowIndex].DataBoundItem as ActividadWS.video;
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

        private void dgvVideos_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
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

        private void tableLayoutPanel17_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
