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

namespace InterfazDATMA.Administrador
{
    public partial class frmSeleccionarTemasDeCurso : MaterialSkin.Controls.MaterialForm 
    {
        //forms:
        private frmInsertarCurso formInsertarCurso;
        private frmPlantillaGestion formPlantillaGest;

        //Semanas
        private int numSemanas;
        private DateTime fechaInicialCurso;
        private DateTime fechaFinCurso;

        //Temas
        private TemaWS.TemaWSClient daoTema;
        BindingList<TemaWS.tema> temasCurso;



        public frmSeleccionarTemasDeCurso(frmInsertarCurso formInsertarCurso, frmPlantillaGestion formPlantillaGest,int cantSemanas, DateTime fechaInicial, DateTime fechaFinal, BindingList<TemaWS.tema> temas)
        {
            this.formInsertarCurso = formInsertarCurso;
            this.formPlantillaGest = formPlantillaGest;
            this.numSemanas = cantSemanas;
            this.fechaInicialCurso = fechaInicial;
            this.fechaFinCurso = fechaFinal;
            this.temasCurso = temas;

            InitializeComponent();
            MaterialSkin.MaterialSkinManager skinManager = MaterialSkin.MaterialSkinManager.Instance;
            skinManager.AddFormToManage(this);
            skinManager.Theme = MaterialSkin.MaterialSkinManager.Themes.DARK;
            skinManager.ColorScheme = new MaterialSkin.ColorScheme(MaterialSkin.Primary.BlueGrey500, MaterialSkin.Primary.BlueGrey700, MaterialSkin.Primary.BlueGrey100, MaterialSkin.Accent.Teal700, MaterialSkin.TextShade.WHITE);

            dgvTemas.AutoGenerateColumns = false;
            dgvTemas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            daoTema = new TemaWS.TemaWSClient();

            //
            dtpFechaInicial.CustomFormat = "dd/MM/yyyy";
            dtpFechaInicial.Format = DateTimePickerFormat.Custom;
            dtpFechaInicial.Enabled = false;
            dtpFechaFin.CustomFormat = "dd/MM/yyyy";
            dtpFechaFin.Format = DateTimePickerFormat.Custom;
            dtpFechaFin.Enabled = false;
            inicializarPantalla();
        }


        private void inicializarPantalla()
        {
            BindingList<int> semanas = new BindingList<int>();
            for (int i = 0; i < numSemanas; i++) semanas.Add(i+1);
            cbNumSemana.DataSource = semanas;

            BindingList<TemaWS.tema> temas = new BindingList<TemaWS.tema>(daoTema.listarTemas().ToList());
            cbTema.DataSource = temas;
            cbTema.DisplayMember = "nombre";

            //temasCurso = new BindingList<TemaWS.tema>();

            dgvTemas.DataSource = temasCurso;
        }

        private void lblTutoresUser_Click(object sender, EventArgs e)
        {

        }


        private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            int semana = (int) cbNumSemana.SelectedItem;
            int auxIni = semana-1, auxFin = semana;
            dtpFechaInicial.Value = fechaInicialCurso.AddDays(7 * auxIni);
            dtpFechaFin.Value = fechaInicialCurso.AddDays(7 * auxFin);

        }


        private void dgvTemas_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            try
            {
                TemaWS.tema auxTema = dgvTemas.Rows[e.RowIndex].DataBoundItem as TemaWS.tema;
                int auxSemana = 0;
                for (int i = 0; i < numSemanas; i++)
                {
                    auxSemana = i + 1;
                    if (auxTema.fechaInicio == fechaInicialCurso.AddDays(7 * (auxSemana - 1))) break;
                }

                dgvTemas.Rows[e.RowIndex].Cells["Semana"].Value = auxSemana.ToString();
                dgvTemas.Rows[e.RowIndex].Cells["NombreCompleto"].Value = auxTema.nombre;
                dgvTemas.Rows[e.RowIndex].Cells["FechaInicio"].Value = auxTema.fechaInicio;
                dgvTemas.Rows[e.RowIndex].Cells["FechaFin"].Value = auxTema.fechaFin;
            }
            catch (Exception ex)
            {
                
            }
        }


        private void btnCrearTema_Click_1(object sender, EventArgs e)
        {
            frmCrearTemaDeCurso formCrearTemaCurso = new frmCrearTemaDeCurso();
            if (formCrearTemaCurso.ShowDialog() == DialogResult.OK)
            {
                BindingList<TemaWS.tema> temas = new BindingList<TemaWS.tema>(daoTema.listarTemas().ToList());
                cbTema.DataSource = temas;
                cbTema.DisplayMember = "nombre";
            }

        }

        private void btnAgregarTema_Click_1(object sender, EventArgs e)
        {

            if (cbNumSemana.SelectedItem != null)
            {

                int currentSemana = (int)cbNumSemana.SelectedItem, auxSemana;
                DateTime currentFechaIni = dtpFechaInicial.Value;
                int flag = 1;

                foreach (TemaWS.tema recTema in temasCurso)
                {
                    //Bucle para saber el numero de la semana a la que pertenece la fechaInicial de un Tema
                    for (int i = 0; i < numSemanas; i++)
                    {
                        auxSemana = i + 1;
                        if (recTema.fechaInicio == fechaInicialCurso.AddDays(7 * (auxSemana - 1)))
                        {
                            if (auxSemana == currentSemana) flag = 0;
                        }
                    }

                }


                if (flag == 1)
                {
                    TemaWS.tema auxTema = new TemaWS.tema(), temaSelected;
                    temaSelected = cbTema.SelectedItem as TemaWS.tema;
                    auxTema.id = temaSelected.id;
                    auxTema.nombre = temaSelected.nombre;
                    auxTema.descripcion = temaSelected.descripcion;
                    auxTema.fechaInicio = dtpFechaInicial.Value;
                    auxTema.fechaInicioSpecified = true;
                    auxTema.fechaFin = dtpFechaFin.Value;
                    auxTema.fechaFinSpecified = true;
                    temasCurso.Add(auxTema);
                    dgvTemas.DataSource = temasCurso;
                }
                else
                {
                    MessageBox.Show("Ya se introducio el tema de la semana: " + currentSemana, "Mensaje de Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }


        }

        private void btnQuitarTema_Click_1(object sender, EventArgs e)
        {
            if (dgvTemas.RowCount != 0)
            {
                TemaWS.tema auxTema = dgvTemas.CurrentRow.DataBoundItem as TemaWS.tema;
                DateTime fechaIni;

                for (int i = 0; i < dgvTemas.RowCount; i++)
                {
                    string auxFecha = dgvTemas.Rows[i].Cells["FechaInicio"].Value.ToString();
                    fechaIni = Convert.ToDateTime(auxFecha);
                    if (auxTema.fechaInicio.Date == fechaIni.Date)
                    {
                        dgvTemas.Rows.Remove(dgvTemas.Rows[i]);
                        break;
                    }
                }
                temasCurso.Remove(auxTema);

                //Update:
                dgvTemas.DataSource = temasCurso;
            }

        }

        private void btnRegresar_Click_1(object sender, EventArgs e)
        {
            formPlantillaGest.abrirFormulario(formInsertarCurso);
        }
    }
}
