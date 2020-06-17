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
    public partial class GestionEstadoInspeccion : Form
    {
        ESTADO_INSPECCION model = new ESTADO_INSPECCION();
        public GestionEstadoInspeccion()
        {
            InitializeComponent();
        }

        private void GestionEstadoInspeccion_Load(object sender, EventArgs e)
        {
            getEstadosInspeccion();
            Limpiar();
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            model.DESCRIPCION = txtEstadoInspeccion.Text;
            using (RentaCarEntities db = new RentaCarEntities())
            {
                if(model.ID == 0)
                {
                    db.ESTADO_INSPECCION.Add(model);
                    MessageBox.Show("Estado de inspección agregado");
                }
                else
                {
                    db.Entry(model).State = EntityState.Modified;
                    MessageBox.Show("Estado de inspección modificado");
                }
                db.SaveChanges();
                Limpiar();
                getEstadosInspeccion();
            }
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Desea borrar este estado de inspeccion?","Mensaje",MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                using (RentaCarEntities db = new RentaCarEntities())
                {
                    var entry = db.Entry(model);
                    if(entry.State == EntityState.Detached)
                    {
                        db.ESTADO_INSPECCION.Attach(model);
                    }
                    db.ESTADO_INSPECCION.Remove(model);
                    db.SaveChanges();
                    MessageBox.Show("Estado de inspeccion eliminado");
                    Limpiar();
                    getEstadosInspeccion();
                }
            }
        }

        private void dgvGestionEstadoInspeccion_DoubleClick(object sender, EventArgs e)
        {
            if(dgvGestionEstadoInspeccion.CurrentRow.Index != -1)
            {
                model.ID = Convert.ToInt32(dgvGestionEstadoInspeccion.CurrentRow.Cells["ID"].Value);
                using (RentaCarEntities db = new RentaCarEntities())
                {
                    model = db.ESTADO_INSPECCION.Where(x => x.ID == model.ID).FirstOrDefault();
                    txtEstadoInspeccion.Text = model.DESCRIPCION;
                }
                btnBorrar.Enabled = true;
                btnCrear.Text = "Actualizar";
            }
        }
        private void getEstadosInspeccion()
        {
            dgvGestionEstadoInspeccion.AutoGenerateColumns = false;
            using (RentaCarEntities db = new RentaCarEntities())
            {
                var data = db.ESTADO_INSPECCION.Select(x => new
                {
                    x.ID,
                    x.DESCRIPCION
                }).ToList();
                dgvGestionEstadoInspeccion.DataSource = data;
            }
        }
        private void Limpiar()
        {
            model.ID = 0;
            txtEstadoInspeccion.Text = "";
            btnCrear.Text = "Crear";
            btnBorrar.Enabled = false;
        }

        private void GestionEstadoInspeccion_FormClosed(object sender, FormClosedEventArgs e)
        {
            var frm = new formularioVehiculo();
            frm.Show();
        }
    }
}
