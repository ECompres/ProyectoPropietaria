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
    public partial class GestionTipoVehiculo : Form
    {
        TIPO_VEHICULO model = new TIPO_VEHICULO();
        public GestionTipoVehiculo()
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
            model.NOMBRE = txtTipoVehiculo.Text.Trim();
            model.ESTADO = cbEstado.Checked;
            if (string.IsNullOrWhiteSpace(txtTipoVehiculo.Text){
                MessageBox.Show("Llene los campos");
            }
            else { 
            using (RentaCarEntities  db = new RentaCarEntities ())
            {
                if (model.ID == 0)
                {
                    db.TIPO_VEHICULO.Add(model);
                    MessageBox.Show("Tipo de vehiculo agregado.");

                }
                else
                {
                    db.Entry(model).State = EntityState.Modified;
                    MessageBox.Show("Tipo de vehiculo modificado.");

                }
                db.SaveChanges();
            }
            LimpiarCampos();
            getTipoVehiculos();
        }
        }
        private void LimpiarCampos()
        {
            txtTipoVehiculo.Text = "";
            cbEstado.Checked = true;
            btnCrear.Text = "Crear";
            btnBorrar.Enabled = false;
            model.ID = 0;
        }

        private void getTipoVehiculos()
        {
            dgwTipoVehiculo.AutoGenerateColumns = false;
            using (RentaCarEntities  db = new RentaCarEntities ())
            {

                var data = db.TIPO_VEHICULO.Select(x=> new { 
                x.ID,
                x.NOMBRE,
                ESTADO = x.ESTADO == true ? "Disponible" : "No disponible"
                }).ToList();
                dgwTipoVehiculo.DataSource = data;
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
            getTipoVehiculos();
            LimpiarCampos();
        }

        private void GestionTipoVehiculo_FormClosed(object sender, FormClosedEventArgs e)
        {
    
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("¿Desea borrar este tipo de vehículo?", "Mensaje", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                using (RentaCarEntities  db = new RentaCarEntities ())
                {
                    var entry = db.Entry(model);
                    if(entry.State == EntityState.Detached)
                    {
                        db.TIPO_VEHICULO.Attach(model);
                    }
                    db.TIPO_VEHICULO.Remove(model);
                    db.SaveChanges();
                    getTipoVehiculos();
                    LimpiarCampos();
                    MessageBox.Show("Tipo de vehículo eliminado");
                }
            }
        }

        private void dgwTipoVehiculo_DoubleClick(object sender, EventArgs e)
        {
            if (dgwTipoVehiculo.CurrentRow.Index != -1)
            {
                model.ID = Convert.ToInt32(dgwTipoVehiculo.CurrentRow.Cells["ID"].Value);
                using (RentaCarEntities  db = new RentaCarEntities ())
                {
                    model = db.TIPO_VEHICULO.Where(x => x.ID == model.ID).FirstOrDefault();
                    txtTipoVehiculo.Text = model.NOMBRE;
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
