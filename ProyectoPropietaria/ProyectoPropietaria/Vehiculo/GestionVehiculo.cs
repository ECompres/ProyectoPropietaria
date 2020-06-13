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
    public partial class GestionVehiculo : Form
    {
        VEHICULO model = new VEHICULO();
        public GestionVehiculo()
        {
            InitializeComponent();
        }


        private void GestionVehiculo_FormClosed(object sender, FormClosedEventArgs e)
        {
            formularioVehiculo frm = new formularioVehiculo();
            frm.Show();
        }

        private void GestionVehiculo_Load(object sender, EventArgs e)
        {
            lblFechaValor.Text = DateTime.Today.ToString().Replace(" 12:00:00 a. m.","");
            getVehiculos();
            comboBoxes();
        }
        private void getVehiculos()
        {
            dgwVehiculos.AutoGenerateColumns = false;
            using (RentaCarEntities db = new RentaCarEntities())
            {
                var data = db.VEHICULO.Select(x => new
                {
                    x.ID,
                    x.DESCRIPCION,
                    x.NUMERO_CHASIS,
                    x.NUMERO_MOTOR,
                    x.NUMERO_PLACA,
                    TIPOVEHICULO = x.TIPO_VEHICULO.NOMBRE,
                    MODELO = x.MODELO_VEHICULO.NOMBRE,
                    COMBUSTIBLE = x.COMBUSTIBLE_VEHICULO.NOMBRE,
                    ESTADO = x.ESTADO == true ? "Disponible" : "No disponible",
                    x.FECHA_CREACION
                }).ToList();
                dgwVehiculos.DataSource = data;
            }
        }
        private void Limpiar() {
            txtDescripcion.Text = "";
            txtNumeroChasis.Text = "";
            txtNumeroMotor.Text = "";
            cbEstado.Checked = false;
            btnBorrar.Enabled = false;
            model.ID = 0;
        }
        //Traer el valor de los ID de cada uno de los comboBoxes
        private void comboBoxes()
        {
            using (RentaCarEntities db = new RentaCarEntities())
            {
                //Datos de Tipos de vehiculos
                cmbTipoVehiculo.DataSource = db.TIPO_VEHICULO.Where(x => x.ESTADO == true).ToList();
                cmbTipoVehiculo.DisplayMember = "NOMBRE";
                cmbTipoVehiculo.ValueMember = "ID";


                //Datos Modelo Vehiculo
                cmbModeloVehiculo.DataSource = db.MODELO_VEHICULO.Where(x => x.ESTADO == true)
                    .Select(x=>new
                    {
                        x.ID,
                        NOMBRE = x.MARCA_VEHICULO.NOMBRE + " - " + x.NOMBRE
                    }).ToList();
                cmbModeloVehiculo.DisplayMember = "NOMBRE";
                cmbModeloVehiculo.ValueMember = "ID";

                //Datos Combustible
                cmbCombustible.DataSource = db.COMBUSTIBLE_VEHICULO.Where(x => x.ESTADO == true).ToList();
                cmbCombustible.DisplayMember = "NOMBRE";
                cmbCombustible.ValueMember = "ID";
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
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

        private void btnCrear_Click(object sender, EventArgs e)
        {
            model.DESCRIPCION = txtDescripcion.Text.Trim();
            model.NUMERO_CHASIS = txtNumeroChasis.Text.Trim();
            model.NUMERO_MOTOR = txtNumeroMotor.Text.Trim();
            model.NUMERO_PLACA = txtNumeroPlaca.Text.Trim();
            model.ID_TIPO_VEHICULO = Convert.ToInt32(cmbTipoVehiculo.SelectedValue);
            model.ID_MODELO_VEHICULO = Convert.ToInt32(cmbModeloVehiculo.SelectedValue);
            model.ID_TIPO_COMBUSTIBLE = Convert.ToInt32(cmbCombustible.SelectedValue);
            model.ESTADO = Convert.ToBoolean(cbEstado.Checked);
            model.FECHA_CREACION = Convert.ToDateTime(lblFechaValor.Text);
            using (RentaCarEntities db = new RentaCarEntities())
            {
                if(model.ID == 0)
                {
                    db.VEHICULO.Add(model);
                    MessageBox.Show("Vehiculo agregado exitosamente");
                }
                else
                {
                    db.Entry(model).State = EntityState.Modified;
                    MessageBox.Show("Vehiculo modificado exitosamente");
                }
                db.SaveChanges();
            }
            getVehiculos();
            Limpiar();
        }

        private void lblFechaValor_Click(object sender, EventArgs e)
        {

        }

        private void lblFecha_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void dgwVehiculos_DoubleClick(object sender, EventArgs e)
        {
            if(dgwVehiculos.CurrentRow.Index != -1)
            {
                model.ID = Convert.ToInt32(dgwVehiculos.CurrentRow.Cells["ID"].Value);
                using (RentaCarEntities db = new RentaCarEntities())
                {
                    model = db.VEHICULO.Where(x => x.ID == model.ID).FirstOrDefault();
                    txtDescripcion.Text = model.DESCRIPCION;
                    txtNumeroChasis.Text = model.NUMERO_CHASIS;
                    txtNumeroMotor.Text = model.NUMERO_MOTOR;
                    txtNumeroPlaca.Text = model.NUMERO_PLACA;
                    cmbTipoVehiculo.SelectedValue = model.ID_TIPO_VEHICULO;
                    cmbModeloVehiculo.SelectedValue = model.ID_MODELO_VEHICULO;
                    cmbCombustible.SelectedValue = model.ID_TIPO_COMBUSTIBLE;
                    lblFechaValor.Text = model.FECHA_CREACION.ToString();
                    cbEstado.Checked = Convert.ToBoolean(model.ESTADO);
                }
                btnCrear.Text = "Actualizar";
                btnBorrar.Enabled = true;
            }
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Desea borrar este vehículo?","Mensaje",MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                using (RentaCarEntities db = new RentaCarEntities())
                {
                    var entry = db.Entry(model);
                    if(entry.State == EntityState.Detached)
                    {
                        db.VEHICULO.Attach(model);
                    }
                    db.VEHICULO.Remove(model);
                    db.SaveChanges();
                    Limpiar();
                    getVehiculos();
                }
            }
        }
    }
}