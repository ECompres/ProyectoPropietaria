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
    public partial class RentaVehiculo : Form
    {
        public RentaVehiculo()
        {
            InitializeComponent();
        }
        RENTA model = new RENTA();
        private RENTA renta = new RENTA();
        private INSPECCION inspeccion = new INSPECCION();
        private void RentaVehiculo_Load(object sender, EventArgs e)
        {
            getRentas();
            comboBoxes();
            dpRenta.MinDate = DateTime.Now;
            Limpiar();
            dpDevolucion.MinDate = DateTime.Now;
        }

        private void rayaduras_CheckedChanged(object sender, EventArgs e)
        {
            if(rayaduras.Checked == true) {
                rayaduras.Text = "Si";
            }
            else
            {
                rayaduras.Text = "No";
            }
        }

        private void gomaRepuesto_CheckedChanged(object sender, EventArgs e)
        {
            if (gomaRepuesto.Checked == true)
            {
                gomaRepuesto.Text = "Si";
            }
            else
            {
                gomaRepuesto.Text = "No";
            }
        }

        private void gato_CheckedChanged(object sender, EventArgs e)
        {
            if (gato.Checked == true)
            {
                gato.Text = "Si";
            }
            else
            {
                gato.Text = "No";
            }
        }

        private void cristalesRotos_CheckedChanged(object sender, EventArgs e)
        {
            if (cristalesRotos.Checked == true)
            {
                cristalesRotos.Text = "Si";
            }
            else
            {
                cristalesRotos.Text = "No";
            }
        }

        private void gomaDD_CheckedChanged(object sender, EventArgs e)
        {
            if (gomaDD.Checked == true)
            {
                gomaDD.Text = "Si";
            }
            else
            {
                gomaDD.Text = "No";
            }
        }

        private void gomaDI_CheckedChanged(object sender, EventArgs e)
        {

            if (gomaDI.Checked == true)
            {
                gomaDI.Text = "Si";
            }
            else
            {
                gomaDI.Text = "No";
            }
        }

        private void gomaTD_CheckedChanged(object sender, EventArgs e)
        {

            if (gomaTD.Checked == true)
            {
                gomaTD.Text = "Si";
            }
            else
            {
                gomaTD.Text = "No";
            }
        }

        private void gomaTI_CheckedChanged(object sender, EventArgs e)
        {

            if (gomaTI.Checked == true)
            {
                gomaTI.Text = "Si";
            }
            else
            {
                gomaTI.Text = "No";
            }
        }
        private void comboBoxes()
        {
            using (RentaCarEntities db = new RentaCarEntities())
            {
                //Cantidad combustible
                cmbCantidadCombustible.DataSource = db.CANTIDAD_COMBUSTIBLE.ToList();
                cmbCantidadCombustible.DisplayMember = "DESCRIPCION";
                cmbCantidadCombustible.ValueMember = "ID";

                //Cliente
                cmbCliente.DataSource = db.CLIENTE.Where(x=>x.ESTADO == true).Select(x => new
                {
                    x.ID,
                    NOMBRE = x.NOMBRES + " " + x.APELLIDOS
                }).ToList();
                cmbCliente.DisplayMember = "NOMBRE";
                cmbCliente.ValueMember = "ID";

                //Vehiculo
                cmbVehiculo.DataSource = db.VEHICULO.Where(x => x.ESTADO == true).Select(x => new
                {
                    x.ID,
                    NOMBRE = x.MODELO_VEHICULO.MARCA_VEHICULO.NOMBRE + " - " + x.MODELO_VEHICULO.NOMBRE
                }).ToList();
                cmbVehiculo.DisplayMember = "NOMBRE";
                cmbVehiculo.ValueMember = "ID";
            }
        }
        private void cmbCantidadCombustible_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
        private string CodigoAleatorio(int tamanio=6)
        {
            const string letrasPermitidas = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            Random random = new Random();
            return new string(Enumerable.Repeat(letrasPermitidas, tamanio)
                .Select(s => s[random.Next(s.Length)]).ToArray());
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            if (validarData()) {
                using (RentaCarEntities db = new RentaCarEntities())
                {
                    if (renta.ID > 0)
                    {
                        renta.ID_CLIENTE = Convert.ToInt32(cmbCliente.SelectedValue);
                        renta.ID_VEHICULO = Convert.ToInt32(cmbVehiculo.SelectedValue);
                        renta.FECHA_RENTA = dpRenta.Value;
                        renta.FECHA_DEVOLUCION = dpDevolucion.Value;
                        renta.CANTIDAD_DIAS = Convert.ToInt32(lblDias.Text);
                        renta.MONTO_DIA = Convert.ToInt32(numericCostePorDia.Value);
                        renta.DESCRIPCION = txtDescripcion.Text;
                        renta.ESTADO = cbEstado.Checked;

                        db.Entry(renta).State = EntityState.Modified;
                        MessageBox.Show("Renta actualizada");
                    }
                    else
                    {
                        //Inspección
                        inspeccion.ID_VEHICULO = Convert.ToInt32(cmbVehiculo.SelectedValue);
                        inspeccion.CODIGO = CodigoAleatorio();
                        inspeccion.ID_CANTIDAD_COMBUSTIBLE = Convert.ToInt32(cmbCantidadCombustible.SelectedValue);
                        inspeccion.TIENE_RAYADURAS = rayaduras.Checked;
                        inspeccion.TIENE_ROTURA_CRISTAL = cristalesRotos.Checked;
                        inspeccion.TIENE_GATO = gato.Checked;
                        inspeccion.FECHA_CREACION = DateTime.Now;
                        inspeccion.GOMA_REPUESTO = gomaRepuesto.Checked;
                        inspeccion.GOMA_DELANTERA_DERECHA = gomaDD.Checked;
                        inspeccion.GOMA_DELANTERA_IZQUIERDA = gomaDI.Checked;
                        inspeccion.GOMA_TRASERA_DERECHA = gomaTD.Checked;
                        inspeccion.GOMA_TRASERA_IZQUIERDA = gomaTI.Checked;

                        db.INSPECCION.Add(inspeccion);

                        //Renta
                        renta.ID_INSPECCION = inspeccion.ID;
                        renta.ID_CLIENTE = Convert.ToInt32(cmbCliente.SelectedValue);
                        renta.ID_EMPLEADO = 2;
                        renta.ID_VEHICULO = Convert.ToInt32(cmbVehiculo.SelectedValue);
                        renta.FECHA_RENTA = dpRenta.Value;
                        renta.FECHA_DEVOLUCION = dpDevolucion.Value;
                        renta.FECHA_CREACION = DateTime.Now;
                        renta.CANTIDAD_DIAS = Convert.ToInt32(lblDias.Text);
                        renta.MONTO_DIA = Convert.ToDecimal(numericCostePorDia.Value);
                        renta.DESCRIPCION = txtDescripcion.Text;
                        renta.CODIGO = CodigoAleatorio();
                        renta.ESTADO = false;
                        db.RENTA.Add(renta);
                        MessageBox.Show("Renta agregada");
                    }
                    db.SaveChanges();
                    Limpiar();
                    getRentas();
                }
            }
        }
        private void Total()
        {
            int dias = Convert.ToInt32(lblDias.Text);
            decimal monto = Convert.ToDecimal(numericCostePorDia.Value);
            if(numericCostePorDia.Value !=0)
            {
                lblTotal.Text = Convert.ToString(dias * monto);
            }
            else
            {
                lblTotal.Text = "0.00";
            }
        }
        private void getRentas()
        {
            dgvRenta.AutoGenerateColumns = false;
            using (RentaCarEntities db = new RentaCarEntities())
            {
                var data = db.RENTA.Select(x => new
                {
                    x.ID,
                    VEHICULO = x.VEHICULO.MODELO_VEHICULO.MARCA_VEHICULO.NOMBRE + " - " + x.VEHICULO.MODELO_VEHICULO.NOMBRE,
                    CLIENTE = x.CLIENTE.NOMBRES + " " + x.CLIENTE.APELLIDOS,
                    x.CODIGO,
                    ESTADO = x.ESTADO == true ? "Entregado" : "No entregado"
                }).ToList();
                dgvRenta.DataSource = data;
            }
        }
        private void diasRenta()
        {
            DateTime diaRenta = dpRenta.Value;
            DateTime diaDevolucion = dpDevolucion.Value;

            int dias = (diaDevolucion - diaRenta).Days + 1;
            lblDias.Text = dias.ToString();
        }
        private void Limpiar()
        {
            //Inspección
            rayaduras.Checked = false;
            gomaRepuesto.Checked = false;
            gato.Checked = false;
            cristalesRotos.Checked = false;
            gomaDD.Checked = false;
            gomaDI.Checked = false;
            gomaTD.Checked = false;
            gomaTI.Checked = false;

            //Renta
            cbEstado.Checked = false;
            txtDescripcion.Text = "";
            lblDias.Text = "0";
            numericCostePorDia.Value = 0;

            //btn
            btnBorrar.Enabled = false;
            renta.ID = 0;
            inspeccion.ID = 0;
        }
        private bool validarData()
        {
            if (cmbVehiculo.SelectedIndex == -1 || cmbCliente.SelectedIndex == -1 || cmbCantidadCombustible.SelectedIndex == -1)
            {
                MessageBox.Show("Debe llenar los campos");
                return false;
            }
            if(model.ID_INSPECCION != 0)
            {
                MessageBox.Show("Debe crear inspección");
                return false;
            }
            return true;
        }

        private void RentaVehiculo_FormClosed(object sender, FormClosedEventArgs e)
        {
            var frm = new formularioVehiculo();
            frm.Show();
        }

        private void numericDias_ValueChanged(object sender, EventArgs e)
        {
            Total();
        }

        private void numericCostePorDia_ValueChanged(object sender, EventArgs e)
        {
            Total();
        }

        private void dpRenta_ValueChanged(object sender, EventArgs e)
        {
            diasRenta();
            if (dpDevolucion.Value < dpRenta.Value)
            {
                dpDevolucion.Value = dpRenta.Value;
            }
        }

        private void dpDevolucion_ValueChanged(object sender, EventArgs e)
        {
            diasRenta();
            if(dpDevolucion.Value < dpRenta.Value)
            {
                dpDevolucion.Value = dpRenta.Value;
            }
        }
    }
}
