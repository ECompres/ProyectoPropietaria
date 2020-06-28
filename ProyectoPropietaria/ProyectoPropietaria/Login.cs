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
    public partial class Login : Form
    {

        EMPLEADO model = new EMPLEADO();
        public Login()
        {
            InitializeComponent();
            panel1.BackColor = Color.FromArgb(200, 0, 0, 0);
            button1.Focus();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label4.Text = DateTime.Now.ToLongTimeString();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUsuario.Text) || string.IsNullOrWhiteSpace(txtPassword.Text)||txtUsuario.Text =="Usuario"||txtPassword.Text =="Contraseña")
            {
                MessageBox.Show("Debe rellenar ambos espacio");
            }
            else { 
            string usuario = txtUsuario.Text;
            string password = txtPassword.Text;
            using (RentaCarEntities db = new RentaCarEntities())
            {
                var empleado = db.EMPLEADO.Where(x => x.EMAIL == usuario).FirstOrDefault();
                if (empleado != null)
                {
                    if (empleado.CLAVE == password)
                    {
                        button1.Text = "Iniciando sesión";
                        Inicio frm = new Inicio();
                        frm.EMPLEADO = empleado;
                        frm.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Contraseña incorrecta");
                    }
                }
                else
                {
                    MessageBox.Show("Usuario incorrecto");
                }
            }
            }
        }

        private void txtUsuario_Enter(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "Usuario")
            {
                txtUsuario.Text = "";
                txtUsuario.ForeColor = Color.Black;
            }
        }

        private void txtUsuario_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUsuario.Text))
            {
                txtUsuario.Text = "Usuario";
            }
        }

        private void txtPassword_Enter(object sender, EventArgs e)
        {
            if(txtPassword.Text == "Contraseña")
            {
                txtPassword.Text = "";
                txtPassword.ForeColor = Color.Black;
            }
        }

        private void txtPassword_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                txtPassword.Text = "Contraseña";
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
