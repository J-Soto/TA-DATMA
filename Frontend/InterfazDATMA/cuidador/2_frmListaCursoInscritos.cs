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
namespace InterfazDATMA
{
    public partial class frmListaCursoInscritos : MaterialSkin.Controls.MaterialForm
    {
        private frmPerfilCuidador formAnterior2;
        private frmPlantillaGestion plantillaGestion;
        private List<CursoWS.curso> cursos = null;
        private CursoWS.CursoWSClient daoCurso = new CursoWS.CursoWSClient();
        private ActividadWS.ActividadWSClient daoActividad = new ActividadWS.ActividadWSClient();
        private SemanaWS.SemanaWSClient daoSemana = new SemanaWS.SemanaWSClient();
        private ActividadWS.actividad[] temp4;
        public frmListaCursoInscritos(frmPlantillaGestion plantillaGestion)
        {
            InitializeComponent();
            Design.Ini(this);
            var temp = daoCurso.listarCursosDeTutor(frmPlantillaGestion.tutor.idPersona);
            if (temp is object)
            {
                cursos = new List<CursoWS.curso>(temp);
            }

            foreach (var curso  in cursos)
            {
                var temp2 = daoCurso.listarSemanasPorIdCurso(curso.idCurso);    //semanas de cada curso
                foreach (var semana in temp2)
                {
                    var temp3 = daoActividad.listarActividadesIdSemana(semana.id);//actividades de cada semana
                    try
                    {
                        foreach (var actividad in temp3)
                        {
                            try
                            {
                                temp4.Append(actividad);
                            }
                            catch (ArgumentNullException ex)
                            {

                            }
                        }
                    }
                    catch
                    {

                    }
                }
            }
            
                
                
                
            dgvListaCursos.AutoGenerateColumns = false;
            dgvCalendario.AutoGenerateColumns = false;

            dgvCalendario.DataSource = temp4;
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
