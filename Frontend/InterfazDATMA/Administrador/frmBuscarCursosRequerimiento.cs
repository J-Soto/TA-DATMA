using MaterialSkin.Controls;
using InterfazDATMA.CursoWS;
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
using MaterialSkin;

namespace InterfazDATMA.Administrador
{
    public partial class frmBuscarCursosRequerimiento : MaterialSkin.Controls.MaterialForm 
    {

        private CursoWS.CursoWSClient daoCurso;
        private CursoWS.curso curso_Req;

        public MaterialSkinManager ThemeManager = MaterialSkinManager.Instance;
        private DateTime cursoInicio;

        public curso Curso_Req { get => curso_Req; set => curso_Req = value; }

        public frmBuscarCursosRequerimiento(DateTime cursoInicio)
        {
            this.DoubleBuffered = true;
            this.cursoInicio = cursoInicio;
            InitializeComponent();

            Design.Ini(this);
            if (Design.tema == 'd') ThemeManager.Theme = MaterialSkinManager.Themes.DARK;
            else ThemeManager.Theme = MaterialSkinManager.Themes.LIGHT;
            dgvCursosReq.AutoGenerateColumns = false;
            dgvCursosReq.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            inicializarPantalla();
        }

        void inicializarPantalla()
        {
            daoCurso = new CursoWS.CursoWSClient();
            curso_Req = new CursoWS.curso();

            BindingList<CursoWS.curso> cursos = new BindingList<CursoWS.curso>(daoCurso.listarCursos().ToList());
            BindingList<CursoWS.curso> cursosReq = new BindingList<CursoWS.curso>();

            foreach(CursoWS.curso recCursos in cursos)
            {
                if(recCursos.fechaFin.Date < cursoInicio.Date)
                {
                    cursosReq.Add(recCursos);
                }
            }

            dgvCursosReq.DataSource = cursosReq;
        }


        private void dgvCursosReq_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            CursoWS.curso auxCurso = dgvCursosReq.Rows[e.RowIndex].DataBoundItem as CursoWS.curso;
            
            dgvCursosReq.Rows[e.RowIndex].Cells["NombreCurso"].Value = auxCurso.descripcion;
            dgvCursosReq.Rows[e.RowIndex].Cells["FechaInicial"].Value = auxCurso.fechaInicio;
            dgvCursosReq.Rows[e.RowIndex].Cells["FechaFinal"].Value = auxCurso.fechaFin;
        }


        private void btnSeleccionarCur_Click_1(object sender, EventArgs e)
        {
            if (dgvCursosReq.RowCount != 0)
            {
                curso_Req = dgvCursosReq.CurrentRow.DataBoundItem as CursoWS.curso;
                this.DialogResult = DialogResult.OK;
            }

        }

        private void btnCancelar_Click_1(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            curso_Req.idCurso = 0;

        }
    }
}
