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
using MaterialSkin;

namespace InterfazDATMA
{
    public partial class frmRegistrarAsistenciaCuidadores : MaterialSkin.Controls.MaterialForm 
    {

        public MaterialSkinManager ThemeManager = MaterialSkinManager.Instance;
        private frmModificarPrograma formModificarPrograma;
        private frmPlantillaGestion formPlantillaGestion;
        //Actividad:
        private int idActividad;
        private ActividadWS.ActividadWSClient daoActividad;

        //Grupo:
        private int idGrupo;
        private GrupoWS.GrupoWSClient daoGrupo;

        //Asistencia:
        private AsistenciaWS.AsistenciaWSClient daoAsistencia;
        BindingList<ActividadWS.asistencia> asistencias;

        public frmRegistrarAsistenciaCuidadores(frmModificarPrograma formModificarPrograma, frmPlantillaGestion formPlantillaGestion, int idActividad, int idGrupo, SemanaWS.actividad actividad, string nombreCurso)
        {
            InitializeComponent();
            this.idActividad = idActividad;
            this.idGrupo = idGrupo;

            dgvAsitencia.AutoGenerateColumns = false;

            lblInformacion.Text = "Curso: " + nombreCurso + "   >   Actividad: " + actividad.nombre + "   >   Fecha Act: " + actividad.fecha.ToString("dd/MM/yy");

            Design.Ini(this);
            if (Design.tema == 'd') ThemeManager.Theme = MaterialSkinManager.Themes.DARK;
            else ThemeManager.Theme = MaterialSkinManager.Themes.LIGHT;
            this.formModificarPrograma = formModificarPrograma;
            this.formPlantillaGestion = formPlantillaGestion;

            daoGrupo = new GrupoWS.GrupoWSClient();
            daoAsistencia = new AsistenciaWS.AsistenciaWSClient();
            daoActividad = new ActividadWS.ActividadWSClient();

            inicializarPantalla();
        }
        private void inicializarPantalla()
        {
            //var auxTutores = daoGrupo.listarTutoresPorIdGrupo(idGrupo);
            //BindingList<GrupoWS.tutor> tutores;

            //if (auxTutores != null)
            //{
            //    tutores = new BindingList<GrupoWS.tutor>(auxTutores.ToList());
            //}
            //else
            //{
            //    tutores = new BindingList<GrupoWS.tutor>();
            //}

            var auxAsistencias = daoActividad.listarAsistenciasPorIdActividadYGrupo(idActividad, idGrupo);

            if (auxAsistencias != null)
            {
                asistencias = new BindingList<ActividadWS.asistencia>(auxAsistencias.OrderBy(x => x.descripcion).ToList());
            }
            else
            {
                asistencias = new BindingList<ActividadWS.asistencia>();
            }

            //Buscar nombre de tutores
            //foreach (ActividadWS.asistencia recAsistencia in asistencias)
            //{
            //    GrupoWS.tutor auxTutor = null;
            //    foreach (GrupoWS.tutor recTutor in tutores)
            //    {
            //        if (recAsistencia.usuario.idPersona == recTutor.idPersona)
            //        {
            //            auxTutor = recTutor;
            //            recAsistencia.usuario.nombre = recTutor.nombre + " " + recTutor.apellidoPaterno + " " + recTutor.apellidoMaterno;
            //            break;
            //        }
            //    }
            //    if (auxTutor != null) tutores.Remove(auxTutor);
            //}

            dgvAsitencia.DataSource = asistencias;

        }
        private void frmRegistrarAsistenciaCuidadores_Load(object sender, EventArgs e)
        {
            
        }

        private void Regresar_Click(object sender, EventArgs e)
        {
            formPlantillaGestion.abrirFormulario(formModificarPrograma);
        }

        private void materialButton1_Click(object sender, EventArgs e) //Limpiar todo
        {
            foreach (ActividadWS.asistencia recAsistencia in asistencias)
            {
                recAsistencia.tipo = 0;
            }

            dgvAsitencia.DataSource = asistencias;
            dgvAsitencia.Refresh();

        }

        private void materialButton2btnGuardarAsistencia_Click(object sender, EventArgs e) //Guardar ASISTENCIA
        {
            foreach (ActividadWS.asistencia recAsistencia in asistencias)
            {
                AsistenciaWS.asistencia auxAsistencia = new AsistenciaWS.asistencia();
                auxAsistencia.id = recAsistencia.id;
                auxAsistencia.usuario = new AsistenciaWS.usuario();
                auxAsistencia.usuario.idUsuario = recAsistencia.usuario.idUsuario;
                auxAsistencia.actividad = new AsistenciaWS.actividad();
                auxAsistencia.actividad.idActividad = idActividad;
                auxAsistencia.tipo = recAsistencia.tipo;
                if (auxAsistencia.tipo == 1)
                {
                    auxAsistencia.descripcion = "Asistio";
                }
                else
                {
                    auxAsistencia.descripcion = "No  asistio";
                }
                daoAsistencia.modificarAsistencia(auxAsistencia);
            }

            MessageBox.Show("Se ha guardado con exito", "Mensaje de Confirmacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        
        private void dgvAsitencia_CellFormatting_1(object sender, DataGridViewCellFormattingEventArgs e)
        {
            ActividadWS.asistencia auxAsistencia = dgvAsitencia.Rows[e.RowIndex].DataBoundItem as ActividadWS.asistencia;

            if (auxAsistencia != null)
            {
                dgvAsitencia.Rows[e.RowIndex].Cells["NombreCompleto"].Value = auxAsistencia.descripcion;
                if (auxAsistencia.tipo == 0) //No asistio
                {
                    dgvAsitencia.Rows[e.RowIndex].Cells["Asistencia"].Value = false;
                }
                else // Asistio
                {
                    dgvAsitencia.Rows[e.RowIndex].Cells["Asistencia"].Value = true;
                }
            }
        }

        private void dgvAsitencia_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 1)
            {
                ActividadWS.asistencia auxAsistencia = dgvAsitencia.Rows[e.RowIndex].DataBoundItem as ActividadWS.asistencia;

                //MessageBox.Show("1");
                if ((bool)dgvAsitencia.Rows[e.RowIndex].Cells[1].Value == true)
                {
                    //MessageBox.Show("2");
                    dgvAsitencia.Rows[e.RowIndex].Cells[1].Value = false;
                    auxAsistencia.tipo = 0;
                }
                else
                {
                    //MessageBox.Show("3");
                    dgvAsitencia.Rows[e.RowIndex].Cells[1].Value = true;
                    auxAsistencia.tipo = 1;
                }
            }
        }
    }
}
