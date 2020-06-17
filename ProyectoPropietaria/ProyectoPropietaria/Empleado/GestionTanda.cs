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

namespace ProyectoPropietaria.Empleado
{
    public partial class GestionTanda : Form
    {
        TANDA model = new TANDA();
        public GestionTanda()
        {
            InitializeComponent();
        }

        private void Tanda_Load(object sender, EventArgs e)
        {
            getTandas();
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Desea borrar esta tanda?","Mensaje",MessageBoxButtons.YesNo)== DialogResult.Yes)
            {
                using (RentaCarEntities db = new RentaCarEntities())
                {
                    var entry = db.Entry(model);
                    if(entry.State == EntityState.Detached)
                    {
                        db.TANDA.Attach(model);
                    }
                    db.TANDA.Remove(model);
                    db.SaveChanges();
                    Limpiar();
                    getTandas();
                }
            }
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            model.DESCRIPCION = textBox1.Text.Trim();
            model.ESTADO = checkBox1.Checked;
            using (RentaCarEntities db = new RentaCarEntities())
            {
                if (model.ID == 0)
                {
                    db.TANDA.Add(model);
                    MessageBox.Show("Tanda Agregada");
                }
                else
                {
                    db.Entry(model).State = EntityState.Modified;
                    MessageBox.Show("Tanda modificada");
                }
                db.SaveChanges();
            }
            Limpiar();
            getTandas();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox1.Checked == true)
            {
                checkBox1.Text = "Disponible";
            }
            else
            {
                checkBox1.Text = "No disponible";
            }
        }
        private void getTandas()
        {
            dataGridView1.AutoGenerateColumns = false;
            using (RentaCarEntities db = new RentaCarEntities())
            {
                
                var data = db.TANDA.Select(x => new
                {
                    x.ID,
                    x.DESCRIPCION,
                    ESTADO = x.ESTADO == true ? "Disponible" : "No disponible"
                }).ToList();
                dataGridView1.DataSource = data;
            }
        }
        private void Limpiar()
        {
            model.ID = 0;
            textBox1.Text = "";
            checkBox1.Checked = false;
            btnBorrar.Enabled = false;
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            if(dataGridView1.CurrentRow.Index != -1)
            {
                model.ID = Convert.ToInt32(dataGridView1.CurrentRow.Cells["ID"].Value);
                using (RentaCarEntities db = new RentaCarEntities())
                {
                    model = db.TANDA.Where(x => x.ID == model.ID).FirstOrDefault();
                    textBox1.Text = model.DESCRIPCION;
                    checkBox1.Checked = Convert.ToBoolean(model.ESTADO);
                }
                btnCrear.Text = "Actualizar";
                btnBorrar.Enabled = true;
            }
        }

        private void GestionTanda_FormClosed(object sender, FormClosedEventArgs e)
        {
            var frm = new formularioEmpleado();
            frm.Show();
        }
    }
}
