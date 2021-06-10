﻿using System;
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
    public partial class Header : Form
    {
        private PsicologoWS.PsicologoWSClient daoPsicologo;

        public Header()
        {
            InitializeComponent();
            daoPsicologo = new PsicologoWS.PsicologoWSClient();
            dgvPsico.AutoGenerateColumns = false;
            dgvPsico.DataSource = new BindingList<PsicologoWS.PsicologoWSClient>(daoPsicologo.listarTodosPsicologos());
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            BindingList<PsicologoWS.PsicologoWSClient> psicos = new BindingList<PsicologoWS.PsicologoWSClient>(daoPsicologo.listarTodosPsicologos());
            for (int i = 0; i < psicos.Count; i++)
            {
                if (!psicos[i].nombre.Contains(txtBuscar.Text))
                {
                    psicos.RemoveAt(i);
                    i--;
                }
            }
            dgvPsico.DataSource = psicos;
        }

       
    }

}
