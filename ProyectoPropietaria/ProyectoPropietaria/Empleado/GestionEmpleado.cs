using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Net.Configuration;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoPropietaria
{
    public partial class GestionEmpleado : Form
    {
        EMPLEADO model = new EMPLEADO();
        public GestionEmpleado()
        {
            InitializeComponent();
        }

        private void GestionEmpleado_FormClosed(object sender, FormClosedEventArgs e)
        {
        
        }

        private void GestionEmpleado_Load(object sender, EventArgs e)
        {
            getEmpleados();
            cmbBoxes();
            lblFechaHoy.Text = DateTime.Today.ToString().Replace(" 12:00:00 a. m.", "");
            button2.Enabled = false;
        }
        public bool ValidarData()
        {
            if (string.IsNullOrWhiteSpace(txtNombres.Text) ||
                string.IsNullOrWhiteSpace(txtApellidos.Text) ||
                string.IsNullOrWhiteSpace(txtEmail.Text) ||
                string.IsNullOrWhiteSpace(txtClave.Text) ||
                cmbTanda.SelectedIndex == -1 ||
                numericComision.Value == 0 ||
                cmbTipoEmpleado.SelectedIndex == -1)
            {
                MessageBox.Show("Ingrese datos validos");
                return false;
            }
            if (model.ID == 0)
            {
                using (RentaCarEntities db = new RentaCarEntities())
                {
                    var cliente = db.EMPLEADO.Where(x => x.EMAIL == txtEmail.Text).Count();
                    if (cliente > 0)
                    {
                        MessageBox.Show("Ya existe un empleado con este Email");
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


                model.NOMBRES = txtNombres.Text;
                model.APELLIDOS = txtApellidos.Text;
                model.EMAIL = txtEmail.Text;
                model.CLAVE = txtClave.Text;
                model.ID_TANDA = Convert.ToInt32(cmbTanda.SelectedValue);
                model.PORCIENTO_COMISION = Convert.ToInt32(numericComision.Value);
                model.FECHA_INGRESO = datePicker.Value;
                model.FECHA_CREACION = Convert.ToDateTime(lblFechaHoy.Text);
                model.ID_TIPO_EMPLEADO = Convert.ToInt32(cmbTipoEmpleado.SelectedValue);
                model.ESTADO = cbEstado.Checked;
                using (RentaCarEntities db = new RentaCarEntities())
                {
                    if (model.ID == 0)
                    {
                        db.EMPLEADO.Add(model);
                        MessageBox.Show("Empleado agregado");
                    }
                    else
                    {
                        db.Entry(model).State = EntityState.Modified;
                        MessageBox.Show("Empleado actualizado");
                    }
                    db.SaveChanges();
                    getEmpleados();
                    Limpiar();
                }
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            string Preg = (model.ESTADO == true) ? "Desea desactivar a este Empleado?" : "Desea activar a este Empleado?";
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
                getEmpleados();
            }
        }

        private void dgvClientes_DoubleClick(object sender, EventArgs e)
        {
        }
        private void getEmpleados()
        {
            dgvEmpleado.AutoGenerateColumns = false;
            using (RentaCarEntities db = new RentaCarEntities())
            {
                var data = db.EMPLEADO.Select(x => new
                {
                    x.ID,
                    x.NOMBRES,
                    x.APELLIDOS,
                    x.EMAIL,
                    x.CLAVE,
                    TANDA = x.TANDA.DESCRIPCION,
                    x.PORCIENTO_COMISION,
                    x.FECHA_INGRESO,
                    x.FECHA_CREACION,
                    TIPO_EMPLEADO = x.TIPO_EMPLEADO.DESCRIPCION,
                    ESTADO = x.ESTADO == true ? "Disponible" : "No disponible"
                }).ToList();
                dgvEmpleado.DataSource = data;
            }
        }
        private void cmbBoxes()
        {
            using (RentaCarEntities db = new RentaCarEntities())
            {
                cmbTanda.DataSource = db.TANDA.Where(x=>x.ESTADO ==true).ToList();
                cmbTanda.DisplayMember = "DESCRIPCION";
                cmbTanda.ValueMember = "ID";

                cmbTipoEmpleado.DataSource = db.TIPO_EMPLEADO.ToList();
                cmbTipoEmpleado.DisplayMember = "DESCRIPCION";
                cmbTipoEmpleado.ValueMember = "ID";
            }
        }
        private void Limpiar()
        {
            txtNombres.Text = "";
            txtApellidos.Text = "";
            txtEmail.Text = "";
            txtClave.Text = "";
            model.ID = 0;
            btnCrear.Text = "Crear";
            numericComision.Value = 0;
            button2.Enabled = false;
        }

        private void dgvEmpleado_DoubleClick(object sender, EventArgs e)
        {
            if (dgvEmpleado.CurrentRow.Index != -1)
            {

                model.ID = Convert.ToInt32(dgvEmpleado.CurrentRow.Cells["ID"].Value);
                using (RentaCarEntities db = new RentaCarEntities())
                {
                    model = db.EMPLEADO.Where(x => x.ID == model.ID).FirstOrDefault();
                    txtNombres.Text = model.NOMBRES;
                    txtApellidos.Text = model.APELLIDOS;
                    txtEmail.Text = model.EMAIL;
                    txtClave.Text = model.CLAVE;
                    cmbTanda.SelectedValue = Convert.ToInt32(model.ID_TANDA);
                    numericComision.Value = model.PORCIENTO_COMISION;
                    lblFechaHoy.Text = model.FECHA_CREACION.ToString();
                }
                button2.Enabled = true;
                btnCrear.Text = "Actualizar";
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
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
    }
}
