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
            var frm = new formularioEmpleado();
            frm.Show();
        }

        private void GestionEmpleado_Load(object sender, EventArgs e)
        {
            getEmpleados();
            cmbBoxes();
            lblFechaHoy.Text = DateTime.Today.ToString().Replace(" 12:00:00 a. m.", "");
            button2.Enabled = false;
        }

        private void btnCrear_Click(object sender, EventArgs e)
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
                if(model.ID == 0)
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

        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Desea borrar este cliente?", "Mensaje", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                using (RentaCarEntities db = new RentaCarEntities())
                {
                    var entry = db.Entry(model);
                    if(entry.State == EntityState.Detached)
                    {
                        db.EMPLEADO.Attach(model);
                    }
                    db.EMPLEADO.Remove(model);
                    db.SaveChanges();
                    getEmpleados();
                    Limpiar();
                }
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
    }
}
