﻿using MaterialSkin.Controls;
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
        private BindingList<Curso> cursos = null;

        public frmCursosDisponibles(frmListaCursoInscritos formAnterior,frmPlantillaGestion plantilla)
        {
            InitializeComponent();
            Design.Ini(this);
            this.formAnterior = formAnterior;
            this.plantilla = plantilla;

            dgvCursos.AutoGenerateColumns = false;
            Fetch();
            dgvCursos.DataSource = cursos;
        }

        private void btnInscribirse_Click_1(object sender, EventArgs e)
        {
            plantilla.abrirFormulario(new frmInscripcionHecha(this, plantilla));

        }

        private void btnMasInfo_Click_1(object sender, EventArgs e)
        {
            plantilla.abrirFormulario(new frmInformacionCurso(this, plantilla));
        }

        private void Fetch()
        {
            var temp = daoCurso.listarCursosDisponibles();
            if (temp is object)
            {
                cursos = new BindingList<Curso>();
                foreach (var curso in temp)
                {
                    var psico = daoPsi.listarPsicologosPorIdCurso(curso.idCurso);
                    if (psico is object)
                    {
                        cursos.Add(new Curso(curso, psico[0]));
                    }
                }
            }
        }
    }

    public class Curso
    {
        private CursoWS.curso curso;
        private PsicologoWS.psicologo psico;

        public Curso(CursoWS.curso curso, PsicologoWS.psicologo psico)
        {
            this.curso = curso;
            this.psico = psico;
        }

        public string Encargado { get => psico.nombre + " " + psico.apellidoPaterno + " " + psico.apellidoMaterno; }

        public DateTime FechaInicio { get => curso.fechaInicio; }

        public DateTime FechaFin { get => curso.fechaFin; }

        public string Modulo { get => curso.descripcion; }
    }
}
