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
using MaterialSkin;
using InterfazDATMA.util;
namespace InterfazDATMA
{
    public partial class frmCursosDisponibles : MaterialSkin.Controls.MaterialForm 
    {
        public frmListaCursoInscritos formAnterior;
        private frmPlantillaGestion plantilla;

        public MaterialSkinManager ThemeManager = MaterialSkinManager.Instance;
        private CursoWS.CursoWSClient daoCurso = new CursoWS.CursoWSClient();
        private PsicologoWS.PsicologoWSClient daoPsi = new PsicologoWS.PsicologoWSClient();
        private GrupoWS.GrupoWSClient daoGrupo = new GrupoWS.GrupoWSClient();
        private SemanaWS.SemanaWSClient daoSemana = new SemanaWS.SemanaWSClient();
        private AsistenciaWS.AsistenciaWSClient daoAsistencia = new AsistenciaWS.AsistenciaWSClient();

        private BindingList<CursoTutor> cursos = null;
        private List<CursoWS.curso> cursosDisponibles = null;

        public frmCursosDisponibles(frmListaCursoInscritos formAnterior, frmPlantillaGestion plantilla, List<CursoWS.curso> cursosDisponibles)
        {
            InitializeComponent();
            Design.Ini(this);
            if (Design.tema == 'd') ThemeManager.Theme = MaterialSkinManager.Themes.DARK;
            else ThemeManager.Theme = MaterialSkinManager.Themes.LIGHT; 
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
            var obj = cursos[index];
            // TODO: verificar que los requerimientos esten satisfechos y no se pase de cantidad de inscritos
            daoCurso.insertarTutorCurso(frmPlantillaGestion.tutor.idPersona, obj.Curso.idCurso);
            daoGrupo.insertarGrupoTutor(frmPlantillaGestion.tutor.idPersona, obj.Grupo.idGrupo, obj.Grupo.cantInfantes);
            var temp = cursos.ToList();

            //Agregar tutor a las actividades del curso:
            var auxSemanas = daoCurso.listarSemanasPorIdCurso(obj.Curso.idCurso);
            if (auxSemanas != null)
            {
                BindingList<CursoWS.semana> semanas = new BindingList<CursoWS.semana>(auxSemanas.ToList());
                foreach (CursoWS.semana recSemanas in semanas)
                {
                    var auxActividades = daoSemana.listarActividadesPorIdSemana(recSemanas.id);
                    if (auxActividades != null)
                    {
                        BindingList<SemanaWS.actividad> actividades = new BindingList<SemanaWS.actividad>(auxActividades.ToList());
                        foreach (SemanaWS.actividad recActividades in actividades)
                        {
                            AsistenciaWS.asistencia asistencia = new AsistenciaWS.asistencia();
                            asistencia.usuario = new AsistenciaWS.usuario();
                            asistencia.usuario.idUsuario = frmPlantillaGestion.tutor.idUsuario;
                            asistencia.tipo = 0;
                            asistencia.descripcion = "No Asistio";
                            asistencia.actividad = new AsistenciaWS.actividad();
                            asistencia.actividad.idActividad = recActividades.idActividad;
                            daoAsistencia.insertarAsistencia(asistencia);
                        }
                    }
                }

            }
            //

            temp.RemoveAll(item => item.Curso.idCurso == obj.Curso.idCurso);
            cursos = new BindingList<CursoTutor>(temp);
            dgvCursos.DataSource = cursos;
            plantilla.abrirFormulario(new frmInscripcionHecha(this, plantilla, obj));
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
                        int numInscritos = daoGrupo.getGrupoNumInscritos(grupo.idGrupo);
                        cursos.Add(new CursoTutor(curso, grupo, psico, numInscritos));
                    }
                }
            }
        }
    }

    public class CursoTutor
    {
        private CursoWS.curso curso;
        private GrupoWS.grupo grupo;
        private List<GrupoWS.psicologo> psicos = null;
        private int numInscritos;

        public CursoTutor(CursoWS.curso curso, GrupoWS.grupo grupo, GrupoWS.psicologo[] psicos, int numInscritos)
        {
            this.curso = curso;
            this.grupo = grupo;
            this.numInscritos = numInscritos;
            if (psicos is object)
            {
                this.psicos = new List<GrupoWS.psicologo>(psicos);
            }
        }

        public string Encargado
        {
            get
            {
                if (psicos is null)
                {
                    return "No hay encargados";
                }
                string res = "";
                foreach (var psico in psicos)
                {
                    res += psico.nombre + " " + psico.apellidoPaterno + " " + psico.apellidoMaterno + ", ";
                }
                return res.Substring(0, res.Length - 2);
            }
        }

        public DateTime FechaInicio { get => curso.fechaInicio; }

        public DateTime FechaFin { get => curso.fechaFin; }

        public string Modulo { get => curso.descripcion; }

        public CursoWS.curso Curso { get => curso; }

        public List<GrupoWS.psicologo> Psicologo { get => psicos; }

        public string GrupoStr { get => grupo.nombrePromocion; }

        public GrupoWS.grupo Grupo { get => grupo; }

        public int NumInscritos { get => numInscritos; }

        public string NumInscritosStr { get => numInscritos + "/" + grupo.maxCantCuidadores; }
    }
}
