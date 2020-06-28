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
    public partial class GestionModeloVehiculo : Form
    {
        MODELO_VEHICULO model = new MODELO_VEHICULO();
        public GestionModeloVehiculo()
        {
            InitializeComponent();
        }

       
        private void GestionModeloVehiculo_Load(object sender, EventArgs e)
        {
            getMarcaVehiculos();
            getModelos();
        }

        private void GestionModeloVehiculo_FormClosed(object sender, FormClosedEventArgs e)
        {
      

        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            if (cmbMarca.SelectedIndex != -1 || !string.IsNullOrWhiteSpace(txtModelo.Text)){ 
            model.ID_MARCA_VEHICULO = int.Parse(cmbMarca.SelectedValue.ToString());
            model.NOMBRE = txtModelo.Text;
            model.ESTADO = cbEstado.Checked;
            
            using (RentaCarEntities  db = new RentaCarEntities ()) {
                
                if(model.ID == 0)
                {
                    db.MODELO_VEHICULO.Add(model);
                    MessageBox.Show("Modelo de la marca agregado");
                }
                else
                {
                    db.Entry(model).State = EntityState.Modified;
                    MessageBox.Show("Modelo de la marca modificado");

                }
                db.SaveChanges();
            }
            Limpiar();
            getModelos();
            }
            else
            {
                MessageBox.Show("Rellene los campos");
            }
        }
  
        private void cmbMarca_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void Limpiar()
        {
            txtModelo.Text = "";
            cbEstado.Checked = true;
            model.ID = 0;
            btnBorrar.Enabled = false;
            btnCrear.Text = "Crear";
            cmbMarca.Text = "";
        }
        private void getMarcaVehiculos()
        {

            using (RentaCarEntities  db = new RentaCarEntities ())
            {
                cmbMarca.DataSource = db.MARCA_VEHICULO.Where(x => x.ESTADO == true).ToList();
                cmbMarca.DisplayMember = "NOMBRE";
                cmbMarca.ValueMember = "ID";
            }
        }
        private void getModelos()
        {
            dgwModeloVehiculo.AutoGenerateColumns = false;
            using (RentaCarEntities  db = new RentaCarEntities ())
            {
                
                var data = db.MODELO_VEHICULO.Select(x => new
                {
                    x.ID,
                    MARCA = x.MARCA_VEHICULO.NOMBRE,
                    x.NOMBRE,
                    ESTADO = x.ESTADO == true ? "Disponible" : "No disponible"
                        
                }).ToList();
                dgwModeloVehiculo.DataSource = data;
            }
        }

        private void dgwModeloVehiculo_DoubleClick(object sender, EventArgs e)
        {
            if(dgwModeloVehiculo.CurrentRow.Index != -1)
            {
                model.ID = Convert.ToInt32(dgwModeloVehiculo.CurrentRow.Cells["ID"].Value);
                using (RentaCarEntities  db = new RentaCarEntities ())
                {
                    model = db.MODELO_VEHICULO.Where(x => x.ID == model.ID).FirstOrDefault();
                    cmbMarca.SelectedValue = Convert.ToInt32(model.ID_MARCA_VEHICULO);
                    txtModelo.Text = model.NOMBRE;
                    cbEstado.Checked = Convert.ToBoolean(model.ESTADO);
                }
                btnCrear.Text = "Actualizar";
                btnBorrar.Enabled = true;

            }
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Desea borrar este modelo de vehículo?", "Mensaje", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                using (RentaCarEntities db = new RentaCarEntities())
                {
                    var entry = db.Entry(model);
                    if(entry.State == EntityState.Detached)
                    {
                        db.MODELO_VEHICULO.Attach(model);
                    }
                    db.MODELO_VEHICULO.Remove(model);
                    db.SaveChanges();
                    MessageBox.Show("Modelo de vehículo eliminado");
                    getModelos();
                    Limpiar();
                }
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtModelo_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtModelo_KeyPress(object sender, KeyPressEventArgs e)
        {

        }
    }
}
