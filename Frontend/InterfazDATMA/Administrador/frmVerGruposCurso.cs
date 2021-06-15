using InterfazDATMA.plantilla;
using InterfazDATMA.util;
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
    public partial class frmVerGruposCurso : Form
    {
        private frmInsertarCurso formInsertarCurso;
        private frmPlantillaGestion formPlantillaGest;



        /////////
        //grupos
        private GrupoWS.GrupoWSClient daoGrupo;
        private int contGrupos;

        private BindingList<Grupo_Curso> gruposCurso; //CONTENEDORES DE (GRUPO CON PSICOLOGOS Y TUTORES)
        private BindingList<GrupoWS.grupo> auxGrupos;

        //psicologos
        private BindingList<PsicologoWS.psicologo> psicologosGrupo;


        public frmVerGruposCurso(frmInsertarCurso formInsertarCurso, frmPlantillaGestion formPlantillaGest, BindingList<Grupo_Curso> grupos)
        {
            this.formInsertarCurso = formInsertarCurso;
            this.formPlantillaGest = formPlantillaGest;
            InitializeComponent();
            
            gruposCurso = grupos;

            //
            contGrupos = 0;
            //

            dgvGrupos.AutoGenerateColumns = false;
            dgvGrupos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            inicializarPantalla();
        }

        private void inicializarPantalla()
        {
            daoGrupo = new GrupoWS.GrupoWSClient();

            auxGrupos = new BindingList<GrupoWS.grupo>();
            foreach(Grupo_Curso recGrupo in gruposCurso)
            {
                auxGrupos.Add(recGrupo.Grupo);
            }

            psicologosGrupo = new BindingList<PsicologoWS.psicologo>();
            dgvGrupos.DataSource = auxGrupos;
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            formPlantillaGest.abrirFormulario(formInsertarCurso);
        }

        private void btnAgregarGrupo_Click(object sender, EventArgs e)
        {
            //Inicializar un CONTENEDOR
            Grupo_Curso grupo = new Grupo_Curso();
            //grupo.idGrupo = contGruposNew++;
            //grupo.maxCantCuidadores = 0;

            frmCrearGrupo formCrearGrupo = new frmCrearGrupo(this, formPlantillaGest, grupo);
            formPlantillaGest.abrirFormulario(formCrearGrupo);
        }

        private void dgvCursos_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            GrupoWS.grupo auxGrupo = dgvGrupos.Rows[e.RowIndex].DataBoundItem as GrupoWS.grupo;
            dgvGrupos.Rows[e.RowIndex].Cells["Nombre"].Value = auxGrupo.nombrePromocion;
            dgvGrupos.Rows[e.RowIndex].Cells["MaxTutores"].Value = auxGrupo.maxCantCuidadores;
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            
            if(dgvGrupos.RowCount != 0)
            {
                GrupoWS.grupo auxGrupo = dgvGrupos.CurrentRow.DataBoundItem as GrupoWS.grupo;
                Grupo_Curso contenedorGrupo = new Grupo_Curso();
                foreach (Grupo_Curso recGrupoCurso in gruposCurso)
                {
                    if (auxGrupo.idGrupo == recGrupoCurso.Grupo.idGrupo)
                    {
                        contenedorGrupo = recGrupoCurso;
                        break;
                    }
                }

                frmModificarGrupoCurso formModificarGrupo = new frmModificarGrupoCurso(this, formPlantillaGest, contenedorGrupo);
                formPlantillaGest.abrirFormulario(formModificarGrupo);
            }
        }
        

        public void actualizarDGV(Grupo_Curso grupo)
        {
            if (grupo.Grupo.maxCantCuidadores != 0)
            {
                grupo.Grupo.idGrupo = contGrupos++;

                gruposCurso.Add(grupo);
                //Muestro los grupos en el DGV:
                auxGrupos.Add(grupo.Grupo);
                dgvGrupos.DataSource = auxGrupos;
            }
        }

    }
}
