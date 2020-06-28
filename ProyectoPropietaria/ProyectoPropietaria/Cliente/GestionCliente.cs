using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoPropietaria.Cliente
{
    public partial class GestionCliente : Form
    {
        CLIENTE model = new CLIENTE();
        public GestionCliente()
        {
            InitializeComponent();
        }

        private void GestionCliente_Load(object sender, EventArgs e)
        {
            getClientes();
            getTipoCliente();
            lblFechaHoy.Text = DateTime.Today.ToString().Replace(" 12:00:00 a. m.", "");
            Limpiar();
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            
            if(cedulaValidate())
            {
                model.NOMBRES = txtNombres.Text;
                model.APELLIDOS = txtApellidos.Text;
                model.CEDULA = txtCedula.Text;
                model.TELEFONO = txtTelefono.Text;
                model.EMAIL = txtEmail.Text;
                model.TARJETA_CREDITO = txtTarjetaCredito.Text;
                model.LIMITE_CREDITO = numericLimiteCredito.Value;
                model.ID_TIPO_CLIENTE = Convert.ToInt32(cmbTipoCliente.SelectedValue);
                model.ESTADO = Convert.ToBoolean(cbEstado.Checked);
                model.FECHA_CREACION = Convert.ToDateTime(lblFechaHoy.Text);

                using (RentaCarEntities db = new RentaCarEntities())
                {
                    if (model.ID == 0)
                    {
                        db.CLIENTE.Add(model);
                        MessageBox.Show("Cliente agregado");
                    }
                    else
                    {
                        db.Entry(model).State = EntityState.Modified;
                        MessageBox.Show("Cliente actualizado");
                    }
                    db.SaveChanges();
                    getClientes();
                    Limpiar();
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string Preg = (model.ESTADO == true) ? "Desea desactivar a este cliente?" : "Desea activar a este cliente?";
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
                getClientes();
            }
        }

        private void dgvClientes_DoubleClick(object sender, EventArgs e)
        {
            if (dgvClientes.CurrentRow.Index != 1)
            {
                model.ID = Convert.ToInt32(dgvClientes.CurrentRow.Cells["ID"].Value);
                using (RentaCarEntities db = new RentaCarEntities())
                {
                    model = db.CLIENTE.Where(x => x.ID == model.ID).FirstOrDefault();
                    txtNombres.Text = model.NOMBRES;
                    txtApellidos.Text = model.APELLIDOS;
                    txtCedula.Text = Convert.ToString(model.CEDULA);
                    txtEmail.Text = model.EMAIL;
                    txtTelefono.Text = model.TELEFONO;
                    txtTarjetaCredito.Text = Convert.ToString(model.TARJETA_CREDITO);
                    numericLimiteCredito.Value = model.LIMITE_CREDITO;
                    cmbTipoCliente.SelectedValue = model.ID_TIPO_CLIENTE;
                    cbEstado.Checked = Convert.ToBoolean(model.ESTADO);
                    lblFechaHoy.Text = model.FECHA_CREACION.ToString();
                }
                if(cbEstado.Checked == true)
                {
                    button2.Text = "Desactivar";
                }
                else
                {
                    button2.Text = "Activar";
                }
                btnCrear.Text = "Actualizar";
                button2.Enabled = true;
            }
        }
        private void getClientes()
        {
            dgvClientes.AutoGenerateColumns = false;
            using (RentaCarEntities db = new RentaCarEntities())
            {
                var data = db.CLIENTE.Select(x => new
                {
                    x.ID,
                    x.NOMBRES,
                    x.APELLIDOS,
                    x.CEDULA,
                    x.EMAIL,
                    x.TELEFONO,
                    x.TARJETA_CREDITO,
                    x.LIMITE_CREDITO,
                    TIPO_CLIENTE = x.TIPO_CLIENTE.DESCRIPCION,
                    ESTADO = x.ESTADO == true ? "Disponible" : "No disponible",
                    x.FECHA_CREACION
                }).ToList();
                dgvClientes.DataSource = data;
            }
            
        }
        private bool cedulaValidate()
        {
            if (string.IsNullOrWhiteSpace(txtNombres.Text) ||
                string.IsNullOrWhiteSpace(txtApellidos.Text) ||
                string.IsNullOrWhiteSpace(txtEmail.Text) ||
                string.IsNullOrWhiteSpace(txtCedula.Text) ||
                string.IsNullOrWhiteSpace(txtTelefono.Text) ||
                string.IsNullOrWhiteSpace(txtTarjetaCredito.Text) ||
                cmbTipoCliente.SelectedIndex == -1 ||
                numericLimiteCredito.Value == 0)
            {
                MessageBox.Show("Rellene todos los campos");
                return false;
            }
            if (txtTarjetaCredito.TextLength != 16)
            {
                MessageBox.Show("Por favor ingrese una tarjeta de crédito válida");
                return false;
            }
            if (txtTelefono.TextLength != 10)
            {
                MessageBox.Show("Por favor ingrese un teléfono válido");
                return false;
            }
            if (IsValidDrCedula(txtCedula.Text) == false || txtCedula.TextLength != 11)
            {
                MessageBox.Show("Por favor ingrese una cédula válida");
                return false;
            }
            if (model.ID == 0) { 
            using (RentaCarEntities db = new RentaCarEntities())
            {
                var cliente = db.CLIENTE.Where(x => x.CEDULA == txtCedula.Text).Count();
                if (cliente>0)
                {
                    MessageBox.Show("Ya existe un cliente con esta cedula");
                    return false;
                }
            }
            }
            return true;
        }
        private void getTipoCliente()
        {
            using (RentaCarEntities db = new RentaCarEntities())
            {
                cmbTipoCliente.DataSource = db.TIPO_CLIENTE.ToList();
                cmbTipoCliente.DisplayMember = "DESCRIPCION";
                cmbTipoCliente.ValueMember = "ID";
            }
        }
        private void Limpiar()
        {
            txtNombres.Text = "";
            txtApellidos.Text = "";
            txtCedula.Text = "";
            txtEmail.Text = "";
            model.ID = 0;
            txtTarjetaCredito.Text = "";
            btnCrear.Text = "Crear";
            txtTelefono.Text = "";
            numericLimiteCredito.Value = 0;
            cbEstado.Checked = false;
            button2.Enabled = false;

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

        private void dgvClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void GestionCliente_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            if (textBox1.Text.Length > 0)
            {
                using (RentaCarEntities db = new RentaCarEntities())
                {
                    var items = db.CLIENTE
                        .Where(x =>
                            x.NOMBRES.Contains(textBox1.Text.Trim()) ||
                            x.APELLIDOS.Contains(textBox1.Text.Trim()) ||
                            x.CEDULA.Contains(textBox1.Text.Trim()) ||
                            x.EMAIL.Contains(textBox1.Text.Trim()) ||
                            x.TELEFONO.Contains(textBox1.Text.Trim())).Select(
                        x => new
                        {
                            x.ID,
                            x.NOMBRES,
                            x.APELLIDOS,
                            x.CEDULA,
                            x.EMAIL,
                            x.TELEFONO,
                            x.TARJETA_CREDITO,
                            x.LIMITE_CREDITO,
                            TIPO_CLIENTE = x.TIPO_CLIENTE.DESCRIPCION,
                            ESTADO = x.ESTADO == true ? "Disponible" : "No disponible",
                            x.FECHA_CREACION
                        })
                        .ToList();
                   dgvClientes.DataSource = items;
                }
            }
            else
            {
                getClientes();
            }
        }

        private void txtTarjetaCredito_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtCedula_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtNombres_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {                
                e.Handled = true;
            }
        }

        private void txtApellidos_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
           {
                e.Handled = true;
            }
        }

        private void txtEmail_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public static bool IsValidDrCedula(string drCedula)
        {
            // Valid format?
            if (drCedula.Equals(null))
            {
                return false;
            }
            else
            {
                drCedula = Regex.Replace(drCedula, "[^0-9]", string.Empty); // Only keep #s.
                if (drCedula.Equals(null) || !drCedula.Length.Equals(11) || long.Parse(drCedula).Equals(0))
                {
                    return false;
                }
            }

            // Validate.
            int sum = 0;
            for (int i = 0; i < 10; ++i)
            {
                int n = ((i + 1) % 2 != 0 ? 1 : 2) * int.Parse(drCedula.Substring(i, 1));
                sum += (n <= 9 ? n : n % 10 + 1);
            }
            int dig = ((10 - sum % 10) % 10);
            return (dig.Equals(int.Parse(drCedula.Substring(10, 1))) ? true : false);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }
    }
}
