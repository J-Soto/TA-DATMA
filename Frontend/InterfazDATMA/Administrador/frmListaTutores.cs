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
    public partial class frmListaTutores : Form
    {
        private TutorWS.TutorWSClient daoTutor;
        public frmListaTutores()
        {
            InitializeComponent();
            daoTutor = new TutorWS.TutorWSClient();
            dgvTutor.AutoGenerateColumns = false;

            if (daoTutor.listarTodosTutores() != null)
            {
                dgvTutor.DataSource = new BindingList<TutorWS.tutor>(daoTutor.listarTodosTutores().ToList());
            }
        }

        private void Header_Click(object sender, EventArgs e)
        {
            BindingList<TutorWS.tutor> tutores = new BindingList<TutorWS.tutor>(daoTutor.listarTodosTutores().ToList());
            for (int i = 0; i < tutores.Count; i++)
            {
                if (!tutores[i].nombre.Contains(txtBuscar.Text))
                {
                    tutores.RemoveAt(i);
                    i--;
                }
            }
            dgvTutor.DataSource = tutores;
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmListaTutores_Load(object sender, EventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {

        }
    }
}
