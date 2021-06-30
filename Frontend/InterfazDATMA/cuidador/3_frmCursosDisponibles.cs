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
        private BindingList<CursoTutor> cursos2 = null;
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
            Fetch2();
            foreach (var curso in cursos2)
            {
                ListViewItem item = new ListViewItem();
                item.SubItems.Insert(0, new ListViewItem.ListViewSubItem(item, curso.Modulo));
                item.SubItems.Insert(1, new ListViewItem.ListViewSubItem(item, curso.GrupoStr));
                item.SubItems.Insert(2, new ListViewItem.ListViewSubItem(item, curso.NumInscritosStr));
                item.SubItems.Insert(3, new ListViewItem.ListViewSubItem(item, curso.Encargado));
                item.SubItems.Insert(4, new ListViewItem.ListViewSubItem(item, curso.FechaInicio.ToLongDateString()));
                item.SubItems.Insert(5, new ListViewItem.ListViewSubItem(item, curso.FechaFin.ToLongDateString()));
                
                listCursos.Items.Add(item);
            }
            dgvCursos.DataSource = cursos;
        }

        private void btnInscribirse_Click_1(object sender, EventArgs e)
        {
            // inscribirse
            int index = dgvCursos.CurrentCell.RowIndex;
            int index2 = listCursos.SelectedIndices[0];
            
            var obj = cursos[index];
            var obj2 = cursos2[index2];

            daoCurso.insertarTutorCurso(frmPlantillaGestion.tutor.idPersona, obj.Curso.idCurso);
            daoCurso.insertarTutorCurso(frmPlantillaGestion.tutor.idPersona, obj.Curso.idCurso);
            
            daoGrupo.insertarGrupoTutor(frmPlantillaGestion.tutor.idPersona, obj2.Grupo.idGrupo, obj.Grupo.cantInfantes);
            daoGrupo.insertarGrupoTutor(frmPlantillaGestion.tutor.idPersona, obj2.Grupo.idGrupo, obj.Grupo.cantInfantes);
            
            var temp = cursos.ToList();
            var temp2 = cursos2.ToList();

            temp.RemoveAll( item => item.Curso.idCurso == obj.Curso.idCurso);
            temp2.RemoveAll(item => item.Curso.idCurso == obj2.Curso.idCurso);
            
            cursos = new BindingList<CursoTutor>(temp);
            cursos2 = new BindingList<CursoTutor>(temp2);
            
            
            listCursos.Refresh();
            dgvCursos.Refresh();
            
            plantilla.abrirFormulario(new frmInscripcionHecha(this, plantilla));
        }

        private void btnMasInfo_Click_1(object sender, EventArgs e)
        {
            //plantilla.abrirFormulario(new frmInformacionCurso(this, plantilla, cursos[dgvCursos.CurrentCell.RowIndex]));
            plantilla.abrirFormulario(
                new frmInformacionCurso(
                    this, 
                    plantilla, 
                    cursos2[listCursos.SelectedIndices[0]]));
            
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

        private void Fetch2()
        {
            cursos2 = new BindingList<CursoTutor>();
            foreach (var curso in cursosDisponibles)
            {
                var grupos = daoGrupo.listarGrupoPorIdCurso(curso.idCurso);
                if (grupos is object)
                {
                    foreach (var grupo in grupos)
                    {
                        var psico = daoGrupo.listarPsicologosPorIdGrupo(grupo.idGrupo);
                        int numInscritos = daoGrupo.getGrupoNumInscritos(grupo.idGrupo);
                        cursos2.Add(new CursoTutor(curso, grupo, psico, numInscritos));
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

        public string Encargado { get { 
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
            } }

        public DateTime FechaInicio { get => curso.fechaInicio; }

        public DateTime FechaFin { get => curso.fechaFin; }

        public string Modulo { get => curso.descripcion; }

        public CursoWS.curso Curso { get => curso; }

        public GrupoWS.psicologo Psicologo { get => psicos[0]; }

        public string GrupoStr { get => grupo.nombrePromocion; }

        public GrupoWS.grupo Grupo { get => grupo; }

        public int  NumInscritos { get => numInscritos; }

        public string NumInscritosStr { get => numInscritos + "/" + grupo.maxCantCuidadores; }
    }
}
