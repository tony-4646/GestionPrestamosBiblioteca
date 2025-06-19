using System;
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
    public partial class FrmIngreso : Form
    {
        public FrmIngreso()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            this.Hide();
            var FrmPrograma = new Vistas.FrmPrograma();
            FrmPrograma.Show();
        }

        private void FrmIngreso_Load(object sender, EventArgs e)
        {

        }

    }
}
