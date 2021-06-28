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
namespace InterfazDATMA
{
    public partial class frmCursosDisponibles : MaterialSkin.Controls.MaterialForm 
    {
        public frmListaCursoInscritos formAnterior;
        private frmPlantillaGestion plantilla;

        private CursoWS.CursoWSClient daoCurso = new CursoWS.CursoWSClient();
        private PsicologoWS.PsicologoWSClient daoPsi = new PsicologoWS.PsicologoWSClient();
        private BindingList<CursoTutor> cursos = null;
        private List<CursoWS.curso> cursosDisponibles = null;

        public frmCursosDisponibles(frmListaCursoInscritos formAnterior,frmPlantillaGestion plantilla, List<CursoWS.curso> cursosDisponibles)
        {
            InitializeComponent();
            Design.Ini(this);
            this.formAnterior = formAnterior;
            this.plantilla = plantilla;
            this.cursosDisponibles = cursosDisponibles;

            dgvCursos.AutoGenerateColumns = false;
            Fetch();
            dgvCursos.DataSource = cursos;
        }

        private void btnInscribirse_Click_1(object sender, EventArgs e)
        {
            // inscribirse
            plantilla.abrirFormulario(new frmInscripcionHecha(this, plantilla));
        }

        private void btnMasInfo_Click_1(object sender, EventArgs e)
        {
            plantilla.abrirFormulario(new frmInformacionCurso(this, plantilla, cursos[dgvCursos.CurrentCell.RowIndex]));
        }

        private void Fetch()
        {
            cursos = new BindingList<CursoTutor>();
            foreach (var curso in cursosDisponibles)
            {
                var psico = daoPsi.listarPsicologosPorIdCurso(curso.idCurso);
                if (psico is object)
                {
                    cursos.Add(new CursoTutor(curso, psico[0]));
                }
            }
        }
    }

    public class CursoTutor
    {
        private CursoWS.curso curso;
        private PsicologoWS.psicologo psico;

        public CursoTutor(CursoWS.curso curso, PsicologoWS.psicologo psico)
        {
            this.curso = curso;
            this.psico = psico;
        }

        public string Encargado { get => psico.nombre + " " + psico.apellidoPaterno + " " + psico.apellidoMaterno; }

        public DateTime FechaInicio { get => curso.fechaInicio; }

        public DateTime FechaFin { get => curso.fechaFin; }

        public string Modulo { get => curso.descripcion; }

        public CursoWS.curso Curso { get => curso; }

        public PsicologoWS.psicologo Psicologo { get => psico; }
    }
}
