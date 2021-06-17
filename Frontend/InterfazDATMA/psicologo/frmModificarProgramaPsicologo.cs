using InterfazDATMA;
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

namespace InterfazDATMA
{
    public partial class frmModificarPrograma : Form
    {
        private frmConfigurarModuloPsicologo formConfigurarModuloPsicologo;
        private frmPlantillaGestion formPlantillaGestion;

        private SemanaWS.SemanaWSClient daoSemana;
        private CursoWS.CursoWSClient daoCurso;
        //private SemanaWS.semana semana;
        BindingList<CursoWS.semana> semanas;
        public frmModificarPrograma(frmConfigurarModuloPsicologo formConfigurarModuloPsicologo, frmPlantillaGestion formPlantillaGestion,int idCurso)
        {
            InitializeComponent();
            this.formConfigurarModuloPsicologo = formConfigurarModuloPsicologo;
            this.formPlantillaGestion = formPlantillaGestion;

            daoSemana = new SemanaWS.SemanaWSClient();
            daoCurso = new CursoWS.CursoWSClient();
            BindingList<CursoWS.semana> semanas = new BindingList<CursoWS.semana>(
                daoCurso.listarSemanasPorIdCurso(idCurso).ToList());
            rtxtDescripcion.Text = semanas[0].descripcion;
            rtxtTema.Text = semanas[0].nombre;
            rtxtDescripcion.ReadOnly = true;
            rtxtTema.ReadOnly = true;
        }

        private void btnAgregarMaterial_Click(object sender, EventArgs e)
        {
            frmAgregarMaterialPsicologo formAgregarMaterialPsicologo = new frmAgregarMaterialPsicologo();
            formAgregarMaterialPsicologo.ShowDialog();
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            formPlantillaGestion.abrirFormulario(formConfigurarModuloPsicologo);
        }

        private void btnAgregarReunion_Click(object sender, EventArgs e)
        {
            frmAgregarReunionPsicologo formAgregarReunionPsicologo = new frmAgregarReunionPsicologo();
            formAgregarReunionPsicologo.ShowDialog();

        }

        private void btnAsitencia_Click(object sender, EventArgs e)
        {
            formPlantillaGestion.abrirFormulario(new frmRegistrarAsistenciaCuidadores(this, formPlantillaGestion));
        }

        private void btnEditarDescrip_Click(object sender, EventArgs e)
        {
            rtxtDescripcion.ReadOnly = false;
            rtxtTema.ReadOnly = false;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            SemanaWS.semana semana = new SemanaWS.semana();
            semana.nombre = rtxtTema.Text;
            semana.descripcion = rtxtDescripcion.Text;
            int resultado = daoSemana.modificarSemana(semana);
            rtxtDescripcion.ReadOnly = true;
            rtxtTema.ReadOnly = true;
        }
    }
}
