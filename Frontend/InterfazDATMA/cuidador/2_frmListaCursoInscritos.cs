using InterfazDATMA.cuidador;
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
using MaterialSkin.Controls;
using InterfazDATMA.util;
using MaterialSkin;

namespace InterfazDATMA
{
    public partial class frmListaCursoInscritos : MaterialSkin.Controls.MaterialForm
    {

        public MaterialSkinManager ThemeManager = MaterialSkinManager.Instance;
        private frmPerfilCuidador formAnterior2;
        private frmPlantillaGestion plantillaGestion;
        private List<CursoWS.curso> cursos = null;
        private CursoWS.CursoWSClient daoCurso = new CursoWS.CursoWSClient();
        private ActividadWS.ActividadWSClient daoActividad = new ActividadWS.ActividadWSClient();
        private List<InfoActividad> infoActividades = new List<InfoActividad>();

        public frmListaCursoInscritos(frmPlantillaGestion plantillaGestion)
        {
            InitializeComponent();
            Design.Ini(this);
            if (Design.tema == 'd') ThemeManager.Theme = MaterialSkinManager.Themes.DARK;
            else ThemeManager.Theme = MaterialSkinManager.Themes.LIGHT;
            dgvListaCursos.AutoGenerateColumns = false;
            FetchCursos();

            TableStyles.CopyStyles(dgvListaCursos);

            foreach (var curso in cursos)
            {
                if (curso is object)
                {
                    var temp2 = daoCurso.listarSemanasPorIdCurso(curso.idCurso);    //semanas de cada curso
                    if (temp2 is object)
                    {
                        foreach (var semana in temp2)
                        {
                            var temp3 = daoActividad.listarActividadesIdSemana(semana.id); //actividades de cada semana
                            if (temp3 is object)
                            {
                                foreach (var actividad in temp3)
                                {
                                    if (actividad is object)
                                    {
                                        infoActividades.Add(new InfoActividad(curso, actividad));
                                    }
                                }
                            }
                        }
                    }
                }
            }

            TableStyles.ApplyStyles(dgvCalendario);
            dgvCalendario.AutoGenerateColumns = false;
            dgvCalendario.DataSource = infoActividades;
            

            this.plantillaGestion = plantillaGestion;
        }

        private class InfoActividad
        {
            private CursoWS.curso curso;
            private ActividadWS.actividad actividad;

            public InfoActividad(CursoWS.curso curso, ActividadWS.actividad actividad)
            {
                this.curso = curso;
                this.actividad = actividad;
            }

            public string Curso
            {
                get => curso.descripcion;
            }

            public DateTime Fecha
            {
                get => actividad.fecha;
            }

            public DateTime HoraIni
            {
                get => Convert.ToDateTime(actividad.horaInicioStr);
                //get => actividad.horaInicioStr;
            }

            public DateTime HoraFin
            {
                get => Convert.ToDateTime(actividad.horaFinStr);
            }
        }

        public void FetchCursos()
        {
            var temp = daoCurso.listarCursosDeTutor(frmPlantillaGestion.tutor.idPersona);
            temp = temp.Where(curso => curso != null).ToArray();        //eliminamos los null
            cursos = new List<CursoWS.curso>(temp);
            dgvListaCursos.DataSource = cursos;
        }

        public frmListaCursoInscritos(frmPerfilCuidador formAnterior2, frmPlantillaGestion plantillaGestion)
        {
            InitializeComponent();
            Design.Ini(this);
            this.plantillaGestion = plantillaGestion;
            this.formAnterior2 = formAnterior2;
        }
      
        private void btnCursosDisponibles_Click(object sender, EventArgs e)
        {
            var temp = daoCurso.listarCursosDisponibles(frmPlantillaGestion.tutor.idPersona);
            if (temp is object)
            {
                // hay cursos disponibles
                plantillaGestion.abrirFormulario(new frmCursosDisponibles(this, plantillaGestion, new List<CursoWS.curso>(temp)));
            }
            else
            {
                // no hay
                plantillaGestion.abrirFormulario(new frmSinCursosDisponibles(this, plantillaGestion));
            }
        }

        

        private void dgvListaCursos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            plantillaGestion.abrirFormulario(new frmDetalleCursoInscrito(this, plantillaGestion, cursos[index]));
        }

    }
}
