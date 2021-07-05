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
    public partial class frmInformacionCurso : MaterialSkin.Controls.MaterialForm 
    {
        public frmCursosDisponibles formAnterior;
        private frmPlantillaGestion plantillaGestion;

        public MaterialSkinManager ThemeManager = MaterialSkinManager.Instance;
        private CursoWS.CursoWSClient daoCurso = new CursoWS.CursoWSClient();
        private ActividadWS.ActividadWSClient daoAct = new ActividadWS.ActividadWSClient();
        private List<ActividadWS.actividad> actividades = new List<ActividadWS.actividad>();
        private List<PsicologoInfo> psicologos = new List<PsicologoInfo>();

        private CursoTutor cursoTutor;
        private DateTime daterunner;
        public frmInformacionCurso(frmCursosDisponibles formAnterior, frmPlantillaGestion plantillaGestion, CursoTutor cursoTutor)
        {
            InitializeComponent();
            Design.Ini(this);
            if (Design.tema == 'd') ThemeManager.Theme = MaterialSkinManager.Themes.DARK;
            else ThemeManager.Theme = MaterialSkinManager.Themes.LIGHT;
            dgvInfCurso.AutoGenerateColumns = false;
            dgvPsicologos.AutoGenerateColumns = false;

            this.formAnterior = formAnterior;
            this.plantillaGestion = plantillaGestion;
            this.cursoTutor = cursoTutor;
            daterunner = cursoTutor.FechaInicio;

            // obtener actividades
            var semanas = daoCurso.listarSemanasPorIdCurso(cursoTutor.Curso.idCurso);
            if (semanas is object)
            {
                foreach (var semana in semanas)
                {
                    var newact = daoAct.listarActividadesIdSemana(semana.id);
                    if (newact is object)
                    {
                        actividades.AddRange(newact);
                    }
                }
            }

            // crear lista de psicologos
            foreach (var psico in cursoTutor.Psicologo)
            {
                psicologos.Add(new PsicologoInfo(psico));
            }

            LlenarInformacion();
        }

        public void LlenarInformacion()
        {
            lblNombreModulo.Text = cursoTutor.Modulo;
            dgvPsicologos.DataSource = psicologos;
            dgvInfCurso.DataSource = actividades;
            nDateTimeBoxControl2.SelectedDate = cursoTutor.FechaInicio;
            nDateTimeBoxControl1.SelectedDate = cursoTutor.FechaFin;
            if (cursoTutor.Psicologo[0].fotoPerfil is object)
            {
                pictBoxEncargada.Image = (Bitmap)((new ImageConverter()).ConvertFrom(cursoTutor.Psicologo[0].fotoPerfil));
            }
            // estilos
            dgvPsicologos.DefaultCellStyle = dgvInfCurso.DefaultCellStyle;
            dgvPsicologos.ColumnHeadersDefaultCellStyle = dgvInfCurso.ColumnHeadersDefaultCellStyle;
            dgvPsicologos.RowHeadersDefaultCellStyle = dgvInfCurso.RowHeadersDefaultCellStyle;
            dgvPsicologos.RowsDefaultCellStyle = dgvInfCurso.RowsDefaultCellStyle;
        }

        private void ActualizarFechaStr()
        {
            materialLabel4.Text = daterunner.ToString("MMMM").ToUpper() + " " + daterunner.ToString("yyyy");
        }

        private void ActualizarActividades()
        {
            var temp = new List<ActividadWS.actividad>(actividades);
            temp.RemoveAll(item => item.fecha.Month != daterunner.Month);
            dgvInfCurso.DataSource = temp;
        }

        private void btnVerMas_Click(object sender, EventArgs e)
        {
            plantillaGestion.abrirFormulario(new frmDetalleCurso(this, plantillaGestion));
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            if (daterunner.Month - cursoTutor.FechaInicio.Month > 0)
            {
                daterunner = daterunner.AddMonths(-1);
                ActualizarFechaStr();
                ActualizarActividades();
            }
        }

        private void btnSig_Click(object sender, EventArgs e)
        {
            if (cursoTutor.FechaFin.Month - daterunner.Month > 0)
            {
                daterunner = daterunner.AddMonths(1);
                ActualizarFechaStr();
                ActualizarActividades();
            }
        }

        private void dgvPsicologos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            var psico = cursoTutor.Psicologo[index];
            if (psico.fotoPerfil is object)
            {
                pictBoxEncargada.Image = (Bitmap)((new ImageConverter()).ConvertFrom(psico.fotoPerfil));
            }
        }

        public class PsicologoInfo
        {
            private GrupoWS.psicologo psico;

            public PsicologoInfo(GrupoWS.psicologo psico)
            {
                this.psico = psico;
            }

            public string Nombre { get => psico.nombre + " " + psico.apellidoPaterno + " " + psico.apellidoMaterno; }
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            plantillaGestion.abrirFormulario(formAnterior);
        }
    }
}
