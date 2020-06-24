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
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string usuario = txtUsuario.Text;
            string password = txtPassword.Text;
            using (RentaCarEntities db = new RentaCarEntities())
            {
                var empleado = db.EMPLEADO.Where(x => x.EMAIL == usuario).FirstOrDefault();
                if(empleado != null)
                {
                    if(empleado.CLAVE == password)
                    {
                        
                        Inicio frm = new Inicio();
                        frm.Empleado = empleado;
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

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
