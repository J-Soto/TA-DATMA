using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using InterfazDATMA;
using InterfazDATMA.plantilla;

namespace InterfazDATMA
{
    public partial class frmGestionarModulosPsicologo : Form
    {
        private frmPlantillaGestion plantillaGestion;
        private PsicologoWS.PsicologoWSClient daoPsicologo;
        private CursoWS.CursoWSClient daoCurso;
        private ActividadWS.ActividadWSClient daoActividad;
        private BindingList<CursoWS.curso> cursos;

        public frmGestionarModulosPsicologo(frmPlantillaGestion plantilla)
        {
            InitializeComponent();
            plantillaGestion = plantilla;
            daoPsicologo = new PsicologoWS.PsicologoWSClient();
            daoCurso = new CursoWS.CursoWSClient();
            daoActividad = new ActividadWS.ActividadWSClient();
            // obtener psicolog a partir del usuario
            var psicologos = daoPsicologo.listarTodosPsicologos();
            foreach (var psico in psicologos)
            {
                if (psico.idUsuario == frmPlantillaGestion.user.idUsuario)
                {
                    frmPlantillaGestion.psico = psico;
                    break;
                }
            }
            // obtener cursos del psicologo
            dgvModulos.AutoGenerateColumns = false;
            cursos = new BindingList<CursoWS.curso>(daoCurso.listarCursosPsicologo(frmPlantillaGestion.psico.idPersona));
            dgvModulos.DataSource = cursos;
            // obtener semanas
            var semanas = new List<CursoWS.semana>();
            foreach (var curso in cursos)
            {
                var temp = daoCurso.listarSemanasPorIdCurso(curso.idCurso);
                if (temp is object)
                {
                    semanas.AddRange(temp);
                }
            }
            // obtener actividades
            var actividades = new List<ActividadWS.actividad>();
            var allActiv = daoActividad.listarActividad();
            foreach (var semana in semanas)
            {
                foreach (var activ in allActiv)
                {
                    if (activ.idSemana == semana.id)
                    {
                        actividades.Add(activ);
                    }
                }
            }
            dgvCalendario.AutoGenerateColumns = false;
            dgvCalendario.DataSource = new BindingList<ActividadWS.actividad>(actividades);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var frmConfig = new frmConfigurarModuloPsicologo(this, plantillaGestion, cursos[dgvModulos.CurrentCell.RowIndex]);
            plantillaGestion.abrirFormulario(frmConfig);
        }
    }
}
