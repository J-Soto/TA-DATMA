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

        public frmListaCuidadoresDePsicologo(frmConfigurarModuloPsicologo formConfigurarModulo, frmPlantillaGestion formPlantillaGestion)
        {
            InitializeComponent();
            Design.Ini(this);
            daoTutor = new TutorWS.TutorWSClient();
            dgvModulos.AutoGenerateColumns = false;
            this.formConfigurarModulo = formConfigurarModulo;
            this.formPlantillaGestion = formPlantillaGestion;

            if (daoTutor.listarTodosTutores() != null)
            {
                dgvModulos.DataSource = new BindingList<TutorWS.tutor>(daoTutor.listarTodosTutores().ToList());
            }
        }


        private void frmListaCuidadoresDePsicologo_Load(object sender, EventArgs e)
        {

        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
          
        }

        private void btnRegresarCurso_Click(object sender, EventArgs e)
        {
           
        }

        private void label2_Click(object sender, EventArgs e)
        {
           
        }

        private void dgvModulos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnRegresarCurso_Click_1(object sender, EventArgs e)
        {
            formPlantillaGestion.abrirFormulario(formConfigurarModulo);
        }
    }
}
