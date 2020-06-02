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
                    MARCA = x.MODELO_VEHICULO.MARCA_VEHICULO.NOMBRE,
                    x.COMBUSTIBLE_VEHICULO.NOMBRE,
                    x.ESTADO,
                    x.FECHA_CREACION
                }).ToList();
            }
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

                //Datos de Marca Vehiculo
                cmbMarcaVehiculo.DataSource = db.MARCA_VEHICULO.Where(x => x.ESTADO == true).ToList();
                cmbMarcaVehiculo.DisplayMember = "NOMBRE";
                cmbMarcaVehiculo.ValueMember = "ID";

                //Datos Modelo Vehiculo
                cmbModeloVehiculo.DataSource = db.MODELO_VEHICULO.Where(x => x.ESTADO == true).ToList();
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
            if (checkBox1.Checked)
            {
                checkBox1.Text = "Disponible";
            }
            else
            {
                checkBox1.Text = "No disponible";


            }
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {

        }
    }
}