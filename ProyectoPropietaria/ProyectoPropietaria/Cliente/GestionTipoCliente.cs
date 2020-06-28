using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoPropietaria.Cliente
{
    public partial class GestionTipoCliente : Form
    {
        TIPO_CLIENTE model = new TIPO_CLIENTE();
        public GestionTipoCliente()
        {
            InitializeComponent();
        }

        private void GestionTipoCliente_Load(object sender, EventArgs e)
        {
            Limpiar();
            getTipoClientes();
        }

        private void getTipoClientes()
        {
            dgvTiposClientes.AutoGenerateColumns = false;
            using (RentaCarEntities db = new RentaCarEntities())
            {
                var data = db.TIPO_CLIENTE.Select(x => new
                {
                    x.ID,
                    x.DESCRIPCION

                }).ToList();
                dgvTiposClientes.DataSource = data;
            }
        }
        private void Limpiar()
        {
            txtTipoCliente.Text = "";
            btnCrear.Text = "Crear";
            btnBorrar.Enabled = false;
            model.ID = 0;
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            if(txtTipoCliente.Text != "")
            {
                model.DESCRIPCION = txtTipoCliente.Text.Trim();
                using (RentaCarEntities db = new RentaCarEntities())
                {
                    if(model.ID == 0)
                    {
                        db.TIPO_CLIENTE.Add(model);
                        MessageBox.Show("Tipo de cliente agregado");
                    }
                    else
                    {
                        db.Entry(model).State = EntityState.Modified;
                        MessageBox.Show("Tipo de cliente modificado");
                    }
                    db.SaveChanges();
                    getTipoClientes();
                    Limpiar();
                }
            }
        }

        private void dgvTiposClientes_DoubleClick(object sender, EventArgs e)
        {
            if(dgvTiposClientes.CurrentRow.Index != -1)
            {
                model.ID = Convert.ToInt32(dgvTiposClientes.CurrentRow.Cells["ID"].Value);
                using (RentaCarEntities db = new RentaCarEntities())
                {
                    model = db.TIPO_CLIENTE.Where(x => x.ID == model.ID).FirstOrDefault();
                    txtTipoCliente.Text = model.DESCRIPCION;
                }
                btnCrear.Text = "Actualizar";
                btnBorrar.Enabled = true;
            }
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Desea borrar este tipo de cliente?", "Mensaje", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                using (RentaCarEntities db = new RentaCarEntities())
                {
                    var entry = db.Entry(model);
                    if (entry.State == EntityState.Detached)
                    {
                        db.TIPO_CLIENTE.Attach(model);
                    }
                    db.TIPO_CLIENTE.Remove(model);
                    db.SaveChanges();
                    MessageBox.Show("Tipo de cliente eliminado");
                    Limpiar();
                    getTipoClientes();
                }
            }
        }

        private void GestionTipoCliente_FormClosed(object sender, FormClosedEventArgs e)
        {
         
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtTipoCliente_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
            }
        }
    }
}
