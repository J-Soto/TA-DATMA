using MaterialSkin.Controls;
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
    public partial class frmModificarPrograma : MaterialSkin.Controls.MaterialForm 
    {
        private frmConfigurarModuloPsicologo formConfigurarModuloPsicologo;
        private frmPlantillaGestion formPlantillaGestion;

        private SemanaWS.SemanaWSClient daoSemana;
        private CursoWS.CursoWSClient daoCurso;
        private int idCurso;

        //Semana:
        private SemanaWS.semana currentSemana;

        public frmModificarPrograma(frmConfigurarModuloPsicologo formConfigurarModuloPsicologo, frmPlantillaGestion formPlantillaGestion, GrupoWS.grupo auxGrupo, SemanaWS.semana auxSemana, CursoWS.curso auxCurso, string nombreTema)
        {
            InitializeComponent();
            MaterialSkin.MaterialSkinManager skinManager = MaterialSkin.MaterialSkinManager.Instance;
            skinManager.AddFormToManage(this);
            skinManager.Theme = MaterialSkin.MaterialSkinManager.Themes.DARK;
            skinManager.ColorScheme = new MaterialSkin.ColorScheme(MaterialSkin.Primary.BlueGrey500, MaterialSkin.Primary.BlueGrey700, MaterialSkin.Primary.BlueGrey100, MaterialSkin.Accent.Teal700, MaterialSkin.TextShade.WHITE);

            this.formConfigurarModuloPsicologo = formConfigurarModuloPsicologo;
            this.formPlantillaGestion = formPlantillaGestion;
            //this.idCurso = idCurso;

            currentSemana = auxSemana;

            daoSemana = new SemanaWS.SemanaWSClient();
            daoCurso = new CursoWS.CursoWSClient();

            //this.semanas = new BindingList<CursoWS.semana>(
            //    daoCurso.listarSemanasPorIdCurso(idCurso).ToList());

            //Inicializar Pantalla
            rtxtDescripcion.Text = currentSemana.descripcion;
            rtxtTema.Text = currentSemana.nombre;
            lblTema.Text = "Tema: " + nombreTema;

            //Limitar edicion:
            rtxtTema.ReadOnly = true;
            rtxtDescripcion.ReadOnly = true;
            //rtxtDescripcion.Enabled = false;
            //rtxtTema.Enabled = false;

            
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
            rtxtTema.ReadOnly = false;
            rtxtDescripcion.ReadOnly = false;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            currentSemana.nombre = rtxtTema.Text;
            currentSemana.descripcion = rtxtDescripcion.Text;
            currentSemana.curso = new SemanaWS.curso();
            int resultado = daoSemana.modificarSemana(currentSemana);

            rtxtDescripcion.ReadOnly = true;
            rtxtTema.ReadOnly = true;

            formConfigurarModuloPsicologo.refrescarDataGridView(currentSemana);
        }

        private void dgvReuniones_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
