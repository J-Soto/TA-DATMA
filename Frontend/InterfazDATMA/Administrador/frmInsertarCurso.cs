using InterfazDATMA.plantilla;
using InterfazDATMA.util;
using InterfazDATMA.validacion;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin.Controls;
namespace InterfazDATMA.Administrador
{
    public partial class frmInsertarCurso : MaterialSkin.Controls.MaterialForm 
    {
        private frmPlantillaGestion formPlantillaGest;
        private frmOperacionesCursos formOperacionesCursos;
        private CursoWS.CursoWSClient daoCurso;
        private CursoWS.curso curso;

        //temas
        private BindingList<TemaWS.tema> temasCurso;

        //grupo_curso:
        private BindingList<Grupo_Curso> gruposCurso;
        private frmVerGruposCurso formVerGruposCurso;
        private GrupoWS.GrupoWSClient daoGrupo;
        private PsicologoWS.PsicologoWSClient daoPsicologo;

        //semanas:
        private SemanaWS.SemanaWSClient daoSemana;

        //requerimientos
        private BindingList<CursoWS.curso> cursosReq;

        //Current Cantidad de semanas:
        private int auxCantSem;
        private int flagChangeCantSem;

        public frmInsertarCurso(frmOperacionesCursos formOperacionesCursos, frmPlantillaGestion formPlantillaGest)
        {
            this.DoubleBuffered = true;
            this.formPlantillaGest = formPlantillaGest;
            this.formOperacionesCursos = formOperacionesCursos;

            daoCurso = new CursoWS.CursoWSClient();
            daoGrupo = new GrupoWS.GrupoWSClient();
            daoSemana = new SemanaWS.SemanaWSClient();
            daoPsicologo = new PsicologoWS.PsicologoWSClient();

            InitializeComponent();

            Design.Ini(this);
            //dgvReq.AutoGenerateColumns = false;
            //dgvReq.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            //btnModificar.Visible = false;
            btnModificar.Enabled = false;
            curso = new CursoWS.curso();
            inicializarPantalla();

            //
            dtpFechaInicial.MinDate = DateTime.Now;
            //
        }



        private void inicializarPantalla()
        {
            txtNombreCurso.Text = "";
            dtpFechaInicial.Value = DateTime.Now;
            dtpFechaInicial.CustomFormat = "dd/MM/yyyy";
            dtpFechaInicial.Format = DateTimePickerFormat.Custom;
            dtpFechaFin.Value = DateTime.Now;
            dtpFechaFin.CustomFormat = "dd/MM/yyyy";
            dtpFechaFin.Format = DateTimePickerFormat.Custom;
            dtpFechaFin.Enabled = false;
            dtpFechaInscrip.Value = DateTime.Now;
            dtpFechaInscrip.CustomFormat = "dd/MM/yyyy";
            dtpFechaInscrip.Format = DateTimePickerFormat.Custom;
            dtpFechaInscrip.Enabled = false;
            txtCantSemana.Text = "0";

            //Inicializar BindingList Temas:
            temasCurso = new BindingList<TemaWS.tema>();
            //Inicializar BindingList Grupos:
            gruposCurso = new BindingList<Grupo_Curso>();
            //Inicializar BindingList CursosRequesito:
            cursosReq = new BindingList<CursoWS.curso>();
            //dgvReq.DataSource = cursosReq;

            //Curso
            curso = new CursoWS.curso();

            //auxCantSem:
            auxCantSem = 0;
            flagChangeCantSem = 1;
        }



        private void textCantSemana_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.SoloNumeros(e);
        }

        private void textCantSemana_TextChanged(object sender, EventArgs e)
        {
            DateTime auxDate = dtpFechaInicial.Value;

            if (txtCantSemana.Text != "" && temasCurso != null)
            {
                if (temasCurso.Count == 0)
                {
                    int cantSemanas = Int32.Parse(txtCantSemana.Text);
                    auxCantSem = cantSemanas;
                    if (cantSemanas <= 100)
                    {
                        auxDate = auxDate.AddDays(cantSemanas * 7);
                        dtpFechaFin.Value = auxDate;
                    }
                    else
                    {
                        MessageBox.Show("Numero fuera de rango.", "Mensaje de Adevertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {

                    if (flagChangeCantSem == 1)
                    {
                        var resultado = MessageBox.Show("¿Desea cambiar el numero de semanas?. Se perderan los cambios realizados en los temas", "Mensaje de Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (resultado == DialogResult.Yes)
                        {
                            int cantSemanas = Int32.Parse(txtCantSemana.Text);
                            auxCantSem = cantSemanas;
                            if (cantSemanas <= 100)
                            {
                                auxDate = auxDate.AddDays(cantSemanas * 7);
                                dtpFechaFin.Value = auxDate;
                            }
                            else
                            {
                                MessageBox.Show("Numero fuera de rango.", "Mensaje de Adevertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }

                            //Al cambiar el numero de semanas se debera volver a elegir los temas de las semanas
                            if (temasCurso != null)
                                temasCurso.Clear();
                            flagChangeCantSem = 1;
                        }
                        else
                        {
                            flagChangeCantSem = 0;
                            txtCantSemana.Text = auxCantSem.ToString();
                        }

                    }
                    else
                    {
                        flagChangeCantSem = 1;
                    }
                }
            }

        }



        private void dtpFechaInicial_ValueChanged(object sender, EventArgs e)
        {
            if (temasCurso != null) temasCurso.Clear();
            if (cursosReq != null) cursosReq.Clear();

            //Update dgvRequerimientos:
            //dgvReq.Refresh();

            DateTime auxDate = dtpFechaInicial.Value;
            if (txtCantSemana.Text != "")
            {
                int cantSemanas = Int32.Parse(txtCantSemana.Text);
                auxDate = auxDate.AddDays(cantSemanas * 7);
                dtpFechaFin.Value = auxDate;
            }
            else
            {
                dtpFechaFin.Value = auxDate;
            }
            dtpFechaInscrip.Value = auxDate.AddDays(-(2 * 7));
        }

        private void btnSelaccionarTemas_Click(object sender, EventArgs e)
        {
            int cantSemanas = Int32.Parse(txtCantSemana.Text);
            DateTime fechaInicialCur = dtpFechaInicial.Value;
            DateTime fechaFinalCur = dtpFechaFin.Value;
            string auxNombreCurso = txtNombreCurso.Text;

            frmSeleccionarTemasDeCurso formSeleccionarTemaCurso = new frmSeleccionarTemasDeCurso(this, formPlantillaGest, cantSemanas, fechaInicialCur, fechaFinalCur, temasCurso, auxNombreCurso);
            formPlantillaGest.abrirFormulario(formSeleccionarTemaCurso);


        }

        private void btnVerGrupos_Click(object sender, EventArgs e)
        {
            string nombreCurso = txtNombreCurso.Text;

            formVerGruposCurso = new frmVerGruposCurso(this, formPlantillaGest, gruposCurso, nombreCurso);
            formPlantillaGest.abrirFormulario(formVerGruposCurso);

        }

        private void btnAgregarReq_Click(object sender, EventArgs e)
        {
            //DateTime auxFechaIniCur = dtpFechaInicial.Value;

            //frmBuscarCursosRequerimiento formBuscarCursoReq = new frmBuscarCursosRequerimiento(auxFechaIniCur);

            //if (formBuscarCursoReq.ShowDialog() == DialogResult.OK)
            //{
            //    if (formBuscarCursoReq.Curso_Req.idCurso != 0)
            //    {
            //        int flag = 1;
            //        foreach (CursoWS.curso recCursosReq in cursosReq)
            //        {
            //            if (formBuscarCursoReq.Curso_Req.idCurso == recCursosReq.idCurso)
            //            {
            //                flag = 0;
            //                break;
            //            }
            //        }

            //        if (flag == 1)
            //        {
            //            cursosReq.Add(formBuscarCursoReq.Curso_Req);
            //            //dgvReq.DataSource = cursosReq;
            //        }
            //        else
            //        {
            //            MessageBox.Show("Ya se registro el curso como requisito", "Mensaje de Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //        }
            //    }
            //}


        }

        private void btnEliminarReq_Click(object sender, EventArgs e)
        {
            //if (dgvReq.RowCount != 0)
            //{
            //    CursoWS.curso auxCurso = dgvReq.CurrentRow.DataBoundItem as CursoWS.curso;
            //    cursosReq.Remove(auxCurso);
            //    dgvReq.Refresh();
            //}

        }

        private void btnGuardarCurso_Click(object sender, EventArgs e)
        {
            curso.descripcion = txtNombreCurso.Text;
            curso.fechaInicio = dtpFechaInicial.Value;
            curso.fechaInicioSpecified = true;
            curso.fechaFin = dtpFechaFin.Value;
            curso.fechaFinSpecified = true;
            curso.fechaInscripcion = dtpFechaInscrip.Value;
            curso.fechaInscripcionSpecified = true;
            curso.cantSemanas = Int32.Parse(txtCantSemana.Text);

            if(gruposCurso.Count != 0)
            {
                if(temasCurso.Count == curso.cantSemanas)
                {
                    if(curso.descripcion != "" && curso.cantSemanas != 0)
                    {
                        int idCurso = daoCurso.insertarCurso(curso);
                        curso.idCurso = idCurso;
                        if (idCurso != 0)
                        {
                            int contSemanas = 0;
                            //Insertar temas
                            foreach (TemaWS.tema recTema in temasCurso)
                            {
                                recTema.fechaInicioSpecified = true;
                                recTema.fechaFinSpecified = true;
                                int idCursoTema = daoCurso.insertarCursoTema(idCurso, recTema.id, recTema.fechaInicio, recTema.fechaFin);

                                //Insertar semanas:
                                SemanaWS.semana semana = new SemanaWS.semana();
                                contSemanas++;
                                semana.nombre = "Editar nombre Semana: " + contSemanas;
                                semana.descripcion = "Editar";
                                semana.fechaInicio = recTema.fechaInicio;
                                semana.fechaInicioSpecified = true;
                                semana.curso = new SemanaWS.curso();
                                semana.curso.idCurso = idCurso;
                                daoSemana.insertarSemana(semana, idCursoTema);
                            }


                            //Insertar grupos
                            foreach (Grupo_Curso recGruposCurso in gruposCurso)
                            {
                                int idGrupo = daoGrupo.insertarGrupo(idCurso, recGruposCurso.Grupo);
                                if (idGrupo != 0)
                                {
                                    //Insertar psicologos
                                    foreach (PsicologoWS.psicologo recPsicologo in recGruposCurso.Psicologos)
                                    {
                                        daoGrupo.insertarGrupoPsicologo(recPsicologo.idPersona, idGrupo);
                                    }
                                }
                            }



                            //Insertar Requisitos:
                            //foreach (CursoWS.curso recCursoReq in cursosReq)
                            //{
                            //    daoCurso.insertarRequerimiento(idCurso, recCursoReq.idCurso, "Curso Requisito");
                            //}

                            //Insertar Psicologos_Cursos:
                            foreach (Grupo_Curso recGruposCurso in gruposCurso)
                            {
                                foreach (PsicologoWS.psicologo recPsicologo in recGruposCurso.Psicologos)
                                {
                                    daoCurso.insertarPsicologoCurso(recPsicologo.idPersona, idCurso);
                                }
                            }

                            MessageBox.Show("Se ha registrado el curso con exito.", "Mensaje de Confirmacion", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            btnGuardarCurso.Enabled = false;
                            btnModificar.Enabled = true;
                        }
                    }
                    else
                    {
                        if(curso.descripcion == "")
                        {
                            MessageBox.Show("Debe introducir un nombre al curso.", "Mensaje de advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        else if(curso.cantSemanas == 0)
                        {
                            MessageBox.Show("La cantidad de semanas no puede ser 0.", "Mensaje de advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Debe introducir los temas de cada semana del curso.", "Mensaje de advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Debe introducir un grupo como minimo.","Mensaje de advertencia",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }

        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            formPlantillaGest.abrirFormulario(formOperacionesCursos);

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (false)//verificar si algun psicologo ha hecho algun cambio
            {
                MessageBox.Show("No se puede modificar el curso, ya que las actividades de esta han sido modificadas por los psicologos",
                    "Mensaje de Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                curso.descripcion = txtNombreCurso.Text;
                curso.fechaInicio = dtpFechaInicial.Value;
                curso.fechaInicioSpecified = true;
                curso.fechaFin = dtpFechaFin.Value;
                curso.fechaFinSpecified = true;
                curso.fechaInscripcion = dtpFechaInscrip.Value;
                curso.fechaInscripcionSpecified = true;
                curso.cantSemanas = Int32.Parse(txtCantSemana.Text);

                int resultado = daoCurso.modificarCurso(curso);
                if (resultado != 0)
                {
                    int contSemanas = 0;
                    //LLena la lista de temas ya existentes en el curso
                    BindingList<CursoWS.tema> temasExistentes;
                    try
                    {
                        temasExistentes = new BindingList<CursoWS.tema>(daoCurso.listarTemasPorIdCurso(curso.idCurso).ToList());
                    }
                    catch (Exception)
                    {
                        temasExistentes = new BindingList<CursoWS.tema>();
                    }
                    //Elimina la lista de temas ya existentes en el curso
                    foreach (CursoWS.tema item in temasExistentes)
                    {
                        daoCurso.eliminarCursoTema(item.id_curso_tema);
                    }
                    //Insertar-modificar temas_curso
                    foreach (TemaWS.tema recTema in temasCurso)
                    {
                        recTema.fechaInicioSpecified = true;
                        recTema.fechaFinSpecified = true;
                        int idCursoTema = daoCurso.insertarCursoTema(curso.idCurso, recTema.id, recTema.fechaInicio, recTema.fechaFin);

                        //LLena la lista de semanas ya existentes en el curso
                        BindingList<CursoWS.semana> semanasExistentes;
                        try
                        {
                            semanasExistentes = new BindingList<CursoWS.semana>(daoCurso.listarSemanasPorIdCurso(curso.idCurso).ToList());
                        }
                        catch (Exception)
                        {
                            semanasExistentes = new BindingList<CursoWS.semana>();
                        }
                        //Elimina las semanas ya existentes
                        foreach (CursoWS.semana item in semanasExistentes)
                        {
                            daoSemana.eliminarSemana(item.id);
                        }
                        //Insertar-modificar semanas:
                        SemanaWS.semana semana = new SemanaWS.semana();
                        contSemanas++;
                        semana.nombre = "Editar nombre Semana: " + contSemanas;
                        semana.descripcion = "Editar";
                        semana.fechaInicio = recTema.fechaInicio;
                        semana.fechaInicioSpecified = true;
                        semana.curso = new SemanaWS.curso();
                        semana.curso.idCurso = curso.idCurso;
                        daoSemana.insertarSemana(semana, idCursoTema);
                    }

                    //LLena la lista de grupos ya existentes en el curso
                    BindingList<CursoWS.grupo> gruposExistentes;
                    try
                    {
                        gruposExistentes = new BindingList<CursoWS.grupo>(daoCurso.listarGruposPorIdCurso(curso.idCurso).ToList());
                    }
                    catch (Exception)
                    {
                        gruposExistentes = new BindingList<CursoWS.grupo>();
                    }
                    //Elimina los grupos existentes
                    foreach (CursoWS.grupo item in gruposExistentes)
                    {
                        daoGrupo.eliminarGrupo(item.idGrupo);
                    }
                    //Insertar grupos
                    foreach (Grupo_Curso recGruposCurso in gruposCurso)
                    {
                        int idGrupo = daoGrupo.insertarGrupo(curso.idCurso, recGruposCurso.Grupo);
                        if (idGrupo != 0)
                        {
                            //LLena la lista de psicologos ya existentes en el grupo
                            BindingList<GrupoWS.psicologo> psicologosExistentes;
                            try
                            {
                                psicologosExistentes = new BindingList<GrupoWS.psicologo>(daoGrupo.listarPsicologosPorIdGrupo(idGrupo).ToList());
                            }
                            catch (Exception)
                            {
                                psicologosExistentes = new BindingList<GrupoWS.psicologo>();
                            }
                            //Elimina la lista de psicologos ya existentes en el grupo
                            foreach (GrupoWS.psicologo item in psicologosExistentes)
                            {
                                daoGrupo.eliminarGrupoPsicologo(item.idPersona, idGrupo);
                            }
                            //Insertar psicologos
                            foreach (PsicologoWS.psicologo recPsicologo in recGruposCurso.Psicologos)
                            {
                                daoGrupo.insertarGrupoPsicologo(recPsicologo.idPersona, idGrupo);
                            }
                        }
                    }
                    /*
                    //LLena la lista de requerimientos ya existentes en el curso
                    BindingList<CursoWS.requerimiento> reqExistentes;
                    try
                    {
                        reqExistentes = new BindingList<CursoWS.requerimiento>(daoCurso.listarRequerimientoPorIdCurso(this.curso.idCurso).ToList());
                    }
                    catch (Exception)
                    {
                        reqExistentes = new BindingList<CursoWS.requerimiento>();
                    }
                    //Eliminar la lista de requerimientos ya existentes en el curso
                    foreach (CursoWS.requerimiento item in reqExistentes)
                    {
                        daoCurso.eliminarRequerimiento(this.curso.idCurso, item.idRequerimiento);
                    }
                    //Insertar Requisitos:
                    foreach (CursoWS.curso recCursoReq in cursosReq)
                    {
                        daoCurso.insertarRequerimiento(this.curso.idCurso, recCursoReq.idCurso, "Curso Requisito");
                    }
                    */
                    //LLena la lista de psicologos ya existentes en el curso
                    BindingList<PsicologoWS.psicologo> psiExistentes;
                    try
                    {
                        psiExistentes = new BindingList<PsicologoWS.psicologo>(daoPsicologo.listarPsicologosPorIdCurso(this.curso.idCurso).ToList());
                    }
                    catch (Exception)
                    {
                        psiExistentes = new BindingList<PsicologoWS.psicologo>();
                    }
                    //Eliminar lista de psicologos ya existentes
                    foreach (PsicologoWS.psicologo item in psiExistentes)
                    {
                        daoCurso.eliminarPsicologoCurso(item.idPersona, this.curso.idCurso);
                    }
                    //Insertar Psicologos_Cursos:
                    foreach (Grupo_Curso recGruposCurso in gruposCurso)
                    {
                        foreach (PsicologoWS.psicologo recPsicologo in recGruposCurso.Psicologos)
                        {
                            daoCurso.insertarPsicologoCurso(recPsicologo.idPersona, this.curso.idCurso);
                        }
                    }

                    MessageBox.Show("Se ha modificado el curso con exito", "Mensaje de Confirmacion", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    btnGuardarCurso.Enabled = false;
                    btnModificar.Enabled = true;
                    //inicializarPantalla();
                }
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            curso = new CursoWS.curso();
            inicializarPantalla();
            btnGuardarCurso.Enabled = true;
            btnModificar.Enabled = false;
        }

        private void dgvReq_CellFormatting_1(object sender, DataGridViewCellFormattingEventArgs e)
        {
            //try
            //{
            //    CursoWS.curso auxCurso = dgvReq.Rows[e.RowIndex].DataBoundItem as CursoWS.curso;

            //    dgvReq.Rows[e.RowIndex].Cells["NombreCurso"].Value = auxCurso.descripcion;
            //    dgvReq.Rows[e.RowIndex].Cells["FechaInicial"].Value = auxCurso.fechaInicio;
            //    dgvReq.Rows[e.RowIndex].Cells["FechaFinal"].Value = auxCurso.fechaFin;
            //}
            //catch (Exception ex)
            //{

            //}
        }
    }
}
