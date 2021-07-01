using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using InterfazDATMA.Administrador;
using InterfazDATMA.util;

using MaterialSkin;
using MaterialSkin.Controls;

namespace InterfazDATMA.plantilla
{
    public partial class Bienvenida : MaterialSkin.Controls.MaterialForm
    {
        public frmPlantillaGestion plantillaGestion;
        public Bienvenida(frmPlantillaGestion plantillaGestion)
        {
            this.plantillaGestion = plantillaGestion;
            InitializeComponent();
            Design.Ini(this);
            Mensaje();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            if (plantillaGestion.tipoUser == 1) plantillaGestion.abrirFormulario(new frmGestionarModulosPsicologo(plantillaGestion));
            else if (plantillaGestion.tipoUser == 2) plantillaGestion.abrirFormulario(new frmGestionarModuloAdmin(plantillaGestion));
            else plantillaGestion.abrirFormulario(new frmWalkthrough(plantillaGestion));
        }
        private void Mensaje()
        {
            if (plantillaGestion.tipoUser == 1)
            {
                mensaje.Text = "Bienvenido al software oficial de DATMA Psicologo " + plantillaGestion.nombre + " " + plantillaGestion.apP + " " + plantillaGestion.apM;
                mensaje.Font = new Font("Century Gothic", 20);
                plantillaGestion.abrirFormulario(new frmGestionarModulosPsicologo(plantillaGestion));
            }
            else if (plantillaGestion.tipoUser == 2)
            {
                mensaje.Text = "Bienvenido al software oficial de DATMA Administrador ";
                mensaje.Font = new Font("Century Gothic", 20);
                plantillaGestion.abrirFormulario(new frmGestionarModuloAdmin(plantillaGestion));

            }
            else
            {
                mensaje.Text = "Bienvenido al software oficial de DATMA Tutor " + plantillaGestion.nombre + " " + plantillaGestion.apP + " " + plantillaGestion.apM;
                mensaje.Font = new Font("Century Gothic", 20);
                plantillaGestion.abrirFormulario(new frmWalkthrough(plantillaGestion));
            }
        }
    }
}
