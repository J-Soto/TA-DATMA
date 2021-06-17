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
        private int idCurso;
        BindingList<CursoWS.semana> semanas;
        public frmModificarPrograma(frmConfigurarModuloPsicologo formConfigurarModuloPsicologo, frmPlantillaGestion formPlantillaGestion,int idCurso)
        {
            InitializeComponent();
            this.formConfigurarModuloPsicologo = formConfigurarModuloPsicologo;
            this.formPlantillaGestion = formPlantillaGestion;
            this.idCurso = idCurso;

            daoSemana = new SemanaWS.SemanaWSClient();
            daoCurso = new CursoWS.CursoWSClient();
            this.semanas = new BindingList<CursoWS.semana>(
                daoCurso.listarSemanasPorIdCurso(idCurso).ToList());
            rtxtDescripcion.Text = semanas[0].descripcion;
            rtxtTema.Text = semanas[0].nombre;
            rtxtDescripcion.Enabled = false;
            rtxtTema.Enabled = false;
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
            rtxtDescripcion.Enabled = true;
            rtxtTema.Enabled = true;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            SemanaWS.semana semana = new SemanaWS.semana();
            semana.id = semanas[0].id;
            semana.nombre = rtxtTema.Text;
            semana.descripcion = rtxtDescripcion.Text;
            semana.curso = new SemanaWS.curso();
            int resultado = daoSemana.modificarSemana(semana);

            rtxtDescripcion.Enabled = false;
            rtxtTema.Enabled = false;
        }
    }
}
