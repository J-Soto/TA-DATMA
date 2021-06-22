using MaterialSkin.Controls;
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
using InterfazDATMA.util;

namespace InterfazDATMA
{
    public partial class frmConfigurarModuloPsicologo : MaterialSkin.Controls.MaterialForm 
    {
        private frmPlantillaGestion formPlantilla;
        public frmGestionarModulosPsicologo formGestionarModulos;
        private CursoWS.curso curso; //Curso al que se ingreso
        private GrupoWS.grupo grupo; //Grupo que pertenece al curso
        private CursoWS.CursoWSClient daoCurso;

        private BindingList<SemanaTema> pares;

        public frmConfigurarModuloPsicologo(frmGestionarModulosPsicologo formGestionarModulos, frmPlantillaGestion formPlantilla, Psicologo_Curso auxCurso)
        {
            InitializeComponent();
            MaterialSkin.MaterialSkinManager skinManager = MaterialSkin.MaterialSkinManager.Instance;
            skinManager.AddFormToManage(this);
            skinManager.Theme = MaterialSkin.MaterialSkinManager.Themes.DARK;
            skinManager.ColorScheme = new MaterialSkin.ColorScheme(MaterialSkin.Primary.BlueGrey500, MaterialSkin.Primary.BlueGrey700, MaterialSkin.Primary.BlueGrey100, MaterialSkin.Accent.Teal700, MaterialSkin.TextShade.WHITE);

            this.formPlantilla = formPlantilla;
            this.formGestionarModulos = formGestionarModulos;
            //Curso:
            this.curso = auxCurso.Curso;
            //Grupo del Curso:
            this.grupo = new GrupoWS.grupo();
            this.grupo.idGrupo = auxCurso.Grupo.idGrupo;
            this.grupo.nombrePromocion = auxCurso.Grupo.nombrePromocion;
            this.grupo.maxCantCuidadores = auxCurso.Grupo.maxCantCuidadores;


            daoCurso = new CursoWS.CursoWSClient();
            lblNombreModulo.Text = "Curso: " + curso.descripcion;
            dgvPrograma.AutoGenerateColumns = false;
            pares = new BindingList<SemanaTema>(Fetch());
            dgvPrograma.DataSource = pares;


            btnInsertarSemana.Visible = false;
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
                        //if ((semana.fechaInicio < tema.fechaInicio && tema.fechaInicio < semana.fechaInicio.AddDays(7)) ||
                        //    (semana.fechaInicio < tema.fechaFin && tema.fechaFin < semana.fechaInicio.AddDays(7)))
                        //{
                        //    arr.Add(new SemanaTema(semana, tema));
                        //}

                        if (semana.fechaInicio.Date == tema.fechaInicio.Date && tema.fechaFin.Date == semana.fechaInicio.AddDays(7).Date)
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

        private void btnModificarSemana_Click(object sender, EventArgs e)
        {
            SemanaTema auxSemTema = dgvPrograma.CurrentRow.DataBoundItem as SemanaTema;
            SemanaWS.semana auxSemana = new SemanaWS.semana();
            auxSemana.id = auxSemTema.Semana.id;
            auxSemana.fechaInicio = auxSemTema.Semana.fechaInicio;
            auxSemana.descripcion = auxSemTema.Semana.descripcion;
            auxSemana.nombre = auxSemTema.Semana.nombre;

            formPlantilla.abrirFormulario(new frmModificarPrograma(this, formPlantilla, grupo, auxSemana, curso, auxSemTema.Tema.nombre));
        }


        public void refrescarDataGridView(SemanaWS.semana auxSemana)
        {

            foreach (var recSemana in pares)
            {
                if (recSemana.Semana.id == auxSemana.id)
                {
                    recSemana.Semana.nombre = auxSemana.nombre;
                    recSemana.Semana.descripcion = auxSemana.descripcion;
                }
            }

            dgvPrograma.Refresh();
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

        public DateTime FechaInicio { get => semana.fechaInicio; }
        public CursoWS.semana Semana { get => semana; set => semana = value; }
        public CursoWS.tema Tema { get => tema; set => tema = value; }
    }
}
