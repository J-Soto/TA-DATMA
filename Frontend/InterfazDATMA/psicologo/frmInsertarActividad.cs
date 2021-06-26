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

namespace InterfazDATMA.psicologo
{
    public partial class frmInsertarActividad : MaterialSkin.Controls.MaterialForm
    {

        private frmModificarPrograma formModificarPrograma;
        private frmPlantillaGestion formPlantillaGestion;

        private ActividadWS.actividad actividad;
        private ActividadWS.ActividadWSClient daoActividad;

        private int idSemana;

        public frmInsertarActividad(frmModificarPrograma formModificarPrograma, frmPlantillaGestion formPlantillaGestion, int idSemana)
        {
            InitializeComponent();

            this.formModificarPrograma = formModificarPrograma;
            this.formPlantillaGestion = formPlantillaGestion;

            this.idSemana = idSemana;

            dtpHInicio.CustomFormat = "hh:mm tt";
            dtpHInicio.Format = DateTimePickerFormat.Custom;
            dtpHInicio.ShowUpDown = true;

            dtpHFin.CustomFormat = "hh:mm tt";
            dtpHFin.Format = DateTimePickerFormat.Custom;
            dtpHFin.ShowUpDown = true;

            dtpFechaReunion.CustomFormat = "dd/MM/yyyy";
            dtpFechaReunion.Format = DateTimePickerFormat.Custom;

            actividad = new ActividadWS.actividad();
            daoActividad = new ActividadWS.ActividadWSClient();

        }




        private void btnRegresar_Click(object sender, EventArgs e)
        {
            formPlantillaGestion.abrirFormulario(formModificarPrograma);
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

            actividad.nombre = txtNombreAct.Text;
            actividad.fecha = dtpFechaReunion.Value;
            actividad.fechaSpecified = true;
            
            //CAMBIAR A STRING
            //
            //actividad.horaInicio = new ActividadWS.localTime();
            //actividad.horaFin = new ActividadWS.localTime();
            //
            

            actividad.linkZoom = txtLinkZoom.Text;


            //int resultado = daoActividad.insertarActividad(actividad, idSemana);
            //MessageBox.Show(resultado.ToString());
            //if (resultado != 0)
            //{
            //    MessageBox.Show("Se ha guardado con exito","Mensaje de Confimacion",MessageBoxButtons.OK,MessageBoxIcon.Information);

            //    txtNombreAct.Text = "";
            //    dtpFechaReunion.Value = DateTime.Now;
            //    dtpHInicio.Value = DateTime.Now;
            //    dtpHFin.Value = DateTime.Now;
            //    txtLinkZoom.Text = "";
            //}


        }


    }
}
