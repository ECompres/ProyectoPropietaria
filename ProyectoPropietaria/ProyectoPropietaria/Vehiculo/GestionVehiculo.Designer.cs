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
            this.lblMarcaVehiculo = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.txtNumeroChasis = new System.Windows.Forms.TextBox();
            this.txtNumeroMotor = new System.Windows.Forms.TextBox();
            this.txtNumeroPlaca = new System.Windows.Forms.TextBox();
            this.lblFecha = new System.Windows.Forms.Label();
            this.cmbTipoVehiculo = new System.Windows.Forms.ComboBox();
            this.cmbMarcaVehiculo = new System.Windows.Forms.ComboBox();
            this.cmbModeloVehiculo = new System.Windows.Forms.ComboBox();
            this.cmbCombustible = new System.Windows.Forms.ComboBox();
            this.lblFechaValor = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgwVehiculos = new System.Windows.Forms.DataGridView();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.btnCrear = new System.Windows.Forms.Button();
            this.btnBorrar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgwVehiculos)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Font = new System.Drawing.Font("Franklin Gothic Medium", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripcion.Location = new System.Drawing.Point(14, 66);
            this.lblDescripcion.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(116, 24);
            this.lblDescripcion.TabIndex = 0;
            this.lblDescripcion.Text = "Descripción: ";
            // 
            // lblNumeroChasis
            // 
            this.lblNumeroChasis.AutoSize = true;
            this.lblNumeroChasis.Font = new System.Drawing.Font("Franklin Gothic Medium", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumeroChasis.Location = new System.Drawing.Point(14, 136);
            this.lblNumeroChasis.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblNumeroChasis.Name = "lblNumeroChasis";
            this.lblNumeroChasis.Size = new System.Drawing.Size(167, 24);
            this.lblNumeroChasis.TabIndex = 1;
            this.lblNumeroChasis.Text = "Número de chasis: ";
            // 
            // lblNumeroMotor
            // 
            this.lblNumeroMotor.AutoSize = true;
            this.lblNumeroMotor.Font = new System.Drawing.Font("Franklin Gothic Medium", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumeroMotor.Location = new System.Drawing.Point(14, 208);
            this.lblNumeroMotor.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblNumeroMotor.Name = "lblNumeroMotor";
            this.lblNumeroMotor.Size = new System.Drawing.Size(159, 24);
            this.lblNumeroMotor.TabIndex = 2;
            this.lblNumeroMotor.Text = "Número de motor:";
            // 
            // lblNumeroPlaca
            // 
            this.lblNumeroPlaca.AutoSize = true;
            this.lblNumeroPlaca.Font = new System.Drawing.Font("Franklin Gothic Medium", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumeroPlaca.Location = new System.Drawing.Point(14, 282);
            this.lblNumeroPlaca.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblNumeroPlaca.Name = "lblNumeroPlaca";
            this.lblNumeroPlaca.Size = new System.Drawing.Size(154, 24);
            this.lblNumeroPlaca.TabIndex = 3;
            this.lblNumeroPlaca.Text = "Número de placa:";
            // 
            // lblTipoVehiculo
            // 
            this.lblTipoVehiculo.AutoSize = true;
            this.lblTipoVehiculo.Font = new System.Drawing.Font("Franklin Gothic Medium", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoVehiculo.Location = new System.Drawing.Point(568, 67);
            this.lblTipoVehiculo.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblTipoVehiculo.Name = "lblTipoVehiculo";
            this.lblTipoVehiculo.Size = new System.Drawing.Size(121, 24);
            this.lblTipoVehiculo.TabIndex = 4;
            this.lblTipoVehiculo.Text = "Tipo vehículo:";
            // 
            // lblModeloVehiculo
            // 
            this.lblModeloVehiculo.AutoSize = true;
            this.lblModeloVehiculo.Font = new System.Drawing.Font("Franklin Gothic Medium", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModeloVehiculo.Location = new System.Drawing.Point(568, 209);
            this.lblModeloVehiculo.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblModeloVehiculo.Name = "lblModeloVehiculo";
            this.lblModeloVehiculo.Size = new System.Drawing.Size(152, 24);
            this.lblModeloVehiculo.TabIndex = 5;
            this.lblModeloVehiculo.Text = "Modelo vehículo: ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Franklin Gothic Medium", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(1016, 60);
            this.label7.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 24);
            this.label7.TabIndex = 6;
            this.label7.Text = "Estado:";
            // 
            // lblCombustible
            // 
            this.lblCombustible.AutoSize = true;
            this.lblCombustible.Font = new System.Drawing.Font("Franklin Gothic Medium", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCombustible.Location = new System.Drawing.Point(568, 283);
            this.lblCombustible.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblCombustible.Name = "lblCombustible";
            this.lblCombustible.Size = new System.Drawing.Size(112, 24);
            this.lblCombustible.TabIndex = 7;
            this.lblCombustible.Text = "Combustible";
            // 
            // lblMarcaVehiculo
            // 
            this.lblMarcaVehiculo.AutoSize = true;
            this.lblMarcaVehiculo.Font = new System.Drawing.Font("Franklin Gothic Medium", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMarcaVehiculo.Location = new System.Drawing.Point(568, 137);
            this.lblMarcaVehiculo.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblMarcaVehiculo.Name = "lblMarcaVehiculo";
            this.lblMarcaVehiculo.Size = new System.Drawing.Size(138, 24);
            this.lblMarcaVehiculo.TabIndex = 8;
            this.lblMarcaVehiculo.Text = "Marca vehículo:";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescripcion.Location = new System.Drawing.Point(229, 66);
            this.txtDescripcion.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(264, 29);
            this.txtDescripcion.TabIndex = 9;
            // 
            // txtNumeroChasis
            // 
            this.txtNumeroChasis.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumeroChasis.Location = new System.Drawing.Point(229, 134);
            this.txtNumeroChasis.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtNumeroChasis.Name = "txtNumeroChasis";
            this.txtNumeroChasis.Size = new System.Drawing.Size(264, 29);
            this.txtNumeroChasis.TabIndex = 10;
            // 
            // txtNumeroMotor
            // 
            this.txtNumeroMotor.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumeroMotor.Location = new System.Drawing.Point(229, 206);
            this.txtNumeroMotor.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtNumeroMotor.Name = "txtNumeroMotor";
            this.txtNumeroMotor.Size = new System.Drawing.Size(264, 29);
            this.txtNumeroMotor.TabIndex = 11;
            // 
            // txtNumeroPlaca
            // 
            this.txtNumeroPlaca.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumeroPlaca.Location = new System.Drawing.Point(229, 280);
            this.txtNumeroPlaca.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtNumeroPlaca.Name = "txtNumeroPlaca";
            this.txtNumeroPlaca.Size = new System.Drawing.Size(264, 29);
            this.txtNumeroPlaca.TabIndex = 12;
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Franklin Gothic Medium", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.Location = new System.Drawing.Point(1016, 130);
            this.lblFecha.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(63, 24);
            this.lblFecha.TabIndex = 13;
            this.lblFecha.Text = "Fecha:";
            // 
            // cmbTipoVehiculo
            // 
            this.cmbTipoVehiculo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTipoVehiculo.FormattingEnabled = true;
            this.cmbTipoVehiculo.Location = new System.Drawing.Point(737, 62);
            this.cmbTipoVehiculo.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.cmbTipoVehiculo.Name = "cmbTipoVehiculo";
            this.cmbTipoVehiculo.Size = new System.Drawing.Size(229, 32);
            this.cmbTipoVehiculo.TabIndex = 14;
            // 
            // cmbMarcaVehiculo
            // 
            this.cmbMarcaVehiculo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbMarcaVehiculo.FormattingEnabled = true;
            this.cmbMarcaVehiculo.Location = new System.Drawing.Point(737, 132);
            this.cmbMarcaVehiculo.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.cmbMarcaVehiculo.Name = "cmbMarcaVehiculo";
            this.cmbMarcaVehiculo.Size = new System.Drawing.Size(229, 32);
            this.cmbMarcaVehiculo.TabIndex = 15;
            // 
            // cmbModeloVehiculo
            // 
            this.cmbModeloVehiculo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbModeloVehiculo.FormattingEnabled = true;
            this.cmbModeloVehiculo.Location = new System.Drawing.Point(737, 204);
            this.cmbModeloVehiculo.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.cmbModeloVehiculo.Name = "cmbModeloVehiculo";
            this.cmbModeloVehiculo.Size = new System.Drawing.Size(229, 32);
            this.cmbModeloVehiculo.TabIndex = 16;
            // 
            // cmbCombustible
            // 
            this.cmbCombustible.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCombustible.FormattingEnabled = true;
            this.cmbCombustible.Location = new System.Drawing.Point(737, 278);
            this.cmbCombustible.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.cmbCombustible.Name = "cmbCombustible";
            this.cmbCombustible.Size = new System.Drawing.Size(229, 32);
            this.cmbCombustible.TabIndex = 17;
            // 
            // lblFechaValor
            // 
            this.lblFechaValor.AutoSize = true;
            this.lblFechaValor.Font = new System.Drawing.Font("Franklin Gothic Medium", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaValor.Location = new System.Drawing.Point(1092, 130);
            this.lblFechaValor.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblFechaValor.Name = "lblFechaValor";
            this.lblFechaValor.Size = new System.Drawing.Size(86, 24);
            this.lblFechaValor.TabIndex = 19;
            this.lblFechaValor.Text = "fechaHoy";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Franklin Gothic Medium", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(623, 17);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 24);
            this.label1.TabIndex = 20;
            this.label1.Text = "Gestión de vehículos";
            // 
            // dgwVehiculos
            // 
            this.dgwVehiculos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwVehiculos.Location = new System.Drawing.Point(8, 383);
            this.dgwVehiculos.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.dgwVehiculos.Name = "dgwVehiculos";
            this.dgwVehiculos.Size = new System.Drawing.Size(1220, 310);
            this.dgwVehiculos.TabIndex = 21;
            // 
            // checkBox1
            // 
            this.checkBox1.Location = new System.Drawing.Point(1096, 60);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(153, 31);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.Text = "No disponible";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // btnCrear
            // 
            this.btnCrear.Location = new System.Drawing.Point(1107, 323);
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.Size = new System.Drawing.Size(121, 38);
            this.btnCrear.TabIndex = 22;
            this.btnCrear.Text = "Crear";
            this.btnCrear.UseVisualStyleBackColor = true;
            this.btnCrear.Click += new System.EventHandler(this.btnCrear_Click);
            // 
            // btnBorrar
            // 
            this.btnBorrar.Location = new System.Drawing.Point(1107, 702);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(121, 38);
            this.btnBorrar.TabIndex = 23;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.UseVisualStyleBackColor = true;
            // 
            // GestionVehiculo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1236, 741);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.btnCrear);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.dgwVehiculos);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblFechaValor);
            this.Controls.Add(this.cmbCombustible);
            this.Controls.Add(this.cmbModeloVehiculo);
            this.Controls.Add(this.cmbMarcaVehiculo);
            this.Controls.Add(this.cmbTipoVehiculo);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.txtNumeroPlaca);
            this.Controls.Add(this.txtNumeroMotor);
            this.Controls.Add(this.txtNumeroChasis);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.lblMarcaVehiculo);
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
        private System.Windows.Forms.Label lblMarcaVehiculo;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.TextBox txtNumeroChasis;
        private System.Windows.Forms.TextBox txtNumeroMotor;
        private System.Windows.Forms.TextBox txtNumeroPlaca;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.ComboBox cmbTipoVehiculo;
        private System.Windows.Forms.ComboBox cmbMarcaVehiculo;
        private System.Windows.Forms.ComboBox cmbModeloVehiculo;
        private System.Windows.Forms.ComboBox cmbCombustible;
        private System.Windows.Forms.Label lblFechaValor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgwVehiculos;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button btnCrear;
        private System.Windows.Forms.Button btnBorrar;
    }
}