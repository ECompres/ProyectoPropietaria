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

namespace ProyectoPropietaria.Empleado
{
    public partial class GestionTipoEmpleado : Form
    {
        TIPO_EMPLEADO model = new TIPO_EMPLEADO();
        public GestionTipoEmpleado()
        {
            InitializeComponent();
        }

        private void GestionTipoEmpleado_Load(object sender, EventArgs e)
        {
            getTiposEmpleados();
        }
        private void getTiposEmpleados()
        {
            dgvTipoEmpleado.AutoGenerateColumns = false;
            using (RentaCarEntities db = new RentaCarEntities())
            {
                var data = db.TIPO_EMPLEADO.Select(x => new
                {
                    x.ID,
                    x.DESCRIPCION

                }).ToList();
                dgvTipoEmpleado.DataSource = data;
            }
        }
        private void Limpiar()
        {
            txtTipoEmpleado.Text = "";
            btnCrear.Text = "Crear";
            btnBorrar.Enabled = false;
            model.ID = 0;
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            if(txtTipoEmpleado.Text != "") {
                model.DESCRIPCION = txtTipoEmpleado.Text.Trim();
                using (RentaCarEntities db = new RentaCarEntities())
                {
                    if(model.ID == 0)
                    {
                        db.TIPO_EMPLEADO.Add(model);
                        MessageBox.Show("El tipo de empleado ha sido agregado");

                    }
                    else
                    {
                        db.Entry(model).State = EntityState.Modified;
                        MessageBox.Show("El tipo de empleado ha sido modificado");
                    }
                    db.SaveChanges();
                    getTiposEmpleados();
                    Limpiar();
                }
            }
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Desea borrar este tipo de empleado?","Mensaje",MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                using (RentaCarEntities db = new RentaCarEntities())
                {
                    var entry = db.Entry(model);
                    if(entry.State == EntityState.Detached)
                    {
                        db.TIPO_EMPLEADO.Attach(model);
                    }
                    db.TIPO_EMPLEADO.Remove(model);
                    db.SaveChanges();
                    MessageBox.Show("Tipo de empleado eliminado");
                    Limpiar();
                    getTiposEmpleados();
                }
            }
        }

        private void dgvTipoEmpleado_DoubleClick(object sender, EventArgs e)
        {
            if (dgvTipoEmpleado.CurrentRow.Index != -1)
            {
                model.ID = Convert.ToInt32(dgvTipoEmpleado.CurrentRow.Cells["ID"].Value);
                using (RentaCarEntities db = new RentaCarEntities())
                {
                    model = db.TIPO_EMPLEADO.Where(x => x.ID == model.ID).FirstOrDefault();
                    txtTipoEmpleado.Text = model.DESCRIPCION;
                }
                btnCrear.Text = "Actualizar";
                btnBorrar.Enabled = true;
            }
        }

        private void GestionTipoEmpleado_FormClosed(object sender, FormClosedEventArgs e)
        {
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtTipoEmpleado_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
            }
        }
    }
}
