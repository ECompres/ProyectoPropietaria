using NReco.PdfGenerator;
using RazorEngine;
using RazorEngine.Templating;
using System;
using System.Data;
using System.Data.Entity;
using System.IO;
using System.Linq;
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
                    MODELO = x.MODELO_VEHICULO.MARCA_VEHICULO.NOMBRE + " - " + x.MODELO_VEHICULO.NOMBRE,
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
        public bool ValidarData()
        {
            if (string.IsNullOrWhiteSpace(txtDescripcion.Text) || string.IsNullOrWhiteSpace(txtNumeroChasis.Text) || string.IsNullOrWhiteSpace(txtNumeroMotor.Text) || string.IsNullOrWhiteSpace(txtNumeroPlaca.Text) || cmbTipoVehiculo.SelectedIndex == -1 || cmbModeloVehiculo.SelectedIndex == -1 || cmbCombustible.SelectedIndex == -1)
            {
                MessageBox.Show("Debe rellenar correctamente todos los campos");
                return false;
            }
            if (model.ID == 0)
            {
                using (RentaCarEntities db = new RentaCarEntities())
                {
                    var cliente = db.VEHICULO.Where(x => x.NUMERO_CHASIS == txtNumeroChasis.Text).Count();
                    var cliente2 = db.VEHICULO.Where(x => x.NUMERO_MOTOR == txtNumeroMotor.Text).Count();
                    var cliente3 = db.VEHICULO.Where(x => x.NUMERO_PLACA == txtNumeroPlaca.Text).Count();
                    if (cliente > 0)
                    {
                        MessageBox.Show("Ya existe un vehiculo con este numero de Chasis");
                        return false;
                    }
                    else if (cliente2 > 0)
                    {
                        MessageBox.Show("Ya existe un vehiculo con este numero de motor");
                        return false;
                    }
                    else if (cliente3 > 0)
                    {
                        MessageBox.Show("Ya existe un vehiculo con este numero de placa");
                        return false;
                    }
                }
            }
            return true;

        }
        private void btnCrear_Click(object sender, EventArgs e)
        {
            if(ValidarData())
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
                if (cbEstado.Checked == true)
                {
                    btnBorrar.Text = "Desactivar";
                }
                else
                {
                    btnBorrar.Text = "Activar";
                }
                btnCrear.Text = "Actualizar";
                btnBorrar.Enabled = true;
            }
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            string Preg = (model.ESTADO == true) ? "Desea desactivar a este vehiculo?" : "Desea activar a este vehiculo?";
            if (MessageBox.Show(Preg, "Mensaje", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                model.ESTADO = !model.ESTADO;
                using (RentaCarEntities db = new RentaCarEntities())
                {
                    db.Entry(model).State = EntityState.Modified;
                    MessageBox.Show("Estado modificado");
                    db.SaveChanges();
                }
                Limpiar();
                getVehiculos();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtNumeroChasis_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text.Length > 0)
            {
                using (RentaCarEntities db = new RentaCarEntities())
                {
                     
                    var items = db.VEHICULO
                        .Where(x =>
                            x.DESCRIPCION.Contains(textBox1.Text.Trim()) ||
                            x.NUMERO_CHASIS.Contains(textBox1.Text.Trim()) ||
                            x.NUMERO_MOTOR.Contains(textBox1.Text.Trim()) ||
                            x.NUMERO_PLACA.Contains(textBox1.Text.Trim()) ||
                            x.TIPO_VEHICULO.NOMBRE.Contains(textBox1.Text.Trim())||
                            x.MODELO_VEHICULO.MARCA_VEHICULO.NOMBRE.Contains(textBox1.Text.Trim()) ||
                            x.MODELO_VEHICULO.NOMBRE.Contains(textBox1.Text.Trim())
                            ).Select(
                        x => new
                        {
                            x.ID,
                            x.DESCRIPCION,
                            x.NUMERO_CHASIS,
                            x.NUMERO_MOTOR,
                            x.NUMERO_PLACA,
                            TIPOVEHICULO = x.TIPO_VEHICULO.NOMBRE,
                            MODELO = x.MODELO_VEHICULO.MARCA_VEHICULO.NOMBRE + " - " + x.MODELO_VEHICULO.NOMBRE,
                            COMBUSTIBLE = x.COMBUSTIBLE_VEHICULO.NOMBRE,
                            ESTADO = x.ESTADO == true ? "Disponible" : "No disponible",
                            x.FECHA_CREACION
                        })
                        .ToList();
                    dgwVehiculos.DataSource = items;
                }
            }
            else
            {
                getVehiculos();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (RentaCarEntities db = new RentaCarEntities())
            {

                var items = db.VEHICULO.ToList();
                var file = File.ReadAllText(AppDomain.CurrentDomain.BaseDirectory + @"Reportes\\ReportesVehiculo.cshtml");
                var html = Engine.Razor.RunCompile(file, Guid.NewGuid().ToString(), null, items, null);
                var htmlToPDF = new NReco.PdfGenerator.HtmlToPdfConverter();
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.FileName = "Vehiculos";
                saveFileDialog.DefaultExt = "pdf";
                saveFileDialog.ShowDialog();
                htmlToPDF.GeneratePdf(html, null, saveFileDialog.FileName + ".pdf");
            }
        }
    }
}