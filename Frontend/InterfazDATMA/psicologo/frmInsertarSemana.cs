using MaterialSkin.Controls;
using InterfazDATMA.util;
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

namespace InterfazDATMA
{
    public partial class frmInsertarSemana : MaterialSkin.Controls.MaterialForm 
    {
        private TemaWS.TemaWSClient daoTema = new TemaWS.TemaWSClient();
        private CursoWS.CursoWSClient daoCurso = new CursoWS.CursoWSClient();
        private SemanaWS.SemanaWSClient daoSemana = new SemanaWS.SemanaWSClient();

        private BindingList<TemaWS.tema> temasList;
        private int idCurso;



        public MaterialSkinManager ThemeManager = MaterialSkinManager.Instance;
        public frmInsertarSemana()
        {
            InitializeComponent();
            Design.Ini(this);
            if (Design.tema == 'd') ThemeManager.Theme = MaterialSkinManager.Themes.DARK;
            else ThemeManager.Theme = MaterialSkinManager.Themes.LIGHT;
        }

        public int IdCurso { get => idCurso; set => idCurso = value; }



        private void frmInsertarSemana_VisibleChanged(object sender, EventArgs e)
        {
            var temas = daoTema.listarTemas();
            if (temas is object)
            {
                temasList = new BindingList<TemaWS.tema>(temas);
                dgvTemas.AutoGenerateColumns = false;
                dgvTemas.DataSource = temasList;
            }
        }

        
        private void btnCancelar_Click(object sender, EventArgs e)
        {

            Close();
        }

        private void btnGuardar_Click_1(object sender, EventArgs e)
        {/*
            var idCursoTema = daoCurso.insertarCursoTema(idCurso, temasList[dgvTemas.CurrentCell.RowIndex].id,
                (DateTime)dateCursoFechaInicio.GetValue, dateCursoFechaFin.GetValue);
            var curso = new SemanaWS.curso
            {
                idCurso = idCurso
            };
            var semana = new SemanaWS.semana()
            {
                nombre = txtSemanaNombre.Text,
                descripcion = txtSemanaDescrip.Text,
                fechaInicio = dateSemanaFechaInicio.Value,
                fechaInicioSpecified = true,
                curso = curso
            };
            daoSemana.insertarSemana(semana, idCursoTema);
            DialogResult = DialogResult.OK;
            */

        }
    }
}
