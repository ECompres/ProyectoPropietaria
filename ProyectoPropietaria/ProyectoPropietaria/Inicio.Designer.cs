namespace ProyectoPropietaria
{
    partial class Inicio
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnGestionVehiculo = new System.Windows.Forms.Button();
            this.btnTipoVehiculo = new System.Windows.Forms.Button();
            this.btnGestionEmpleado = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnGestionVehiculo
            // 
            this.btnGestionVehiculo.Location = new System.Drawing.Point(13, 12);
            this.btnGestionVehiculo.Name = "btnGestionVehiculo";
            this.btnGestionVehiculo.Size = new System.Drawing.Size(103, 23);
            this.btnGestionVehiculo.TabIndex = 0;
            this.btnGestionVehiculo.Text = "Gestion Vehículo";
            this.btnGestionVehiculo.UseVisualStyleBackColor = true;
            this.btnGestionVehiculo.Click += new System.EventHandler(this.btnGestionVehiculo_Click);
            // 
            // btnTipoVehiculo
            // 
            this.btnTipoVehiculo.Location = new System.Drawing.Point(12, 55);
            this.btnTipoVehiculo.Name = "btnTipoVehiculo";
            this.btnTipoVehiculo.Size = new System.Drawing.Size(122, 23);
            this.btnTipoVehiculo.TabIndex = 1;
            this.btnTipoVehiculo.Text = "Gestión tipo vehículo";
            this.btnTipoVehiculo.UseVisualStyleBackColor = true;
            this.btnTipoVehiculo.Click += new System.EventHandler(this.btnTipoVehiculo_Click);
            // 
            // btnGestionEmpleado
            // 
            this.btnGestionEmpleado.Location = new System.Drawing.Point(13, 108);
            this.btnGestionEmpleado.Name = "btnGestionEmpleado";
            this.btnGestionEmpleado.Size = new System.Drawing.Size(122, 23);
            this.btnGestionEmpleado.TabIndex = 2;
            this.btnGestionEmpleado.Text = "Gestión empleado";
            this.btnGestionEmpleado.UseVisualStyleBackColor = true;
            this.btnGestionEmpleado.Click += new System.EventHandler(this.btnGestionEmpleado_Click);
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 314);
            this.Controls.Add(this.btnGestionEmpleado);
            this.Controls.Add(this.btnTipoVehiculo);
            this.Controls.Add(this.btnGestionVehiculo);
            this.Name = "Inicio";
            this.Text = "Inicio";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Inicio_FormClosed);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGestionVehiculo;
        private System.Windows.Forms.Button btnTipoVehiculo;
        private System.Windows.Forms.Button btnGestionEmpleado;
    }
}