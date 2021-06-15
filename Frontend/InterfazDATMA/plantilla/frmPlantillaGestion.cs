﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using InterfazDATMA.Administrador;
using InterfazDATMA.cuidador;
using InterfazDATMA.psicologo;

namespace InterfazDATMA.plantilla
{
    public partial class frmPlantillaGestion : Form
    {
        private Form formularioActivo = null;
        private Form formInicial;
        private Form formPerfil;
        public static UsuarioWS.usuario user;

        public frmPlantillaGestion(UsuarioWS.usuario user)
        {
            InitializeComponent();
            frmPlantillaGestion.user = user;
            int tipoUser = user.tipo;
            //Psicologo
            if(tipoUser == 1)
            {
                formInicial = new frmGestionarModulosPsicologo(this);
                abrirFormulario(formInicial);
                formPerfil = new frmPerfilPsicologo();
            }
            //Administrador
            else if (tipoUser == 2)
            {
                formInicial = new frmGestionarModuloAdmin(this);
                abrirFormulario(formInicial);
                btnPerfil.Enabled = false;
            }
            //Tutor
            else if (tipoUser == 0)
            {
                formInicial = new frmWalkthrough(this);
                abrirFormulario(formInicial);
                formPerfil = new frmPerfilCuidador();
            }
        }

        public void abrirFormulario(Form formularioAbrir)
        {
            if (formularioActivo != null) formularioActivo.Hide();
            formularioActivo = formularioAbrir;

            pnlContenedor.Controls.Clear();
            formularioAbrir.TopLevel = false;
            formularioAbrir.FormBorderStyle = FormBorderStyle.None;
            formularioAbrir.Dock = DockStyle.Fill;
            pnlContenedor.Controls.Add(formularioAbrir);

            try
            {
                formularioAbrir.Show();
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            abrirFormulario(formInicial);
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnPerfil_Click(object sender, EventArgs e)
        {
            abrirFormulario(formPerfil);
        }

        private void frmPlantillaGestion_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
