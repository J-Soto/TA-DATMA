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
        private frmConfigurarModuloPsicologo formConfigurarModulo;
        private frmPlantillaGestion formPlantillaGestion;

        //Tutores:
        private GrupoWS.GrupoWSClient daoGrupo;
        private BindingList<GrupoWS.tutor> tutores;

        //Grupo:
        private int idGrupo;

        public frmListaCuidadoresDePsicologo(frmConfigurarModuloPsicologo formConfigurarModulo, frmPlantillaGestion formPlantillaGestion, int idGrupo)
        {
            InitializeComponent();
            Design.Ini(this);
            dgvTutores.AutoGenerateColumns = false;
            this.formConfigurarModulo = formConfigurarModulo;
            this.formPlantillaGestion = formPlantillaGestion;
            this.idGrupo = idGrupo;

            daoGrupo = new GrupoWS.GrupoWSClient();

            inicializarPantalla();
        }

        private void inicializarPantalla()
        {
            var auxTutores = daoGrupo.listarTutoresPorIdGrupo(idGrupo);
            if (auxTutores != null)
            {
                tutores = new BindingList<GrupoWS.tutor>(auxTutores.ToList());
            }
            else
            {
                tutores = new BindingList<GrupoWS.tutor>();
            }
            dgvTutores.DataSource = tutores;
        }

        private void frmListaCuidadoresDePsicologo_Load(object sender, EventArgs e)
        {

        }


        private void btnRegresarCurso_Click_1(object sender, EventArgs e)
        {
            formPlantillaGestion.abrirFormulario(formConfigurarModulo);
        }

        private void dgvTutores_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            GrupoWS.tutor auxTutor = dgvTutores.Rows[e.RowIndex].DataBoundItem as GrupoWS.tutor;

            dgvTutores.Rows[e.RowIndex].Cells["NombreCompleto"].Value = auxTutor.nombre + " " +  auxTutor.apellidoPaterno + " " + auxTutor.apellidoMaterno;
            dgvTutores.Rows[e.RowIndex].Cells["Correo"].Value = auxTutor.correo;
            dgvTutores.Rows[e.RowIndex].Cells["Celular"].Value = auxTutor.celular;
            dgvTutores.Rows[e.RowIndex].Cells["Telefono"].Value = auxTutor.telefono;
        }
    }
}
