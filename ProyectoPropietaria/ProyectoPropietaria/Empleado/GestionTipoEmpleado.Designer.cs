namespace ProyectoPropietaria.Empleado
{
    partial class GestionTipoEmpleado
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
            this.btnBorrar = new System.Windows.Forms.Button();
            this.btnCrear = new System.Windows.Forms.Button();
            this.dgvTipoEmpleado = new System.Windows.Forms.DataGridView();
            this.txtTipoEmpleado = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DESCRIPCION = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTipoEmpleado)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBorrar
            // 
            this.btnBorrar.Location = new System.Drawing.Point(289, 247);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(75, 23);
            this.btnBorrar.TabIndex = 25;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.UseVisualStyleBackColor = true;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // btnCrear
            // 
            this.btnCrear.Location = new System.Drawing.Point(289, 49);
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.Size = new System.Drawing.Size(75, 23);
            this.btnCrear.TabIndex = 24;
            this.btnCrear.Text = "Crear";
            this.btnCrear.UseVisualStyleBackColor = true;
            this.btnCrear.Click += new System.EventHandler(this.btnCrear_Click);
            // 
            // dgvTipoEmpleado
            // 
            this.dgvTipoEmpleado.AllowUserToAddRows = false;
            this.dgvTipoEmpleado.AllowUserToDeleteRows = false;
            this.dgvTipoEmpleado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTipoEmpleado.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.DESCRIPCION});
            this.dgvTipoEmpleado.Location = new System.Drawing.Point(12, 91);
            this.dgvTipoEmpleado.Name = "dgvTipoEmpleado";
            this.dgvTipoEmpleado.ReadOnly = true;
            this.dgvTipoEmpleado.Size = new System.Drawing.Size(352, 150);
            this.dgvTipoEmpleado.TabIndex = 23;
            this.dgvTipoEmpleado.DoubleClick += new System.EventHandler(this.dgvTipoEmpleado_DoubleClick);
            // 
            // txtTipoEmpleado
            // 
            this.txtTipoEmpleado.Location = new System.Drawing.Point(146, 49);
            this.txtTipoEmpleado.Name = "txtTipoEmpleado";
            this.txtTipoEmpleado.Size = new System.Drawing.Size(121, 20);
            this.txtTipoEmpleado.TabIndex = 22;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(8, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 20);
            this.label3.TabIndex = 21;
            this.label3.Text = "Tipo empleado:";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label1.Location = new System.Drawing.Point(83, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(199, 24);
            this.label1.TabIndex = 20;
            this.label1.Text = "Gestion tipo empleado";
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Visible = false;
            // 
            // DESCRIPCION
            // 
            this.DESCRIPCION.DataPropertyName = "DESCRIPCION";
            this.DESCRIPCION.HeaderText = "Descripcion";
            this.DESCRIPCION.Name = "DESCRIPCION";
            this.DESCRIPCION.ReadOnly = true;
            // 
            // GestionTipoEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(376, 279);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.btnCrear);
            this.Controls.Add(this.dgvTipoEmpleado);
            this.Controls.Add(this.txtTipoEmpleado);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "GestionTipoEmpleado";
            this.Text = "GestionTipoEmpleado";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.GestionTipoEmpleado_FormClosed);
            this.Load += new System.EventHandler(this.GestionTipoEmpleado_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTipoEmpleado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.Button btnCrear;
        private System.Windows.Forms.DataGridView dgvTipoEmpleado;
        private System.Windows.Forms.TextBox txtTipoEmpleado;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn DESCRIPCION;
    }
}