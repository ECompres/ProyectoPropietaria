using ProyectoPropietaria.Vehiculo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Versioning;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoPropietaria
{
    public partial class formularioVehiculo : Form
    {
        public EMPLEADO Empleado;
        public formularioVehiculo()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            GestionVehiculo frm = new GestionVehiculo();
            this.Hide();
            frm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var tipo = new GestionTipoVehiculo();
            this.Hide();
            tipo.Show();
        }

        private void formularioVehiculo_FormClosed(object sender, FormClosedEventArgs e)
        {
            Inicio frm = new Inicio();
            frm.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            GestionModeloVehiculo frm = new GestionModeloVehiculo();
            frm.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GestionMarcaVehiculo frm = new GestionMarcaVehiculo();
            frm.Show();
            this.Hide();
        }

        private void btnCombustible_Click(object sender, EventArgs e)
        {
            GestionCombustible frm = new GestionCombustible();
            frm.Show();
            this.Hide();
        }

        private void btnCantidadCombustible_Click(object sender, EventArgs e)
        {
            var frm = new GestionCantidadCombustible();
            this.Hide();
            frm.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            var frm = new GestionEstadoInspeccion();
            this.Hide();
            frm.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            var frm = new GestionInspeccion();
            this.Hide();
            frm.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            var frm = new RentaVehiculo();
            frm.Empleado = Empleado;
            this.Hide();
            frm.Show();
        }

        private void formularioVehiculo_Load(object sender, EventArgs e)
        {
            MessageBox.Show(""+Empleado.ID);
        }
    }
}
