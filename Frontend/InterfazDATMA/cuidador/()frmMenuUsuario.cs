﻿using InterfazDATMA.plantilla;
using MaterialSkin.Controls;
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
    public partial class frmMenuUsuario : MaterialSkin.Controls.MaterialForm 
    {
        private ImageList walkthrough = new ImageList();
        private frmPlantillaGestion plantillaGestion;
        private frmWalkthrough formAnterior;
        public frmMenuUsuario(frmWalkthrough formAnt,frmPlantillaGestion plantilla)
        {
            InitializeComponent();
            MaterialSkin.MaterialSkinManager skinManager = MaterialSkin.MaterialSkinManager.Instance;
            skinManager.AddFormToManage(this);
            skinManager.Theme = MaterialSkin.MaterialSkinManager.Themes.DARK;
            skinManager.ColorScheme = new MaterialSkin.ColorScheme(MaterialSkin.Primary.BlueGrey500, MaterialSkin.Primary.BlueGrey700, MaterialSkin.Primary.BlueGrey100, MaterialSkin.Accent.Teal700, MaterialSkin.TextShade.WHITE);

            this.plantillaGestion = plantilla;
            this.formAnterior = formAnt;
        }

        private bool verificarCursosDisponibles()
        {
            Random rd = new Random();
            if (rd.Next(2) == 1) return true;
            else return false;
        }

        private void btnCursosDisponibles_Click_1(object sender, EventArgs e)
        {/*
            bool hayCursos = verificarCursosDisponibles();
            Form formularioMostrar;
            if (hayCursos) formularioMostrar = new frmCursosDisponibles(this, plantillaGestion);
            else formularioMostrar = new frmSinCursosDisponibles(this, plantillaGestion);

            formularioMostrar.Show();
            this.Hide();*/
        }
    }
}
