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

namespace ProyectoPropietaria.Vehiculo
{
    public partial class GestionCombustible : Form
    {
        COMBUSTIBLE_VEHICULO model = new COMBUSTIBLE_VEHICULO();
        public GestionCombustible()
        {
            InitializeComponent();
        }

        private void GestionCombustible_Load(object sender, EventArgs e)
        {
            getCombustibles();
            Limpiar();
        }
        private void cbEstado_CheckedChanged(object sender, EventArgs e)
        {
            
            if (cbEstado.Checked)
            {
                cbEstado.Text = "Disponible";
            }
            else
            {
                cbEstado.Text = "No disponible";

            }
        }
        private void getCombustibles()
        {
            dgwCombustible.AutoGenerateColumns = false;
            using (RentaCarEntities db = new RentaCarEntities())
            {
                var data = db.COMBUSTIBLE_VEHICULO.Select(x => new
                {
                    x.ID,
                    x.NOMBRE,
                    ESTADO = x.ESTADO == true ? "Disponible" : "No disponible"
                }).ToList();
                dgwCombustible.DataSource = data;
            }
        }
        private void Limpiar()
        {
            txtCombustible.Text = "";
            cbEstado.Checked = false;
            btnCrear.Text = "Crear";
            btnBorrar.Enabled = false;
            model.ID = 0;
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            if(txtCombustible.Text != "") { 
            model.NOMBRE = txtCombustible.Text.Trim();
            model.ESTADO = cbEstado.Checked;

            using (RentaCarEntities db = new RentaCarEntities())
            {
                if (model.ID == 0)
                {
                    db.COMBUSTIBLE_VEHICULO.Add(model);
                    MessageBox.Show("El combustible ha sido agregado");
                }
                else
                {
                    db.Entry(model).State = EntityState.Modified;
                    MessageBox.Show("El combustible ha sido modificado");
                }
                db.SaveChanges();
            }
            Limpiar();
            getCombustibles();
            }
            else
            {
                MessageBox.Show("Rellene los campos");
            }
        }

        private void dgwCombustible_DoubleClick(object sender, EventArgs e)
        {
            if(dgwCombustible.CurrentRow.Index != -1)
            {
                model.ID = Convert.ToInt32(dgwCombustible.CurrentRow.Cells["ID"].Value);
                using (RentaCarEntities db = new RentaCarEntities())
                {
                    model = db.COMBUSTIBLE_VEHICULO.Where(x => x.ID == model.ID).FirstOrDefault();
                    txtCombustible.Text = model.NOMBRE;
                    cbEstado.Checked = Convert.ToBoolean(model.ESTADO);
                }
                btnCrear.Text = "Actualizar";
                btnBorrar.Enabled = true;
            }
        }

        private void GestionCombustible_FormClosed(object sender, FormClosedEventArgs e)
        {
            formularioVehiculo frm = new formularioVehiculo();
            frm.Show();
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("¿Desea borrar este tipo de combustible?","Mensaje",MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                using (RentaCarEntities db = new RentaCarEntities())
                {
                    var entry = db.Entry(model);
                    if(entry.State == EntityState.Detached)
                    {
                        db.COMBUSTIBLE_VEHICULO.Attach(model);
                    }
                    db.COMBUSTIBLE_VEHICULO.Remove(model);
                    db.SaveChanges();
                    MessageBox.Show("Tipo de combustible eliminado");
                    Limpiar();
                    getCombustibles();
                }
            }
        }
    }
}
