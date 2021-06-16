using InterfazDATMA.plantilla;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InterfazDATMA
{
    public partial class frmConfigurarModuloPsicologo : Form
    {
        private frmPlantillaGestion formPlantilla;
        public frmGestionarModulosPsicologo formGestionarModulos;
        private CursoWS.curso curso;
        private CursoWS.CursoWSClient daoCurso;

        public frmConfigurarModuloPsicologo(frmGestionarModulosPsicologo formGestionarModulos, frmPlantillaGestion formPlantilla, CursoWS.curso curso)
        {
            InitializeComponent();
            this.formPlantilla = formPlantilla;
            this.formGestionarModulos = formGestionarModulos;
            this.curso = curso;
            daoCurso = new CursoWS.CursoWSClient();
            lblNombreModulo.Text = "Modulo: " + curso.descripcion;
            dgvPrograma.AutoGenerateColumns = false;
            var pares = new BindingList<SemanaTema>(Fetch());
            dgvPrograma.DataSource = pares;
        }

        private List<SemanaTema> Fetch()
        {
            var arr = new List<SemanaTema>();
            var semanas = daoCurso.listarSemanasPorIdCurso(curso.idCurso);
            var temas = daoCurso.listarTemasPorIdCurso(curso.idCurso);
            if (semanas is object && temas is object)
            {
                foreach (var semana in semanas)
                {
                    foreach (var tema in temas)
                    {
                        if ((semana.fechaInicio < tema.fechaInicio && tema.fechaInicio < semana.fechaInicio.AddDays(7)) ||
                            (semana.fechaInicio < tema.fechaFin && tema.fechaFin < semana.fechaInicio.AddDays(7)))
                        {
                            arr.Add(new SemanaTema(semana, tema));
                        }
                    }
                }
            }
            return arr;
        }

        private void btnListaCursos_Click(object sender, EventArgs e)
        {
            formPlantilla.abrirFormulario(formGestionarModulos);
        }

        private void btnListaCuidadores_Click(object sender, EventArgs e)
        {
            formPlantilla.abrirFormulario(new frmListaCuidadoresDePsicologo(this, formPlantilla));
        }

        private void btnInsertarSemana_Click(object sender, EventArgs e)
        {
            var insertarSemana = new frmInsertarSemana
            {
                IdCurso = curso.idCurso
            };
            if (insertarSemana.ShowDialog() == DialogResult.OK)
            {

            }
        }
    }

    public class SemanaTema: INotifyPropertyChanged
    {
        private CursoWS.semana semana;
        private CursoWS.tema tema;

        public event PropertyChangedEventHandler PropertyChanged;

        private void NotifyPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public SemanaTema(CursoWS.semana semana, CursoWS.tema tema)
        {
            this.semana = semana;
            this.tema = tema;
        }

        public string NombreTema { get { return tema.nombre; } }
        public string NombreSemana { get { return semana.nombre; } }
    }
}
