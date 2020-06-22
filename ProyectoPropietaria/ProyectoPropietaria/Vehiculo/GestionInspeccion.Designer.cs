namespace ProyectoPropietaria.Vehiculo
{
    partial class GestionInspeccion
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
            this.dgvInspeccion = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.lblFechaValor = new System.Windows.Forms.Label();
            this.cmbCantidadCombustible = new System.Windows.Forms.ComboBox();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblTipoVehiculo = new System.Windows.Forms.Label();
            this.lblNumeroPlaca = new System.Windows.Forms.Label();
            this.lblNumeroMotor = new System.Windows.Forms.Label();
            this.lblNumeroChasis = new System.Windows.Forms.Label();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.cmbEmpleado = new System.Windows.Forms.ComboBox();
            this.cmbCliente = new System.Windows.Forms.ComboBox();
            this.cmbVehiculo = new System.Windows.Forms.ComboBox();
            this.cbRayaduras = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbEstadoInspeccion = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VEHICULO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CLIENTE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EMPLEADO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.COMBUSTIBLE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TIENE_RAYADURAS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TIENE_GOMA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TIENE_GATO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TIENE_ROTURA_CRISTAL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FECHA_CREACION = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ESTADO_INSPECCION = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInspeccion)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBorrar
            // 
            this.btnBorrar.Font = new System.Drawing.Font("Franklin Gothic Medium", 12.25F, System.Drawing.FontStyle.Italic);
            this.btnBorrar.Location = new System.Drawing.Point(942, 639);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(121, 30);
            this.btnBorrar.TabIndex = 46;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.UseVisualStyleBackColor = true;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // btnCrear
            // 
            this.btnCrear.Font = new System.Drawing.Font("Franklin Gothic Medium", 12.25F, System.Drawing.FontStyle.Italic);
            this.btnCrear.Location = new System.Drawing.Point(942, 271);
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.Size = new System.Drawing.Size(121, 28);
            this.btnCrear.TabIndex = 45;
            this.btnCrear.Text = "Crear";
            this.btnCrear.UseVisualStyleBackColor = true;
            this.btnCrear.Click += new System.EventHandler(this.btnCrear_Click);
            // 
            // dgvInspeccion
            // 
            this.dgvInspeccion.AllowUserToAddRows = false;
            this.dgvInspeccion.AllowUserToDeleteRows = false;
            this.dgvInspeccion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInspeccion.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.VEHICULO,
            this.CLIENTE,
            this.EMPLEADO,
            this.COMBUSTIBLE,
            this.TIENE_RAYADURAS,
            this.TIENE_GOMA,
            this.TIENE_GATO,
            this.TIENE_ROTURA_CRISTAL,
            this.FECHA_CREACION,
            this.ESTADO_INSPECCION});
            this.dgvInspeccion.Location = new System.Drawing.Point(14, 308);
            this.dgvInspeccion.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.dgvInspeccion.Name = "dgvInspeccion";
            this.dgvInspeccion.ReadOnly = true;
            this.dgvInspeccion.Size = new System.Drawing.Size(1059, 322);
            this.dgvInspeccion.TabIndex = 44;
            this.dgvInspeccion.DoubleClick += new System.EventHandler(this.dgvInspeccion_DoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Franklin Gothic Medium", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(451, 2);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 24);
            this.label1.TabIndex = 43;
            this.label1.Text = "Gestión inspección";
            // 
            // lblFechaValor
            // 
            this.lblFechaValor.AutoSize = true;
            this.lblFechaValor.Font = new System.Drawing.Font("Franklin Gothic Medium", 12.25F, System.Drawing.FontStyle.Italic);
            this.lblFechaValor.Location = new System.Drawing.Point(904, 58);
            this.lblFechaValor.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblFechaValor.Name = "lblFechaValor";
            this.lblFechaValor.Size = new System.Drawing.Size(78, 21);
            this.lblFechaValor.TabIndex = 42;
            this.lblFechaValor.Text = "fechaHoy";
            // 
            // cmbCantidadCombustible
            // 
            this.cmbCantidadCombustible.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.cmbCantidadCombustible.FormattingEnabled = true;
            this.cmbCantidadCombustible.Location = new System.Drawing.Point(200, 211);
            this.cmbCantidadCombustible.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.cmbCantidadCombustible.Name = "cmbCantidadCombustible";
            this.cmbCantidadCombustible.Size = new System.Drawing.Size(88, 28);
            this.cmbCantidadCombustible.TabIndex = 39;
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Franklin Gothic Medium", 12.25F, System.Drawing.FontStyle.Italic);
            this.lblFecha.Location = new System.Drawing.Point(744, 58);
            this.lblFecha.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(57, 21);
            this.lblFecha.TabIndex = 38;
            this.lblFecha.Text = "Fecha:";
            // 
            // lblTipoVehiculo
            // 
            this.lblTipoVehiculo.AutoSize = true;
            this.lblTipoVehiculo.Font = new System.Drawing.Font("Franklin Gothic Medium", 12.25F, System.Drawing.FontStyle.Italic);
            this.lblTipoVehiculo.Location = new System.Drawing.Point(20, 214);
            this.lblTipoVehiculo.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblTipoVehiculo.Name = "lblTipoVehiculo";
            this.lblTipoVehiculo.Size = new System.Drawing.Size(170, 21);
            this.lblTipoVehiculo.TabIndex = 30;
            this.lblTipoVehiculo.Text = "Cantidad combustible:";
            // 
            // lblNumeroPlaca
            // 
            this.lblNumeroPlaca.AutoSize = true;
            this.lblNumeroPlaca.Font = new System.Drawing.Font("Franklin Gothic Medium", 12.25F, System.Drawing.FontStyle.Italic);
            this.lblNumeroPlaca.Location = new System.Drawing.Point(439, 59);
            this.lblNumeroPlaca.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblNumeroPlaca.Name = "lblNumeroPlaca";
            this.lblNumeroPlaca.Size = new System.Drawing.Size(134, 21);
            this.lblNumeroPlaca.TabIndex = 29;
            this.lblNumeroPlaca.Text = "Tiene rayaduras?";
            // 
            // lblNumeroMotor
            // 
            this.lblNumeroMotor.AutoSize = true;
            this.lblNumeroMotor.Font = new System.Drawing.Font("Franklin Gothic Medium", 12.25F, System.Drawing.FontStyle.Italic);
            this.lblNumeroMotor.Location = new System.Drawing.Point(20, 166);
            this.lblNumeroMotor.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblNumeroMotor.Name = "lblNumeroMotor";
            this.lblNumeroMotor.Size = new System.Drawing.Size(86, 21);
            this.lblNumeroMotor.TabIndex = 28;
            this.lblNumeroMotor.Text = "Empleado:";
            // 
            // lblNumeroChasis
            // 
            this.lblNumeroChasis.AutoSize = true;
            this.lblNumeroChasis.Font = new System.Drawing.Font("Franklin Gothic Medium", 12.25F, System.Drawing.FontStyle.Italic);
            this.lblNumeroChasis.Location = new System.Drawing.Point(20, 58);
            this.lblNumeroChasis.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblNumeroChasis.Name = "lblNumeroChasis";
            this.lblNumeroChasis.Size = new System.Drawing.Size(64, 21);
            this.lblNumeroChasis.TabIndex = 27;
            this.lblNumeroChasis.Text = "Cliente:";
            this.lblNumeroChasis.Click += new System.EventHandler(this.lblNumeroChasis_Click);
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Font = new System.Drawing.Font("Franklin Gothic Medium", 12.25F, System.Drawing.FontStyle.Italic);
            this.lblDescripcion.Location = new System.Drawing.Point(20, 110);
            this.lblDescripcion.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(75, 21);
            this.lblDescripcion.TabIndex = 25;
            this.lblDescripcion.Text = "Vehículo:";
            this.lblDescripcion.Click += new System.EventHandler(this.lblDescripcion_Click);
            // 
            // cmbEmpleado
            // 
            this.cmbEmpleado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.cmbEmpleado.FormattingEnabled = true;
            this.cmbEmpleado.Location = new System.Drawing.Point(158, 163);
            this.cmbEmpleado.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.cmbEmpleado.Name = "cmbEmpleado";
            this.cmbEmpleado.Size = new System.Drawing.Size(190, 28);
            this.cmbEmpleado.TabIndex = 49;
            // 
            // cmbCliente
            // 
            this.cmbCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.cmbCliente.FormattingEnabled = true;
            this.cmbCliente.Location = new System.Drawing.Point(158, 55);
            this.cmbCliente.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.cmbCliente.Name = "cmbCliente";
            this.cmbCliente.Size = new System.Drawing.Size(190, 28);
            this.cmbCliente.TabIndex = 48;
            this.cmbCliente.SelectedIndexChanged += new System.EventHandler(this.cmbCliente_SelectedIndexChanged);
            this.cmbCliente.SelectedValueChanged += new System.EventHandler(this.cmbCliente_SelectedValueChanged);
            // 
            // cmbVehiculo
            // 
            this.cmbVehiculo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.cmbVehiculo.FormattingEnabled = true;
            this.cmbVehiculo.Location = new System.Drawing.Point(158, 107);
            this.cmbVehiculo.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.cmbVehiculo.Name = "cmbVehiculo";
            this.cmbVehiculo.Size = new System.Drawing.Size(190, 28);
            this.cmbVehiculo.TabIndex = 47;
            // 
            // cbRayaduras
            // 
            this.cbRayaduras.AutoSize = true;
            this.cbRayaduras.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.cbRayaduras.Location = new System.Drawing.Point(592, 59);
            this.cbRayaduras.Name = "cbRayaduras";
            this.cbRayaduras.Size = new System.Drawing.Size(49, 24);
            this.cbRayaduras.TabIndex = 50;
            this.cbRayaduras.Text = "No";
            this.cbRayaduras.UseVisualStyleBackColor = true;
            this.cbRayaduras.CheckedChanged += new System.EventHandler(this.cbRayaduras_CheckedChanged);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.checkBox1.Location = new System.Drawing.Point(592, 111);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(49, 24);
            this.checkBox1.TabIndex = 52;
            this.checkBox1.Text = "No";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Franklin Gothic Medium", 12.25F, System.Drawing.FontStyle.Italic);
            this.label2.Location = new System.Drawing.Point(443, 114);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 21);
            this.label2.TabIndex = 51;
            this.label2.Text = "Tiene goma?";
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.checkBox2.Location = new System.Drawing.Point(592, 163);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(49, 24);
            this.checkBox2.TabIndex = 54;
            this.checkBox2.Text = "No";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Franklin Gothic Medium", 12.25F, System.Drawing.FontStyle.Italic);
            this.label3.Location = new System.Drawing.Point(443, 166);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 21);
            this.label3.TabIndex = 53;
            this.label3.Text = "Tiene gato?";
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.checkBox3.Location = new System.Drawing.Point(592, 211);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(49, 24);
            this.checkBox3.TabIndex = 56;
            this.checkBox3.Text = "No";
            this.checkBox3.UseVisualStyleBackColor = true;
            this.checkBox3.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Franklin Gothic Medium", 12.25F, System.Drawing.FontStyle.Italic);
            this.label4.Location = new System.Drawing.Point(443, 214);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(138, 21);
            this.label4.TabIndex = 55;
            this.label4.Text = "Tiene cristal roto?";
            // 
            // cmbEstadoInspeccion
            // 
            this.cmbEstadoInspeccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.cmbEstadoInspeccion.FormattingEnabled = true;
            this.cmbEstadoInspeccion.Location = new System.Drawing.Point(908, 109);
            this.cmbEstadoInspeccion.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.cmbEstadoInspeccion.Name = "cmbEstadoInspeccion";
            this.cmbEstadoInspeccion.Size = new System.Drawing.Size(155, 28);
            this.cmbEstadoInspeccion.TabIndex = 58;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Franklin Gothic Medium", 12.25F, System.Drawing.FontStyle.Italic);
            this.label5.Location = new System.Drawing.Point(744, 111);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(144, 21);
            this.label5.TabIndex = 57;
            this.label5.Text = "Estado inspección:";
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Visible = false;
            // 
            // VEHICULO
            // 
            this.VEHICULO.DataPropertyName = "VEHICULO";
            this.VEHICULO.HeaderText = "Vehiculo";
            this.VEHICULO.Name = "VEHICULO";
            this.VEHICULO.ReadOnly = true;
            // 
            // CLIENTE
            // 
            this.CLIENTE.DataPropertyName = "CLIENTE";
            this.CLIENTE.HeaderText = "Cliente";
            this.CLIENTE.Name = "CLIENTE";
            this.CLIENTE.ReadOnly = true;
            // 
            // EMPLEADO
            // 
            this.EMPLEADO.DataPropertyName = "EMPLEADO";
            this.EMPLEADO.HeaderText = "Empleado";
            this.EMPLEADO.Name = "EMPLEADO";
            this.EMPLEADO.ReadOnly = true;
            // 
            // COMBUSTIBLE
            // 
            this.COMBUSTIBLE.DataPropertyName = "COMBUSTIBLE";
            this.COMBUSTIBLE.HeaderText = "Combustible";
            this.COMBUSTIBLE.Name = "COMBUSTIBLE";
            this.COMBUSTIBLE.ReadOnly = true;
            // 
            // TIENE_RAYADURAS
            // 
            this.TIENE_RAYADURAS.DataPropertyName = "TIENE_RAYADURAS";
            this.TIENE_RAYADURAS.HeaderText = "Rayaduras";
            this.TIENE_RAYADURAS.Name = "TIENE_RAYADURAS";
            this.TIENE_RAYADURAS.ReadOnly = true;
            // 
            // TIENE_GOMA
            // 
            this.TIENE_GOMA.DataPropertyName = "TIENE_GOMA";
            this.TIENE_GOMA.HeaderText = "Gomas";
            this.TIENE_GOMA.Name = "TIENE_GOMA";
            this.TIENE_GOMA.ReadOnly = true;
            // 
            // TIENE_GATO
            // 
            this.TIENE_GATO.DataPropertyName = "TIENE_GATO";
            this.TIENE_GATO.HeaderText = "Gato";
            this.TIENE_GATO.Name = "TIENE_GATO";
            this.TIENE_GATO.ReadOnly = true;
            // 
            // TIENE_ROTURA_CRISTAL
            // 
            this.TIENE_ROTURA_CRISTAL.DataPropertyName = "TIENE_ROTURA_CRISTAL";
            this.TIENE_ROTURA_CRISTAL.HeaderText = "Cristal roto";
            this.TIENE_ROTURA_CRISTAL.Name = "TIENE_ROTURA_CRISTAL";
            this.TIENE_ROTURA_CRISTAL.ReadOnly = true;
            // 
            // FECHA_CREACION
            // 
            this.FECHA_CREACION.DataPropertyName = "FECHA_CREACION";
            this.FECHA_CREACION.HeaderText = "Fecha de inspeccion";
            this.FECHA_CREACION.Name = "FECHA_CREACION";
            this.FECHA_CREACION.ReadOnly = true;
            // 
            // ESTADO_INSPECCION
            // 
            this.ESTADO_INSPECCION.DataPropertyName = "ESTADO_INSPECCION";
            this.ESTADO_INSPECCION.HeaderText = "Estado";
            this.ESTADO_INSPECCION.Name = "ESTADO_INSPECCION";
            this.ESTADO_INSPECCION.ReadOnly = true;
            // 
            // GestionInspeccion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1081, 672);
            this.Controls.Add(this.cmbEstadoInspeccion);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.checkBox3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbRayaduras);
            this.Controls.Add(this.cmbEmpleado);
            this.Controls.Add(this.cmbCliente);
            this.Controls.Add(this.cmbVehiculo);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.btnCrear);
            this.Controls.Add(this.dgvInspeccion);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblFechaValor);
            this.Controls.Add(this.cmbCantidadCombustible);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.lblTipoVehiculo);
            this.Controls.Add(this.lblNumeroPlaca);
            this.Controls.Add(this.lblNumeroMotor);
            this.Controls.Add(this.lblNumeroChasis);
            this.Controls.Add(this.lblDescripcion);
            this.Name = "GestionInspeccion";
            this.Text = "GestionInspeccion";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.GestionInspeccion_FormClosed);
            this.Load += new System.EventHandler(this.GestionInspeccion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvInspeccion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.Button btnCrear;
        private System.Windows.Forms.DataGridView dgvInspeccion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblFechaValor;
        private System.Windows.Forms.ComboBox cmbCantidadCombustible;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblTipoVehiculo;
        private System.Windows.Forms.Label lblNumeroPlaca;
        private System.Windows.Forms.Label lblNumeroMotor;
        private System.Windows.Forms.Label lblNumeroChasis;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.ComboBox cmbEmpleado;
        private System.Windows.Forms.ComboBox cmbCliente;
        private System.Windows.Forms.ComboBox cmbVehiculo;
        private System.Windows.Forms.CheckBox cbRayaduras;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbEstadoInspeccion;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn VEHICULO;
        private System.Windows.Forms.DataGridViewTextBoxColumn CLIENTE;
        private System.Windows.Forms.DataGridViewTextBoxColumn EMPLEADO;
        private System.Windows.Forms.DataGridViewTextBoxColumn COMBUSTIBLE;
        private System.Windows.Forms.DataGridViewTextBoxColumn TIENE_RAYADURAS;
        private System.Windows.Forms.DataGridViewTextBoxColumn TIENE_GOMA;
        private System.Windows.Forms.DataGridViewTextBoxColumn TIENE_GATO;
        private System.Windows.Forms.DataGridViewTextBoxColumn TIENE_ROTURA_CRISTAL;
        private System.Windows.Forms.DataGridViewTextBoxColumn FECHA_CREACION;
        private System.Windows.Forms.DataGridViewTextBoxColumn ESTADO_INSPECCION;
    }
}