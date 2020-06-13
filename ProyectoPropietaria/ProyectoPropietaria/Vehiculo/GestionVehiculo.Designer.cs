namespace ProyectoPropietaria
{
    partial class GestionVehiculo
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
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.lblNumeroChasis = new System.Windows.Forms.Label();
            this.lblNumeroMotor = new System.Windows.Forms.Label();
            this.lblNumeroPlaca = new System.Windows.Forms.Label();
            this.lblTipoVehiculo = new System.Windows.Forms.Label();
            this.lblModeloVehiculo = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblCombustible = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.txtNumeroChasis = new System.Windows.Forms.TextBox();
            this.txtNumeroMotor = new System.Windows.Forms.TextBox();
            this.txtNumeroPlaca = new System.Windows.Forms.TextBox();
            this.lblFecha = new System.Windows.Forms.Label();
            this.cmbTipoVehiculo = new System.Windows.Forms.ComboBox();
            this.cmbModeloVehiculo = new System.Windows.Forms.ComboBox();
            this.cmbCombustible = new System.Windows.Forms.ComboBox();
            this.lblFechaValor = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgwVehiculos = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DESCRIPCION = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NUMERO_CHASIS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NUMERO_MOTOR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NUMERO_PLACA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TIPOVEHICULO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MODELO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.COMBUSTIBLE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FECHA_CREACION = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ESTADO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbEstado = new System.Windows.Forms.CheckBox();
            this.btnCrear = new System.Windows.Forms.Button();
            this.btnBorrar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgwVehiculos)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Font = new System.Drawing.Font("Franklin Gothic Medium", 12.25F, System.Drawing.FontStyle.Italic);
            this.lblDescripcion.Location = new System.Drawing.Point(14, 66);
            this.lblDescripcion.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(103, 21);
            this.lblDescripcion.TabIndex = 0;
            this.lblDescripcion.Text = "Descripción: ";
            // 
            // lblNumeroChasis
            // 
            this.lblNumeroChasis.AutoSize = true;
            this.lblNumeroChasis.Font = new System.Drawing.Font("Franklin Gothic Medium", 12.25F, System.Drawing.FontStyle.Italic);
            this.lblNumeroChasis.Location = new System.Drawing.Point(14, 136);
            this.lblNumeroChasis.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblNumeroChasis.Name = "lblNumeroChasis";
            this.lblNumeroChasis.Size = new System.Drawing.Size(148, 21);
            this.lblNumeroChasis.TabIndex = 1;
            this.lblNumeroChasis.Text = "Número de chasis: ";
            // 
            // lblNumeroMotor
            // 
            this.lblNumeroMotor.AutoSize = true;
            this.lblNumeroMotor.Font = new System.Drawing.Font("Franklin Gothic Medium", 12.25F, System.Drawing.FontStyle.Italic);
            this.lblNumeroMotor.Location = new System.Drawing.Point(14, 208);
            this.lblNumeroMotor.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblNumeroMotor.Name = "lblNumeroMotor";
            this.lblNumeroMotor.Size = new System.Drawing.Size(141, 21);
            this.lblNumeroMotor.TabIndex = 2;
            this.lblNumeroMotor.Text = "Número de motor:";
            // 
            // lblNumeroPlaca
            // 
            this.lblNumeroPlaca.AutoSize = true;
            this.lblNumeroPlaca.Font = new System.Drawing.Font("Franklin Gothic Medium", 12.25F, System.Drawing.FontStyle.Italic);
            this.lblNumeroPlaca.Location = new System.Drawing.Point(14, 282);
            this.lblNumeroPlaca.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblNumeroPlaca.Name = "lblNumeroPlaca";
            this.lblNumeroPlaca.Size = new System.Drawing.Size(137, 21);
            this.lblNumeroPlaca.TabIndex = 3;
            this.lblNumeroPlaca.Text = "Número de placa:";
            // 
            // lblTipoVehiculo
            // 
            this.lblTipoVehiculo.AutoSize = true;
            this.lblTipoVehiculo.Font = new System.Drawing.Font("Franklin Gothic Medium", 12.25F, System.Drawing.FontStyle.Italic);
            this.lblTipoVehiculo.Location = new System.Drawing.Point(487, 66);
            this.lblTipoVehiculo.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblTipoVehiculo.Name = "lblTipoVehiculo";
            this.lblTipoVehiculo.Size = new System.Drawing.Size(108, 21);
            this.lblTipoVehiculo.TabIndex = 4;
            this.lblTipoVehiculo.Text = "Tipo vehículo:";
            // 
            // lblModeloVehiculo
            // 
            this.lblModeloVehiculo.AutoSize = true;
            this.lblModeloVehiculo.Font = new System.Drawing.Font("Franklin Gothic Medium", 12.25F, System.Drawing.FontStyle.Italic);
            this.lblModeloVehiculo.Location = new System.Drawing.Point(487, 129);
            this.lblModeloVehiculo.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblModeloVehiculo.Name = "lblModeloVehiculo";
            this.lblModeloVehiculo.Size = new System.Drawing.Size(136, 21);
            this.lblModeloVehiculo.TabIndex = 5;
            this.lblModeloVehiculo.Text = "Modelo vehículo: ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Franklin Gothic Medium", 12.25F, System.Drawing.FontStyle.Italic);
            this.label7.Location = new System.Drawing.Point(856, 58);
            this.label7.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 21);
            this.label7.TabIndex = 6;
            this.label7.Text = "Estado:";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // lblCombustible
            // 
            this.lblCombustible.AutoSize = true;
            this.lblCombustible.Font = new System.Drawing.Font("Franklin Gothic Medium", 12.25F, System.Drawing.FontStyle.Italic);
            this.lblCombustible.Location = new System.Drawing.Point(487, 203);
            this.lblCombustible.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblCombustible.Name = "lblCombustible";
            this.lblCombustible.Size = new System.Drawing.Size(100, 21);
            this.lblCombustible.TabIndex = 7;
            this.lblCombustible.Text = "Combustible";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.txtDescripcion.Location = new System.Drawing.Point(190, 63);
            this.txtDescripcion.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(225, 26);
            this.txtDescripcion.TabIndex = 9;
            // 
            // txtNumeroChasis
            // 
            this.txtNumeroChasis.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.txtNumeroChasis.Location = new System.Drawing.Point(190, 131);
            this.txtNumeroChasis.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtNumeroChasis.Name = "txtNumeroChasis";
            this.txtNumeroChasis.Size = new System.Drawing.Size(225, 26);
            this.txtNumeroChasis.TabIndex = 10;
            // 
            // txtNumeroMotor
            // 
            this.txtNumeroMotor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.txtNumeroMotor.Location = new System.Drawing.Point(190, 203);
            this.txtNumeroMotor.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtNumeroMotor.Name = "txtNumeroMotor";
            this.txtNumeroMotor.Size = new System.Drawing.Size(225, 26);
            this.txtNumeroMotor.TabIndex = 11;
            // 
            // txtNumeroPlaca
            // 
            this.txtNumeroPlaca.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.txtNumeroPlaca.Location = new System.Drawing.Point(190, 277);
            this.txtNumeroPlaca.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtNumeroPlaca.Name = "txtNumeroPlaca";
            this.txtNumeroPlaca.Size = new System.Drawing.Size(225, 26);
            this.txtNumeroPlaca.TabIndex = 12;
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Franklin Gothic Medium", 12.25F, System.Drawing.FontStyle.Italic);
            this.lblFecha.Location = new System.Drawing.Point(856, 128);
            this.lblFecha.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(57, 21);
            this.lblFecha.TabIndex = 13;
            this.lblFecha.Text = "Fecha:";
            this.lblFecha.Click += new System.EventHandler(this.lblFecha_Click);
            // 
            // cmbTipoVehiculo
            // 
            this.cmbTipoVehiculo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.cmbTipoVehiculo.FormattingEnabled = true;
            this.cmbTipoVehiculo.Location = new System.Drawing.Point(617, 58);
            this.cmbTipoVehiculo.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.cmbTipoVehiculo.Name = "cmbTipoVehiculo";
            this.cmbTipoVehiculo.Size = new System.Drawing.Size(190, 28);
            this.cmbTipoVehiculo.TabIndex = 14;
            // 
            // cmbModeloVehiculo
            // 
            this.cmbModeloVehiculo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.cmbModeloVehiculo.FormattingEnabled = true;
            this.cmbModeloVehiculo.Location = new System.Drawing.Point(617, 121);
            this.cmbModeloVehiculo.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.cmbModeloVehiculo.Name = "cmbModeloVehiculo";
            this.cmbModeloVehiculo.Size = new System.Drawing.Size(190, 28);
            this.cmbModeloVehiculo.TabIndex = 16;
            // 
            // cmbCombustible
            // 
            this.cmbCombustible.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.cmbCombustible.FormattingEnabled = true;
            this.cmbCombustible.Location = new System.Drawing.Point(617, 195);
            this.cmbCombustible.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.cmbCombustible.Name = "cmbCombustible";
            this.cmbCombustible.Size = new System.Drawing.Size(190, 28);
            this.cmbCombustible.TabIndex = 17;
            // 
            // lblFechaValor
            // 
            this.lblFechaValor.AutoSize = true;
            this.lblFechaValor.Font = new System.Drawing.Font("Franklin Gothic Medium", 12.25F, System.Drawing.FontStyle.Italic);
            this.lblFechaValor.Location = new System.Drawing.Point(932, 128);
            this.lblFechaValor.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblFechaValor.Name = "lblFechaValor";
            this.lblFechaValor.Size = new System.Drawing.Size(78, 21);
            this.lblFechaValor.TabIndex = 19;
            this.lblFechaValor.Text = "fechaHoy";
            this.lblFechaValor.Click += new System.EventHandler(this.lblFechaValor_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Franklin Gothic Medium", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(445, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 24);
            this.label1.TabIndex = 20;
            this.label1.Text = "Gestión de vehículos";
            // 
            // dgwVehiculos
            // 
            this.dgwVehiculos.AllowUserToAddRows = false;
            this.dgwVehiculos.AllowUserToDeleteRows = false;
            this.dgwVehiculos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwVehiculos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.DESCRIPCION,
            this.NUMERO_CHASIS,
            this.NUMERO_MOTOR,
            this.NUMERO_PLACA,
            this.TIPOVEHICULO,
            this.MODELO,
            this.COMBUSTIBLE,
            this.FECHA_CREACION,
            this.ESTADO});
            this.dgwVehiculos.Location = new System.Drawing.Point(8, 315);
            this.dgwVehiculos.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.dgwVehiculos.Name = "dgwVehiculos";
            this.dgwVehiculos.ReadOnly = true;
            this.dgwVehiculos.Size = new System.Drawing.Size(1059, 322);
            this.dgwVehiculos.TabIndex = 21;
            this.dgwVehiculos.DoubleClick += new System.EventHandler(this.dgwVehiculos_DoubleClick);
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
            this.DESCRIPCION.HeaderText = "Descrición";
            this.DESCRIPCION.Name = "DESCRIPCION";
            this.DESCRIPCION.ReadOnly = true;
            // 
            // NUMERO_CHASIS
            // 
            this.NUMERO_CHASIS.DataPropertyName = "NUMERO_CHASIS";
            this.NUMERO_CHASIS.HeaderText = "Numero de chasis";
            this.NUMERO_CHASIS.Name = "NUMERO_CHASIS";
            this.NUMERO_CHASIS.ReadOnly = true;
            // 
            // NUMERO_MOTOR
            // 
            this.NUMERO_MOTOR.DataPropertyName = "NUMERO_MOTOR";
            this.NUMERO_MOTOR.HeaderText = "Numero de motor";
            this.NUMERO_MOTOR.Name = "NUMERO_MOTOR";
            this.NUMERO_MOTOR.ReadOnly = true;
            // 
            // NUMERO_PLACA
            // 
            this.NUMERO_PLACA.DataPropertyName = "NUMERO_PLACA";
            this.NUMERO_PLACA.HeaderText = "Numero de placa";
            this.NUMERO_PLACA.Name = "NUMERO_PLACA";
            this.NUMERO_PLACA.ReadOnly = true;
            // 
            // TIPOVEHICULO
            // 
            this.TIPOVEHICULO.DataPropertyName = "TIPOVEHICULO";
            this.TIPOVEHICULO.HeaderText = "Tipo de vehiculo";
            this.TIPOVEHICULO.Name = "TIPOVEHICULO";
            this.TIPOVEHICULO.ReadOnly = true;
            // 
            // MODELO
            // 
            this.MODELO.DataPropertyName = "MODELO";
            this.MODELO.HeaderText = "Modelo";
            this.MODELO.Name = "MODELO";
            this.MODELO.ReadOnly = true;
            // 
            // COMBUSTIBLE
            // 
            this.COMBUSTIBLE.DataPropertyName = "COMBUSTIBLE";
            this.COMBUSTIBLE.HeaderText = "Combustible";
            this.COMBUSTIBLE.Name = "COMBUSTIBLE";
            this.COMBUSTIBLE.ReadOnly = true;
            // 
            // FECHA_CREACION
            // 
            this.FECHA_CREACION.DataPropertyName = "FECHA_CREACION";
            this.FECHA_CREACION.HeaderText = "Fecha de creacion";
            this.FECHA_CREACION.Name = "FECHA_CREACION";
            this.FECHA_CREACION.ReadOnly = true;
            // 
            // ESTADO
            // 
            this.ESTADO.DataPropertyName = "ESTADO";
            this.ESTADO.HeaderText = "Disponibilidad";
            this.ESTADO.Name = "ESTADO";
            this.ESTADO.ReadOnly = true;
            // 
            // cbEstado
            // 
            this.cbEstado.Font = new System.Drawing.Font("Franklin Gothic Medium", 12.25F, System.Drawing.FontStyle.Italic);
            this.cbEstado.Location = new System.Drawing.Point(936, 58);
            this.cbEstado.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.cbEstado.Name = "cbEstado";
            this.cbEstado.Size = new System.Drawing.Size(153, 31);
            this.cbEstado.TabIndex = 0;
            this.cbEstado.Text = "No disponible";
            this.cbEstado.UseVisualStyleBackColor = true;
            this.cbEstado.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // btnCrear
            // 
            this.btnCrear.Font = new System.Drawing.Font("Franklin Gothic Medium", 12.25F, System.Drawing.FontStyle.Italic);
            this.btnCrear.Location = new System.Drawing.Point(936, 278);
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.Size = new System.Drawing.Size(121, 28);
            this.btnCrear.TabIndex = 22;
            this.btnCrear.Text = "Crear";
            this.btnCrear.UseVisualStyleBackColor = true;
            this.btnCrear.Click += new System.EventHandler(this.btnCrear_Click);
            // 
            // btnBorrar
            // 
            this.btnBorrar.Font = new System.Drawing.Font("Franklin Gothic Medium", 12.25F, System.Drawing.FontStyle.Italic);
            this.btnBorrar.Location = new System.Drawing.Point(936, 646);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(121, 30);
            this.btnBorrar.TabIndex = 24;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.UseVisualStyleBackColor = true;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // GestionVehiculo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1082, 676);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.btnCrear);
            this.Controls.Add(this.cbEstado);
            this.Controls.Add(this.dgwVehiculos);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblFechaValor);
            this.Controls.Add(this.cmbCombustible);
            this.Controls.Add(this.cmbModeloVehiculo);
            this.Controls.Add(this.cmbTipoVehiculo);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.txtNumeroPlaca);
            this.Controls.Add(this.txtNumeroMotor);
            this.Controls.Add(this.txtNumeroChasis);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.lblCombustible);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblModeloVehiculo);
            this.Controls.Add(this.lblTipoVehiculo);
            this.Controls.Add(this.lblNumeroPlaca);
            this.Controls.Add(this.lblNumeroMotor);
            this.Controls.Add(this.lblNumeroChasis);
            this.Controls.Add(this.lblDescripcion);
            this.Font = new System.Drawing.Font("Franklin Gothic Medium", 14.25F, System.Drawing.FontStyle.Italic);
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "GestionVehiculo";
            this.Text = "AgregarVehiculo";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.GestionVehiculo_FormClosed);
            this.Load += new System.EventHandler(this.GestionVehiculo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwVehiculos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Label lblNumeroChasis;
        private System.Windows.Forms.Label lblNumeroMotor;
        private System.Windows.Forms.Label lblNumeroPlaca;
        private System.Windows.Forms.Label lblTipoVehiculo;
        private System.Windows.Forms.Label lblModeloVehiculo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblCombustible;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.TextBox txtNumeroChasis;
        private System.Windows.Forms.TextBox txtNumeroMotor;
        private System.Windows.Forms.TextBox txtNumeroPlaca;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.ComboBox cmbTipoVehiculo;
        private System.Windows.Forms.ComboBox cmbModeloVehiculo;
        private System.Windows.Forms.ComboBox cmbCombustible;
        private System.Windows.Forms.Label lblFechaValor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgwVehiculos;
        private System.Windows.Forms.CheckBox cbEstado;
        private System.Windows.Forms.Button btnCrear;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn DESCRIPCION;
        private System.Windows.Forms.DataGridViewTextBoxColumn NUMERO_CHASIS;
        private System.Windows.Forms.DataGridViewTextBoxColumn NUMERO_MOTOR;
        private System.Windows.Forms.DataGridViewTextBoxColumn NUMERO_PLACA;
        private System.Windows.Forms.DataGridViewTextBoxColumn TIPOVEHICULO;
        private System.Windows.Forms.DataGridViewTextBoxColumn MODELO;
        private System.Windows.Forms.DataGridViewTextBoxColumn COMBUSTIBLE;
        private System.Windows.Forms.DataGridViewTextBoxColumn FECHA_CREACION;
        private System.Windows.Forms.DataGridViewTextBoxColumn ESTADO;
    }
}