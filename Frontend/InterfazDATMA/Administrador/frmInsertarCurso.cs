using InterfazDATMA.plantilla;
using InterfazDATMA.util;
using InterfazDATMA.validacion;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InterfazDATMA.Administrador
{
    public partial class frmInsertarCurso : Form
    {
        private frmPlantillaGestion formPlantillaGest;
        private frmOperacionesCursos formOperacionesCursos;
        private CursoWS.CursoWSClient daoCurso;
        private CursoWS.curso curso;

        //temas
        private BindingList<TemaWS.tema> temasCurso;

        //grupo_curso:
        private BindingList<Grupo_Curso> gruposCurso;
        private frmVerGruposCurso formVerGruposCurso;

        public frmInsertarCurso(frmOperacionesCursos formOperacionesCursos, frmPlantillaGestion formPlantillaGest)
        {
            this.formPlantillaGest = formPlantillaGest;
            this.formOperacionesCursos = formOperacionesCursos;

            daoCurso = new CursoWS.CursoWSClient();

            InitializeComponent();
            dgvReq.AutoGenerateColumns = false;
            dgvReq.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            inicializarPantalla();
        }



        private void inicializarPantalla()
        {
            txtNombreCurso.Text = "";
            dtpFechaInicial.Value = DateTime.Now;
            dtpFechaInicial.CustomFormat = "dd/MM/yyyy";
            dtpFechaInicial.Format = DateTimePickerFormat.Custom;
            dtpFechaFin.Value = DateTime.Now;
            dtpFechaFin.CustomFormat = "dd/MM/yyyy";
            dtpFechaFin.Format = DateTimePickerFormat.Custom;
            dtpFechaFin.Enabled = false;
            dtpFechaInscrip.Value = DateTime.Now;
            dtpFechaInscrip.CustomFormat = "dd/MM/yyyy";
            dtpFechaInscrip.Format = DateTimePickerFormat.Custom;
            dtpFechaInscrip.Enabled = false;
            txtCantSemana.Text = "0";

            temasCurso = new BindingList<TemaWS.tema>();
            gruposCurso = new BindingList<Grupo_Curso>();
            curso = new CursoWS.curso();
        }


        private void btnSelaccionarTemas_Click(object sender, EventArgs e)
        {
            int cantSemanas = Int32.Parse(txtCantSemana.Text);
            DateTime fechaInicialCur = dtpFechaInicial.Value;
            DateTime fechaFinalCur = dtpFechaFin.Value;

            frmSeleccionarTemasDeCurso formSeleccionarTemaCurso = new frmSeleccionarTemasDeCurso(this, formPlantillaGest, cantSemanas, fechaInicialCur, fechaFinalCur, temasCurso);
            formPlantillaGest.abrirFormulario(formSeleccionarTemaCurso);
        }

        private void btnVerGrupos_Click(object sender, EventArgs e)
        {
            formVerGruposCurso = new frmVerGruposCurso(this, formPlantillaGest, gruposCurso);
            formPlantillaGest.abrirFormulario(formVerGruposCurso);
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            formPlantillaGest.abrirFormulario(formOperacionesCursos);
        }

        private void btnGuardarCurso_Click(object sender, EventArgs e)
        {
            curso.descripcion = txtNombreCurso.Text;
            curso.fechaInicio = dtpFechaInicial.Value;
            curso.fechaInicioSpecified = true;
            curso.fechaFin = dtpFechaFin.Value;
            curso.fechaFinSpecified = true;
            curso.fechaInscripcion = dtpFechaInscrip.Value;
            curso.fechaInscripcionSpecified = true;
            curso.cantSemanas = Int32.Parse(txtCantSemana.Text);
            int idCurso = daoCurso.insertarCurso(curso);
            if(idCurso != 0)
            {
                foreach (TemaWS.tema recTema in temasCurso)
                {
                    recTema.fechaInicioSpecified = true;
                    recTema.fechaFinSpecified = true;
                    daoCurso.insertarCursoTema(idCurso, recTema.id, recTema.fechaInicio, recTema.fechaFin);
                }
                MessageBox.Show("Se ha registrado el curso con exito","Mensaje de Confirmacion",MessageBoxButtons.OK,MessageBoxIcon.Information);

                inicializarPantalla();
            }
        }

        private void textCantSemana_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.SoloNumeros(e);
        }

        private void textCantSemana_TextChanged(object sender, EventArgs e)
        {
            DateTime auxDate = dtpFechaInicial.Value;
            if(txtCantSemana.Text != "")
            {
                int cantSemanas = Int32.Parse(txtCantSemana.Text);
                auxDate = auxDate.AddDays(cantSemanas * 7);
                dtpFechaFin.Value = auxDate;
            }
            else
            {
                dtpFechaFin.Value = auxDate;
            }
            
        }

    }
}
