﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionPrestamosBiblioteca.Vistas
{
    public partial class FrmAyuda : Form
    {
        public FrmAyuda()
        {
            InitializeComponent();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
            var FrmPrograma = new Vistas.FrmPrograma();
            FrmPrograma.Show();
        }
    }
}
