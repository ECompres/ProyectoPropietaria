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
    public partial class GestionInspeccion : Form
    {
        INSPECCION model = new INSPECCION();
        public GestionInspeccion()
        {
            InitializeComponent();
        }

        private void GestionInspeccion_Load(object sender, EventArgs e)
        {
            lblFechaValor.Text = DateTime.Today.ToString().Replace(" 12:00:00 a. m.", "");
            cmbBox();
            Limpiar();
            getInspecciones();
        }

        private void cbRayaduras_CheckedChanged(object sender, EventArgs e)
        {
            if(cbRayaduras.Checked == true)
            {
                cbRayaduras.Text = "Si";
            }
            else
            {
                cbRayaduras.Text = "No";
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                checkBox1.Text = "Si";
            }
            else
            {
                checkBox1.Text = "No";
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked == true)
            {
                checkBox2.Text = "Si";
            }
            else
            {
                checkBox2.Text = "No";
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked == true)
            {
                checkBox3.Text = "Si";
            }
            else
            {
                checkBox3.Text = "No";
            }
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            //model.ID_VEHICULO = Convert.ToInt32(cmbVehiculo.SelectedValue);
            //model.ID_CLIENTE = Convert.ToInt32(cmbCliente.SelectedValue);
            //model.ID_EMPLEADO = Convert.ToInt32(cmbEmpleado.SelectedValue);
            //model.TIENE_RAYADURAS = cbRayaduras.Checked;
            //model.ID_CANTIDAD_COMBUSTIBLE = Convert.ToInt32(cmbCantidadCombustible.SelectedValue);
            //model.TIENE_GOMA = checkBox1.Checked;
            //model.TIENE_GATO = checkBox2.Checked;
            //model.TIENE_RAYADURAS = checkBox3.Checked;
            //model.FECHA_CREACION = Convert.ToDateTime(lblFechaValor.Text);
            //model.ID_ESTADO_INSPECCION = Convert.ToInt32(cmbEstadoInspeccion.SelectedValue);
            using (RentaCarEntities db = new RentaCarEntities())
            {
                if (model.ID == 0)
                {
                    db.INSPECCION.Add(model);
                    MessageBox.Show("Inspección agregada");
                }
                else
                {
                    db.Entry(model).State = EntityState.Modified;
                    MessageBox.Show("Inspección modificada");
                }
                db.SaveChanges();
                getInspecciones();
                Limpiar();
            }
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Desea borrar esta inspección?", "Mensaje", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                using (RentaCarEntities db = new RentaCarEntities())
                {
                    var entry = db.Entry(model);
                    if (entry.State == EntityState.Detached)
                    {
                        db.INSPECCION.Attach(model);
                    }
                    db.INSPECCION.Remove(model);
                    db.SaveChanges();
                    Limpiar();
                    getInspecciones();
                }
            }
        }
        private void dgvInspeccion_DoubleClick(object sender, EventArgs e)
        {
            if(dgvInspeccion.CurrentRow.Index != -1)
            {
                model.ID = Convert.ToInt32(dgvInspeccion.CurrentRow.Cells["ID"].Value);
                using (RentaCarEntities db = new RentaCarEntities())
                {
                    //model = db.INSPECCION.Where(x => x.ID == model.ID).FirstOrDefault();
                    //cmbCliente.SelectedValue = model.ID_CLIENTE;
                    //cmbVehiculo.SelectedValue = model.ID_VEHICULO;
                    //cmbEmpleado.SelectedValue = model.ID_EMPLEADO;
                    //cmbCantidadCombustible.SelectedValue = model.ID_CANTIDAD_COMBUSTIBLE;
                    //cbRayaduras.Checked = Convert.ToBoolean(model.TIENE_RAYADURAS);
                    //checkBox1.Checked = Convert.ToBoolean(model.TIENE_GOMA);
                    //checkBox2.Checked = Convert.ToBoolean(model.TIENE_GATO);
                    //checkBox3.Checked = Convert.ToBoolean(model.TIENE_ROTURA_CRISTAL);
                    //lblFechaValor.Text = model.FECHA_CREACION.ToString();
                    //cmbEstadoInspeccion.SelectedValue = model.ID_ESTADO_INSPECCION;
                }
                btnCrear.Text = "Actualizar";
                btnBorrar.Enabled = true;
            }
        }
        private void cmbBox()
        {
            using (RentaCarEntities db = new RentaCarEntities())
            {

                //Cliente
                cmbCliente.DataSource = db.CLIENTE.Join(db.RENTA,
                    c => c.ID,
                    r => r.ID_CLIENTE,
                    (c, r) => new
                    {
                        CLIENTE = c,
                        RENTA = r
                    }).Where(rr => rr.CLIENTE.ID == rr.RENTA.ID_CLIENTE).Select(x => new
                    {
                        x.CLIENTE.ID,
                        NOMBRES = x.CLIENTE.NOMBRES + " " + x.CLIENTE.APELLIDOS
                    }).ToList();
                cmbCliente.DisplayMember = "NOMBRES";
                cmbCliente.ValueMember = "ID";

                //Vehiculo


                //Empleado
                cmbEmpleado.DataSource = db.EMPLEADO.Where(x => x.ESTADO == true).Select(x => new
                {
                    x.ID,
                    NOMBRE = x.NOMBRES + " " + x.APELLIDOS
                }).ToList();
                cmbEmpleado.DisplayMember = "NOMBRE";
                cmbEmpleado.ValueMember = "ID";

                //Estado inspeccion
                //cmbEstadoInspeccion.DataSource = db.ESTADO_INSPECCION.Select(x=>new { 
                //    x.ID,
                //    NOMBRE = x.DESCRIPCION
                //}).ToList();
                //cmbEstadoInspeccion.DisplayMember = "NOMBRE";
                //cmbEstadoInspeccion.ValueMember = "ID";

                //Cantidad combustible
                //cmbCantidadCombustible.DataSource = db.CANTIDAD_COMBUSTIBLE.Where(x => x.ESTADO == true).Select(x => new
                //{
                //    x.ID,
                //    NOMBRE = x.DESCRIPCION
                //}).ToList();
                //cmbCantidadCombustible.DisplayMember = "NOMBRE";
                //cmbCantidadCombustible.ValueMember = "ID";

            }
        }
        private void getInspecciones()
        {
            dgvInspeccion.AutoGenerateColumns = false;
            //using (RentaCarEntities db = new RentaCarEntities())
            //{
            //    var data = db.INSPECCION.Select(x => new
            //    {
            //        x.ID,
            //        VEHICULO = x.VEHICULO.MODELO_VEHICULO.MARCA_VEHICULO.NOMBRE + " - " + x.VEHICULO.MODELO_VEHICULO.NOMBRE,
            //        CLIENTE = x.CLIENTE.NOMBRES + " " + x.CLIENTE.APELLIDOS,
            //        EMPLEADO = x.EMPLEADO.NOMBRES + " " + x.EMPLEADO.APELLIDOS,
            //        TIENE_RAYADURAS = x.TIENE_RAYADURAS == true ? "Si" : "No",
            //        COMBUSTIBLE = x.CANTIDAD_COMBUSTIBLE.DESCRIPCION,
            //        TIENE_GOMA = x.TIENE_GOMA == true ? "Si":"No",
            //        TIENE_GATO = x.TIENE_GATO == true ? "Si" : "No",
            //        TIENE_ROTURA_CRISTAL = x.TIENE_ROTURA_CRISTAL == true ? "Si" : "No",
            //        x.FECHA_CREACION,
            //        ESTADO_INSPECCION = x.ESTADO_INSPECCION.DESCRIPCION
            //    }).ToList();
                //dgvInspeccion.DataSource = data;
            }
        

        private void GestionInspeccion_FormClosed(object sender, FormClosedEventArgs e)
        {
            var frm = new formularioVehiculo();
            frm.Show();
        }
        

        private void cmbCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
         
            
        }

        private void lblNumeroChasis_Click(object sender, EventArgs e)
        {

        }

        private void lblDescripcion_Click(object sender, EventArgs e)
        {

        }

        private void cmbCliente_SelectedValueChanged(object sender, EventArgs e)
        {
            using (RentaCarEntities db = new RentaCarEntities())
            {
                int fid;
                bool parseOK = Int32.TryParse(cmbCliente.SelectedValue.ToString(), out fid);
                cmbVehiculo.DataSource = db.VEHICULO.Join(db.RENTA,
                    v => v.ID,
                    r => r.ID_VEHICULO,
                    (v, r) => new { v, r })
                    .Join(db.CLIENTE,
                    rc => rc.r.ID_CLIENTE,
                    c => c.ID,
                    (rc, c) => new { rc, c }).Where(x => x.rc.r.ID_CLIENTE == fid).Select(x => new
                    {
                        ID = x.rc.v.ID,
                        NOMBRE = x.rc.v.MODELO_VEHICULO.MARCA_VEHICULO.NOMBRE + " - " + x.rc.v.MODELO_VEHICULO.NOMBRE
                    }).ToList();
                cmbVehiculo.DisplayMember = "NOMBRE";
                cmbVehiculo.ValueMember = "ID";

            }
        }
        private void Limpiar()
        {
            cbRayaduras.Checked = false;
            checkBox1.Checked = false;
            checkBox2.Checked = false;
            checkBox3.Checked = false;
            btnBorrar.Enabled = false;
            model.ID = 0;
            btnCrear.Text = "Crear";
        }
    }
}
