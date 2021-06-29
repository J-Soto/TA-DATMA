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
        private GrupoWS.GrupoWSClient daoGrupo = new GrupoWS.GrupoWSClient();

        private BindingList<CursoTutor> cursos = null;
        private List<CursoWS.curso> cursosDisponibles = null;

        public frmCursosDisponibles(frmListaCursoInscritos formAnterior,frmPlantillaGestion plantilla, List<CursoWS.curso> cursosDisponibles)
        {
            InitializeComponent();
            Design.Ini(this);
            this.formAnterior = formAnterior;
            this.plantilla = plantilla;
            // cursos en el que el psicologo no se ha inscrito
            this.cursosDisponibles = cursosDisponibles;

            dgvCursos.AutoGenerateColumns = false;
            Fetch();
            dgvCursos.DataSource = cursos;
        }

        private void btnInscribirse_Click_1(object sender, EventArgs e)
        {
            // inscribirse
            int index = dgvCursos.CurrentCell.RowIndex;
            daoCurso.insertarTutorCurso(frmPlantillaGestion.tutor.idPersona, cursos[index].Curso.idCurso);
            plantilla.abrirFormulario(new frmInscripcionHecha(this, plantilla));
            cursos.RemoveAt(index);
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
                var grupos = daoGrupo.listarGrupoPorIdCurso(curso.idCurso);
                if (grupos is object)
                {
                    foreach (var grupo in grupos)
                    {
                        var psico = daoGrupo.listarPsicologosPorIdGrupo(grupo.idGrupo);
                        cursos.Add(new CursoTutor(curso, grupo, psico));
                    }
                }
            }
        }
    }

    public class CursoTutor
    {
        private CursoWS.curso curso;
        private GrupoWS.grupo grupo;
        private List<GrupoWS.psicologo> psicos;

        public CursoTutor(CursoWS.curso curso, GrupoWS.grupo grupo, GrupoWS.psicologo[] psicos)
        {
            this.curso = curso;
            this.grupo = grupo;
            this.psicos = new List<GrupoWS.psicologo>(psicos);
        }

        public string Encargado { get { 
                if (psicos.Count == 1)
                {
                    return psicos[0].nombre + " " + psicos[0].apellidoPaterno + " " + psicos[0].apellidoMaterno;
                } else
                {
                    string res = "";
                    foreach (var psico in psicos)
                    {
                        res += psico.nombre + " " + psico.apellidoPaterno + " " + psico.apellidoMaterno + ", ";
                    }
                    res = res.Substring(0, res.Length - 2);
                    return res;
                }
            } }

        public DateTime FechaInicio { get => curso.fechaInicio; }

        public DateTime FechaFin { get => curso.fechaFin; }

        public string Modulo { get => curso.descripcion; }

        public CursoWS.curso Curso { get => curso; }

        public GrupoWS.psicologo Psicologo { get => psicos[0]; }

        public string Grupo { get => grupo.nombrePromocion; }

        
    }
}
