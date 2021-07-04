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
        private SemanaWS.SemanaWSClient daoSemana = new SemanaWS.SemanaWSClient();
        private List<Tuple<string, string, string, string>> calendario = new List<Tuple<string, string, string, string>>();
        public frmListaCursoInscritos(frmPlantillaGestion plantillaGestion)
        {
            InitializeComponent();
            Design.Ini(this);
            if (Design.tema == 'd') ThemeManager.Theme = MaterialSkinManager.Themes.DARK;
            else ThemeManager.Theme = MaterialSkinManager.Themes.LIGHT;
            var temp = daoCurso.listarCursosDeTutor(frmPlantillaGestion.tutor.idPersona);
            
            temp = temp.Where(curso => curso != null).ToArray();        //eliminamos los null
            cursos = new List<CursoWS.curso>(temp);
            int i = 0;
            //foreach (var curso in cursos)
            //{
            //    if (curso != null)
            //    {
            //        var temp2 = daoCurso.listarSemanasPorIdCurso(curso.idCurso);    //semanas de cada curso
            //        temp2 = temp2.Where(semana => semana != null).ToArray();        //eliminamos los null
            //        foreach (var semana in temp2)
            //        {
            //            var temp3 = daoActividad.listarActividadesIdSemana(semana.id); //actividades de cada semana
            //            if (temp3 != null)
            //            {
            //                foreach (var actividad in temp3)
            //                {
            //                    if (actividad != null)
            //                    {
            //                        ActividadWS.actividad aux = new ActividadWS.actividad();
            //                        aux = actividad;
            //                        Tuple<string, string, string, string> aux2 = new Tuple<string, string, string, string>(curso.descripcion, aux.fecha.ToLongDateString(), aux.horaInicioStr, aux.horaFinStr);
            //                        calendario.Insert(i, aux2);
            //                        i++;

            //                    }
            //                }
            //            }
            //        }
            //    }
            //}

            dgvListaCursos.AutoGenerateColumns = false;
            //DataTable dt = new DataTable();
            //dt.Columns.Add("Curso", typeof(string));
            //dt.Columns.Add("Fecha", typeof(string));
            //dt.Columns.Add("Hora Inicio", typeof(string));
            //dt.Columns.Add("Hora Fin", typeof(string));
            //foreach (var tuple in calendario)
            //{
            //    //DataRow row = new DataRow()
            //    //row.
            //    dt.Rows.Add(tuple.Item1, tuple.Item2, tuple.Item3, tuple.Item4);
            //}
            //dgvCalendario.DataSource = dt;
            //dgvCalendario.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            //dgvCalendario.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            //dgvCalendario.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            //dgvCalendario.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvListaCursos.DataSource = cursos;

            this.plantillaGestion = plantillaGestion;
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
