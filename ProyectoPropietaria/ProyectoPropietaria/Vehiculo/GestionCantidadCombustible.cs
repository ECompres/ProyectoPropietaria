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
    public partial class GestionCantidadCombustible : Form
    {
        CANTIDAD_COMBUSTIBLE model = new CANTIDAD_COMBUSTIBLE();
        public GestionCantidadCombustible()
        {
            InitializeComponent();
        }

        private void GestionCantidadCombustible_Load(object sender, EventArgs e)
        {
            getCantidades();
            Limpiar();
        }

        private void cbEstado_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            model.DESCRIPCION = txtCantidadCombustible.Text;
            using (RentaCarEntities db = new RentaCarEntities())
            {
                if(model.ID == 0)
                {
                    db.CANTIDAD_COMBUSTIBLE.Add(model);
                }
                else
                {
                    db.Entry(model).State = EntityState.Modified;
                }
                db.SaveChanges();
                getCantidades();
                Limpiar();
            }
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Desea borrar esta cantidad de combustible?", "Mensaje", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                using (RentaCarEntities db = new RentaCarEntities())
                {
                    var entry = db.Entry(model);
                    if(entry.State == EntityState.Detached)
                    {
                        db.CANTIDAD_COMBUSTIBLE.Attach(model);
                    }
                    db.CANTIDAD_COMBUSTIBLE.Remove(model);
                    db.SaveChanges();
                    MessageBox.Show("Cantidad eliminada");
                    Limpiar();
                    getCantidades();
                }
            }
        }
        private void getCantidades()
        {
            dgwCantidadCombustible.AutoGenerateColumns = false;
            using (RentaCarEntities db = new RentaCarEntities())
            {
                var data = db.CANTIDAD_COMBUSTIBLE.Select(x => new
                {
                    x.ID,
                    x.DESCRIPCION,
                }).ToList();
                dgwCantidadCombustible.DataSource = data;
            }
        }
        private void Limpiar()
        {
            txtCantidadCombustible.Text = "";
            
            model.ID = 0;
            btnCrear.Text = "Crear";
            btnBorrar.Enabled = false;
        }

        private void dgwCantidadCombustible_DoubleClick(object sender, EventArgs e)
        {
            if(dgwCantidadCombustible.CurrentRow.Index != -1)
            {
                model.ID = Convert.ToInt32(dgwCantidadCombustible.CurrentRow.Cells["ID"].Value);
                using (RentaCarEntities db = new RentaCarEntities())
                {
                    model = db.CANTIDAD_COMBUSTIBLE.Where(x => x.ID == model.ID).FirstOrDefault();
                    txtCantidadCombustible.Text = model.DESCRIPCION;
                }
                btnCrear.Text = "Actualizar";
                btnBorrar.Enabled = true;
            }
        }

        private void GestionCantidadCombustible_FormClosed(object sender, FormClosedEventArgs e)
        {
   
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
