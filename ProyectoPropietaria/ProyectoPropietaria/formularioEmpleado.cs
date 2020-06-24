using ProyectoPropietaria.Empleado;
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
    public partial class formularioEmpleado : Form
    {
        public formularioEmpleado()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var frm = new GestionTanda();
            this.Hide();
            frm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var frm = new GestionTipoEmpleado();
            this.Hide();
            frm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var frm = new GestionEmpleado();
            this.Hide();
            frm.Show();
        }

        private void formularioEmpleado_FormClosed(object sender, FormClosedEventArgs e)
        {
            var frm = new Inicio();
            frm.Show();
        }

        private void formularioEmpleado_Load(object sender, EventArgs e)
        {

        }
    }
}
