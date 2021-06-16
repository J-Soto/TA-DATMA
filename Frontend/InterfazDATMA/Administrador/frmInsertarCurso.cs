﻿using InterfazDATMA.plantilla;
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
        private GrupoWS.GrupoWSClient daoGrupo;

        //semanas:
        private SemanaWS.SemanaWSClient daoSemana;



        public frmInsertarCurso(frmOperacionesCursos formOperacionesCursos, frmPlantillaGestion formPlantillaGest)
        {
            this.formPlantillaGest = formPlantillaGest;
            this.formOperacionesCursos = formOperacionesCursos;

            daoCurso = new CursoWS.CursoWSClient();
            daoGrupo = new GrupoWS.GrupoWSClient();
            daoSemana = new SemanaWS.SemanaWSClient();

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
            if (idCurso != 0)
            {
                int contSemanas = 0;
                //Insertar temas
                foreach (TemaWS.tema recTema in temasCurso)
                {
                    recTema.fechaInicioSpecified = true;
                    recTema.fechaFinSpecified = true;
                    int idCursoTema = daoCurso.insertarCursoTema(idCurso, recTema.id, recTema.fechaInicio, recTema.fechaFin);

                    //Insertar semanas:
                    SemanaWS.semana semana = new SemanaWS.semana();
                    contSemanas++;
                    semana.nombre = "Editar nombre Semana: " + contSemanas;
                    semana.descripcion = "Editar";
                    semana.fechaInicio = recTema.fechaInicio;
                    semana.fechaInicioSpecified = true;
                    semana.curso = new SemanaWS.curso();
                    semana.curso.idCurso = idCurso;
                    daoSemana.insertarSemana(semana, idCursoTema);
                }
                
                //Insertar grupos
                foreach(Grupo_Curso recGruposCurso in gruposCurso)
                {
                    int idGrupo = daoGrupo.insertarGrupo(idCurso, recGruposCurso.Grupo);
                    if(idGrupo != 0)
                    {
                        //Insertar psicologos
                        foreach (PsicologoWS.psicologo recPsicologo in recGruposCurso.Psicologos)
                        {
                            daoGrupo.insertarGrupoPsicologo(recPsicologo.idPersona, idGrupo);
                        }
                    }
                }

                //Insertar semanas:
                //for(int i = 0; i < curso.cantSemanas; i++)
                //{
                //    SemanaWS.semana semana = new SemanaWS.semana();
                //    int auxSemana = i + 1;
                //    semana.nombre = "Editar nombre Semana: " + auxSemana;
                //    semana.descripcion = "Editar";
                //    semana.fechaInicio = DateTime.Now; //Editar
                //    semana.fechaInicioSpecified = true;
                //    semana.curso = new SemanaWS.curso();
                //    MessageBox.Show(idCurso.ToString());
                //    semana.curso.idCurso = idCurso;
                //    daoSemana.insertarSemana()
                //}

                MessageBox.Show("Se ha registrado el curso con exito", "Mensaje de Confirmacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void btnAgregarReq_Click(object sender, EventArgs e)
        {

            frmBuscarCursosRequerimiento formBuscarCursoReq = new frmBuscarCursosRequerimiento();

            if(formBuscarCursoReq.ShowDialog() == DialogResult.OK)
            {


            }

        }
    }
}
