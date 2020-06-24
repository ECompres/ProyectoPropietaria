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

namespace ProyectoPropietaria
{
    public partial class GestionMarcaVehiculo : Form
    {
        MARCA_VEHICULO model = new MARCA_VEHICULO();
        public GestionMarcaVehiculo()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            model.NOMBRE = txtMarcaVehiculo.Text.Trim();
            model.ESTADO = cbEstado.Checked;
            using (RentaCarEntities db = new RentaCarEntities())
            {
                if (model.ID == 0)
                {
                    db.MARCA_VEHICULO.Add(model);
                    MessageBox.Show("Marca de vehículo agregada.");

                }
                else
                {
                    db.Entry(model).State = EntityState.Modified;
                    MessageBox.Show("Marca de vehículo actualizada.");

                }
                db.SaveChanges();
            }
            LimpiarCampos();
            getMarcaVehiculos();
        }
        private void LimpiarCampos()
        {
            txtMarcaVehiculo.Text = "";
            cbEstado.Checked = true;
            btnCrear.Text = "Crear";
            btnBorrar.Enabled = false;
            model.ID = 0;
        }

        private void getMarcaVehiculos()
        {
            dgwMarcaVehiculo.AutoGenerateColumns = false;
            using (RentaCarEntities db = new RentaCarEntities())
            {

                var data = db.MARCA_VEHICULO.Select(x=> new { 
                x.ID,
                x.NOMBRE,
                ESTADO = x.ESTADO == true ? "Disponible" : "No disponible"
                }).ToList();
                dgwMarcaVehiculo.DataSource = data;
            }
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

        private void GestionTipoVehiculo_Load(object sender, EventArgs e)
        {
            getMarcaVehiculos();
        }

        private void GestionTipoVehiculo_FormClosed(object sender, FormClosedEventArgs e)
        {
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("¿Desea borrar este tipo de vehículo?", "Mensaje", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                using (RentaCarEntities db = new RentaCarEntities())
                {
                    var entry = db.Entry(model);
                    if(entry.State == EntityState.Detached)
                    {
                        db.MARCA_VEHICULO.Attach(model);
                    }
                    db.MARCA_VEHICULO.Remove(model);
                    db.SaveChanges();
                    getMarcaVehiculos();
                    LimpiarCampos();
                    MessageBox.Show("Tipo de vehículo eliminado");
                }
            }
        }

        private void dgwTipoVehiculo_DoubleClick(object sender, EventArgs e)
        {
            if (dgwMarcaVehiculo.CurrentRow.Index != -1)
            {
                model.ID = Convert.ToInt32(dgwMarcaVehiculo.CurrentRow.Cells["ID"].Value);
                using (RentaCarEntities  db = new RentaCarEntities ())
                {
                    model = db.MARCA_VEHICULO.Where(x => x.ID == model.ID).FirstOrDefault();
                    txtMarcaVehiculo.Text = model.NOMBRE;
                    cbEstado.Checked = Convert.ToBoolean(model.ESTADO);
                }
                btnCrear.Text = "Actualizar";
                btnBorrar.Enabled = true;
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
