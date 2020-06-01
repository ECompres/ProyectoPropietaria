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
    public partial class GestionEmpleado : Form
    {
        public GestionEmpleado()
        {
            InitializeComponent();
        }

        private void GestionEmpleado_FormClosed(object sender, FormClosedEventArgs e)
        {
            Inicio frm = new Inicio();
            frm.Show();
        }
    }
}
