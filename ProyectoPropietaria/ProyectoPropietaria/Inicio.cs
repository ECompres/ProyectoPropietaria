using ProyectoPropietaria.Cliente;
using ProyectoPropietaria.Empleado;
using ProyectoPropietaria.Vehiculo;
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
        public EMPLEADO EMPLEADO = null;
        public Inicio()
        {
            InitializeComponent();
        }
        private void Inicio_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        private void button1_Click(object sender, EventArgs e)
        {
          
        }

        private void button2_Click(object sender, EventArgs e)
        {
          
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }

        private void Inicio_Load(object sender, EventArgs e)
        {
            CustomizeDesign();
        }
        private void CustomizeDesign()
        {
            panelClientes.Visible = false;
            panelVehiculos.Visible = false;
            panelEmpleado.Visible = false;
        }
        private void hideSubMenu()
        {
            if(panelClientes.Visible == true)
                panelClientes.Visible = false;
            if (panelEmpleado.Visible == true)
                panelEmpleado.Visible = false;
            if (panelVehiculos.Visible == true)
                panelVehiculos.Visible = false;
        }
        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            showSubMenu(panelVehiculos);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {

        }

        private void button14_Click(object sender, EventArgs e)
        {
            openChildForm(new GestionTipoEmpleado());
            hideSubMenu();

        }

        private void btnEmpleados_Click(object sender, EventArgs e)
        {
            showSubMenu(panelEmpleado);
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            showSubMenu(panelClientes);
        }

        private void btnGestionTipoVehiculo_Click(object sender, EventArgs e)
        {
            openChildForm(new GestionTipoVehiculo());
            hideSubMenu();

        }

        private void btnGestionMarcaVehiculo_Click(object sender, EventArgs e)
        {
            openChildForm(new GestionMarcaVehiculo());
            hideSubMenu();

        }

        private void btnGestionModeloVehiculo_Click(object sender, EventArgs e)
        {
            openChildForm(new GestionModeloVehiculo());
            hideSubMenu();

        }

        private void btnGestionVehiculo_Click(object sender, EventArgs e)
        {
            openChildForm(new GestionVehiculo());
            hideSubMenu();

        }

        private void btnCantidadCombustible_Click(object sender, EventArgs e)
        {
            openChildForm(new GestionCantidadCombustible());

            hideSubMenu();

        }

        private void btnGestionCombustibles_Click(object sender, EventArgs e)
        {
            openChildForm(new GestionCombustible());
            hideSubMenu();

        }

        private void btnRentasVehiculo_Click(object sender, EventArgs e)
        {

            openChildForm(new RentaVehiculo(EMPLEADO));
            hideSubMenu();

        }

        private void btnGestionTanda_Click(object sender, EventArgs e)
        {
            openChildForm(new GestionTanda());
            hideSubMenu();

        }

        private void btnGestionEmpleados_Click(object sender, EventArgs e)
        {
            openChildForm(new GestionEmpleado());
            hideSubMenu();

        }

        private void btnGestionTipoClientes_Click(object sender, EventArgs e)
        {
            openChildForm(new GestionTipoCliente());

            hideSubMenu();

        }

        private void btnGestionClientes_Click(object sender, EventArgs e)
        {
            openChildForm(new GestionCliente());
            hideSubMenu();

        }
        private Form activeForm = null;
        private void openChildForm(Form childForm)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelChildForm.Controls.Add(childForm);
            panelChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void panelSideMenu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label4.Text = DateTime.Now.ToLongTimeString();
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            var frm = new Login();
            this.Hide();
            frm.Show();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            label4.Text = DateTime.Now.ToLongTimeString();

        }
    }
}
