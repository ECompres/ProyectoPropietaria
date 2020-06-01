using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoPropietaria
{
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
        }

        private void btnGestionEmpleado_Click(object sender, EventArgs e)
        {
            this.Hide();
            GestionEmpleado frm = new GestionEmpleado();
            frm.Show();
        }

        private void btnGestionVehiculo_Click(object sender, EventArgs e)
        {
            this.Hide();
            GestionVehiculo frm = new GestionVehiculo();
            frm.Show();
        }

        private void btnTipoVehiculo_Click(object sender, EventArgs e)
        {
            this.Hide();
            GestionTipoVehiculo frm = new GestionTipoVehiculo();
            frm.Show();
        }

        private void Inicio_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
