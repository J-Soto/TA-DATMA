using MaterialSkin.Controls;
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
    public partial class frmListaCuidadoresDePsicologo : MaterialSkin.Controls.MaterialForm 
    {
        private TutorWS.TutorWSClient daoTutor;
        private frmConfigurarModuloPsicologo formConfigurarModulo;
        private frmPlantillaGestion formPlantillaGestion;

        //Tutores:
        private GrupoWS.GrupoWSClient daoGrupo;
        private BindingList<GrupoWS.tutor> tutores;

        //Grupo:
        private int idGrupo;

        public frmListaCuidadoresDePsicologo(frmConfigurarModuloPsicologo formConfigurarModulo, frmPlantillaGestion formPlantillaGestion, int idGrupo, CursoWS.curso curso, GrupoWS.grupo grupo)
        {
            InitializeComponent();
            Design.Ini(this);
            dgvTutores.AutoGenerateColumns = false;
            this.formConfigurarModulo = formConfigurarModulo;
            this.formPlantillaGestion = formPlantillaGestion;
            this.idGrupo = idGrupo;

            lblInformacion.Text = "Curso: " + curso.descripcion + "   >   Grupo: " + grupo.nombrePromocion;

            daoGrupo = new GrupoWS.GrupoWSClient();

            inicializarPantalla();
        }

        private void inicializarPantalla()
        {
            var auxTutores = daoGrupo.listarTutoresPorIdGrupo(idGrupo);
            if (auxTutores != null)
            {
                tutores = new BindingList<GrupoWS.tutor>(auxTutores.OrderBy(x => x.nombre).ToList());
            }
            else
            {
                tutores = new BindingList<GrupoWS.tutor>();
            }
            dgvTutores.DataSource = tutores;
        }

        
        private void btnRegresar_Click(object sender, EventArgs e)
        {
            formPlantillaGestion.abrirFormulario(formConfigurarModulo);
        }

        private void dgvTutores_CellFormatting_1(object sender, DataGridViewCellFormattingEventArgs e)
        {
            GrupoWS.tutor auxTutor = dgvTutores.Rows[e.RowIndex].DataBoundItem as GrupoWS.tutor;

            dgvTutores.Rows[e.RowIndex].Cells["NombreCompleto"].Value = auxTutor.nombre + " " + auxTutor.apellidoPaterno + " " + auxTutor.apellidoMaterno;
            dgvTutores.Rows[e.RowIndex].Cells["Correo"].Value = auxTutor.correo;
            dgvTutores.Rows[e.RowIndex].Cells["Celular"].Value = auxTutor.celular;
        }
    }
}
