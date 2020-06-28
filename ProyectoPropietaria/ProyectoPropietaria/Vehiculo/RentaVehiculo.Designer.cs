namespace ProyectoPropietaria.Vehiculo
{
    partial class RentaVehiculo
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.cristalesRotos = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.gato = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.gomaRepuesto = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.rayaduras = new System.Windows.Forms.CheckBox();
            this.cmbCliente = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbCantidadCombustible = new System.Windows.Forms.ComboBox();
            this.lblTipoVehiculo = new System.Windows.Forms.Label();
            this.lblNumeroPlaca = new System.Windows.Forms.Label();
            this.lblNumeroChasis = new System.Windows.Forms.Label();
            this.cmbVehiculo = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dpRenta = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.numericCostePorDia = new System.Windows.Forms.NumericUpDown();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.cbEstado = new System.Windows.Forms.CheckBox();
            this.label14 = new System.Windows.Forms.Label();
            this.gomaTI = new System.Windows.Forms.CheckBox();
            this.label15 = new System.Windows.Forms.Label();
            this.gomaTD = new System.Windows.Forms.CheckBox();
            this.label16 = new System.Windows.Forms.Label();
            this.gomaDI = new System.Windows.Forms.CheckBox();
            this.label17 = new System.Windows.Forms.Label();
            this.gomaDD = new System.Windows.Forms.CheckBox();
            this.label18 = new System.Windows.Forms.Label();
            this.dgvRenta = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID_INSPECCION = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VEHICULO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CLIENTE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID_EMPLEADO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODIGO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ESTADO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.btnCrear = new System.Windows.Forms.Button();
            this.dpDevolucion = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblDias = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btnExportar = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label20 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericCostePorDia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRenta)).BeginInit();
            this.SuspendLayout();
            // 
            // cristalesRotos
            // 
            this.cristalesRotos.AutoSize = true;
            this.cristalesRotos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.cristalesRotos.ForeColor = System.Drawing.Color.LightGray;
            this.cristalesRotos.Location = new System.Drawing.Point(153, 341);
            this.cristalesRotos.Name = "cristalesRotos";
            this.cristalesRotos.Size = new System.Drawing.Size(49, 24);
            this.cristalesRotos.TabIndex = 73;
            this.cristalesRotos.Text = "No";
            this.cristalesRotos.UseVisualStyleBackColor = true;
            this.cristalesRotos.CheckedChanged += new System.EventHandler(this.cristalesRotos_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Franklin Gothic Medium", 12.25F, System.Drawing.FontStyle.Italic);
            this.label4.ForeColor = System.Drawing.Color.LightGray;
            this.label4.Location = new System.Drawing.Point(20, 341);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 21);
            this.label4.TabIndex = 72;
            this.label4.Text = "Cristales rotos:";
            // 
            // gato
            // 
            this.gato.AutoSize = true;
            this.gato.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.gato.ForeColor = System.Drawing.Color.LightGray;
            this.gato.Location = new System.Drawing.Point(153, 311);
            this.gato.Name = "gato";
            this.gato.Size = new System.Drawing.Size(49, 24);
            this.gato.TabIndex = 71;
            this.gato.Text = "No";
            this.gato.UseVisualStyleBackColor = true;
            this.gato.CheckedChanged += new System.EventHandler(this.gato_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Franklin Gothic Medium", 12.25F, System.Drawing.FontStyle.Italic);
            this.label3.ForeColor = System.Drawing.Color.LightGray;
            this.label3.Location = new System.Drawing.Point(20, 312);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 21);
            this.label3.TabIndex = 70;
            this.label3.Text = "Gato:";
            // 
            // gomaRepuesto
            // 
            this.gomaRepuesto.AutoSize = true;
            this.gomaRepuesto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.gomaRepuesto.ForeColor = System.Drawing.Color.LightGray;
            this.gomaRepuesto.Location = new System.Drawing.Point(153, 281);
            this.gomaRepuesto.Name = "gomaRepuesto";
            this.gomaRepuesto.Size = new System.Drawing.Size(49, 24);
            this.gomaRepuesto.TabIndex = 69;
            this.gomaRepuesto.Text = "No";
            this.gomaRepuesto.UseVisualStyleBackColor = true;
            this.gomaRepuesto.CheckedChanged += new System.EventHandler(this.gomaRepuesto_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Franklin Gothic Medium", 12.25F, System.Drawing.FontStyle.Italic);
            this.label2.ForeColor = System.Drawing.Color.LightGray;
            this.label2.Location = new System.Drawing.Point(20, 284);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 21);
            this.label2.TabIndex = 68;
            this.label2.Text = "Goma repuesto:";
            // 
            // rayaduras
            // 
            this.rayaduras.AutoSize = true;
            this.rayaduras.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.rayaduras.ForeColor = System.Drawing.Color.LightGray;
            this.rayaduras.Location = new System.Drawing.Point(153, 251);
            this.rayaduras.Name = "rayaduras";
            this.rayaduras.Size = new System.Drawing.Size(49, 24);
            this.rayaduras.TabIndex = 67;
            this.rayaduras.Text = "No";
            this.rayaduras.UseVisualStyleBackColor = true;
            this.rayaduras.CheckedChanged += new System.EventHandler(this.rayaduras_CheckedChanged);
            // 
            // cmbCliente
            // 
            this.cmbCliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.cmbCliente.Location = new System.Drawing.Point(150, 62);
            this.cmbCliente.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.cmbCliente.Name = "cmbCliente";
            this.cmbCliente.Size = new System.Drawing.Size(178, 28);
            this.cmbCliente.TabIndex = 65;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Franklin Gothic Medium", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(446, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 24);
            this.label1.TabIndex = 63;
            this.label1.Text = "Renta";
            // 
            // cmbCantidadCombustible
            // 
            this.cmbCantidadCombustible.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCantidadCombustible.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.cmbCantidadCombustible.ForeColor = System.Drawing.Color.LightGray;
            this.cmbCantidadCombustible.Location = new System.Drawing.Point(200, 374);
            this.cmbCantidadCombustible.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.cmbCantidadCombustible.Name = "cmbCantidadCombustible";
            this.cmbCantidadCombustible.Size = new System.Drawing.Size(88, 28);
            this.cmbCantidadCombustible.TabIndex = 62;
            this.cmbCantidadCombustible.SelectedIndexChanged += new System.EventHandler(this.cmbCantidadCombustible_SelectedIndexChanged);
            // 
            // lblTipoVehiculo
            // 
            this.lblTipoVehiculo.AutoSize = true;
            this.lblTipoVehiculo.Font = new System.Drawing.Font("Franklin Gothic Medium", 12.25F, System.Drawing.FontStyle.Italic);
            this.lblTipoVehiculo.ForeColor = System.Drawing.Color.LightGray;
            this.lblTipoVehiculo.Location = new System.Drawing.Point(20, 377);
            this.lblTipoVehiculo.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblTipoVehiculo.Name = "lblTipoVehiculo";
            this.lblTipoVehiculo.Size = new System.Drawing.Size(170, 21);
            this.lblTipoVehiculo.TabIndex = 61;
            this.lblTipoVehiculo.Text = "Cantidad combustible:";
            // 
            // lblNumeroPlaca
            // 
            this.lblNumeroPlaca.AutoSize = true;
            this.lblNumeroPlaca.Font = new System.Drawing.Font("Franklin Gothic Medium", 12.25F, System.Drawing.FontStyle.Italic);
            this.lblNumeroPlaca.ForeColor = System.Drawing.Color.LightGray;
            this.lblNumeroPlaca.Location = new System.Drawing.Point(20, 254);
            this.lblNumeroPlaca.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblNumeroPlaca.Name = "lblNumeroPlaca";
            this.lblNumeroPlaca.Size = new System.Drawing.Size(92, 21);
            this.lblNumeroPlaca.TabIndex = 60;
            this.lblNumeroPlaca.Text = "Rayaduras:";
            // 
            // lblNumeroChasis
            // 
            this.lblNumeroChasis.AutoSize = true;
            this.lblNumeroChasis.Font = new System.Drawing.Font("Franklin Gothic Medium", 12.25F, System.Drawing.FontStyle.Italic);
            this.lblNumeroChasis.Location = new System.Drawing.Point(15, 65);
            this.lblNumeroChasis.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblNumeroChasis.Name = "lblNumeroChasis";
            this.lblNumeroChasis.Size = new System.Drawing.Size(64, 21);
            this.lblNumeroChasis.TabIndex = 58;
            this.lblNumeroChasis.Text = "Cliente:";
            // 
            // cmbVehiculo
            // 
            this.cmbVehiculo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbVehiculo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.cmbVehiculo.Location = new System.Drawing.Point(150, 102);
            this.cmbVehiculo.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.cmbVehiculo.Name = "cmbVehiculo";
            this.cmbVehiculo.Size = new System.Drawing.Size(178, 28);
            this.cmbVehiculo.TabIndex = 75;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Franklin Gothic Medium", 12.25F, System.Drawing.FontStyle.Italic);
            this.label5.Location = new System.Drawing.Point(15, 105);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 21);
            this.label5.TabIndex = 74;
            this.label5.Text = "Vehiculo:";
            // 
            // dpRenta
            // 
            this.dpRenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.dpRenta.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dpRenta.Location = new System.Drawing.Point(534, 62);
            this.dpRenta.Name = "dpRenta";
            this.dpRenta.Size = new System.Drawing.Size(120, 26);
            this.dpRenta.TabIndex = 79;
            this.dpRenta.Value = new System.DateTime(2020, 6, 15, 0, 0, 0, 0);
            this.dpRenta.ValueChanged += new System.EventHandler(this.dpRenta_ValueChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Franklin Gothic Medium", 12.25F, System.Drawing.FontStyle.Italic);
            this.label7.Location = new System.Drawing.Point(373, 67);
            this.label7.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(99, 21);
            this.label7.TabIndex = 81;
            this.label7.Text = "Fecha renta:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Franklin Gothic Medium", 12.25F, System.Drawing.FontStyle.Italic);
            this.label8.Location = new System.Drawing.Point(373, 104);
            this.label8.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(139, 21);
            this.label8.TabIndex = 84;
            this.label8.Text = "Fecha devolución:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Franklin Gothic Medium", 12.25F, System.Drawing.FontStyle.Italic);
            this.label9.Location = new System.Drawing.Point(373, 141);
            this.label9.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(107, 21);
            this.label9.TabIndex = 85;
            this.label9.Text = "Días a rentar:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Franklin Gothic Medium", 12.25F, System.Drawing.FontStyle.Italic);
            this.label10.Location = new System.Drawing.Point(373, 170);
            this.label10.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(109, 21);
            this.label10.TabIndex = 87;
            this.label10.Text = "Coste por día:";
            // 
            // numericCostePorDia
            // 
            this.numericCostePorDia.DecimalPlaces = 2;
            this.numericCostePorDia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.numericCostePorDia.Location = new System.Drawing.Point(534, 168);
            this.numericCostePorDia.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numericCostePorDia.Name = "numericCostePorDia";
            this.numericCostePorDia.Size = new System.Drawing.Size(120, 26);
            this.numericCostePorDia.TabIndex = 88;
            this.numericCostePorDia.ValueChanged += new System.EventHandler(this.numericCostePorDia_ValueChanged);
            this.numericCostePorDia.KeyDown += new System.Windows.Forms.KeyEventHandler(this.numericCostePorDia_KeyDown);
            this.numericCostePorDia.KeyUp += new System.Windows.Forms.KeyEventHandler(this.numericCostePorDia_KeyUp);
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.txtDescripcion.Location = new System.Drawing.Point(797, 102);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(120, 26);
            this.txtDescripcion.TabIndex = 89;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Franklin Gothic Medium", 12.25F, System.Drawing.FontStyle.Italic);
            this.label11.Location = new System.Drawing.Point(680, 109);
            this.label11.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(99, 21);
            this.label11.TabIndex = 90;
            this.label11.Text = "Descripción:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Franklin Gothic Medium", 12.25F, System.Drawing.FontStyle.Italic);
            this.label13.Location = new System.Drawing.Point(680, 141);
            this.label13.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(63, 21);
            this.label13.TabIndex = 93;
            this.label13.Text = "Estado:";
            // 
            // cbEstado
            // 
            this.cbEstado.AutoSize = true;
            this.cbEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.cbEstado.Location = new System.Drawing.Point(797, 141);
            this.cbEstado.Name = "cbEstado";
            this.cbEstado.Size = new System.Drawing.Size(129, 24);
            this.cbEstado.TabIndex = 94;
            this.cbEstado.Text = "No disponible";
            this.cbEstado.UseVisualStyleBackColor = true;
            this.cbEstado.CheckedChanged += new System.EventHandler(this.cbEstado_CheckedChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Franklin Gothic Medium", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.LightGray;
            this.label14.Location = new System.Drawing.Point(20, 206);
            this.label14.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(97, 24);
            this.label14.TabIndex = 95;
            this.label14.Text = "Inspección";
            // 
            // gomaTI
            // 
            this.gomaTI.AutoSize = true;
            this.gomaTI.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.gomaTI.ForeColor = System.Drawing.Color.LightGray;
            this.gomaTI.Location = new System.Drawing.Point(234, 494);
            this.gomaTI.Name = "gomaTI";
            this.gomaTI.Size = new System.Drawing.Size(49, 24);
            this.gomaTI.TabIndex = 103;
            this.gomaTI.Text = "No";
            this.gomaTI.UseVisualStyleBackColor = true;
            this.gomaTI.CheckedChanged += new System.EventHandler(this.gomaTI_CheckedChanged);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Franklin Gothic Medium", 12.25F, System.Drawing.FontStyle.Italic);
            this.label15.ForeColor = System.Drawing.Color.LightGray;
            this.label15.Location = new System.Drawing.Point(20, 494);
            this.label15.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(179, 21);
            this.label15.TabIndex = 102;
            this.label15.Text = "Goma trasera izquierda";
            // 
            // gomaTD
            // 
            this.gomaTD.AutoSize = true;
            this.gomaTD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.gomaTD.ForeColor = System.Drawing.Color.LightGray;
            this.gomaTD.Location = new System.Drawing.Point(234, 464);
            this.gomaTD.Name = "gomaTD";
            this.gomaTD.Size = new System.Drawing.Size(49, 24);
            this.gomaTD.TabIndex = 101;
            this.gomaTD.Text = "No";
            this.gomaTD.UseVisualStyleBackColor = true;
            this.gomaTD.CheckedChanged += new System.EventHandler(this.gomaTD_CheckedChanged);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Franklin Gothic Medium", 12.25F, System.Drawing.FontStyle.Italic);
            this.label16.ForeColor = System.Drawing.Color.LightGray;
            this.label16.Location = new System.Drawing.Point(20, 465);
            this.label16.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(176, 21);
            this.label16.TabIndex = 100;
            this.label16.Text = "Goma trasera derecha:";
            // 
            // gomaDI
            // 
            this.gomaDI.AutoSize = true;
            this.gomaDI.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.gomaDI.ForeColor = System.Drawing.Color.LightGray;
            this.gomaDI.Location = new System.Drawing.Point(234, 434);
            this.gomaDI.Name = "gomaDI";
            this.gomaDI.Size = new System.Drawing.Size(49, 24);
            this.gomaDI.TabIndex = 99;
            this.gomaDI.Text = "No";
            this.gomaDI.UseVisualStyleBackColor = true;
            this.gomaDI.CheckedChanged += new System.EventHandler(this.gomaDI_CheckedChanged);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Franklin Gothic Medium", 12.25F, System.Drawing.FontStyle.Italic);
            this.label17.ForeColor = System.Drawing.Color.LightGray;
            this.label17.Location = new System.Drawing.Point(20, 437);
            this.label17.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(200, 21);
            this.label17.TabIndex = 98;
            this.label17.Text = "Goma delantera izquierda:";
            // 
            // gomaDD
            // 
            this.gomaDD.AutoSize = true;
            this.gomaDD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.gomaDD.ForeColor = System.Drawing.Color.LightGray;
            this.gomaDD.Location = new System.Drawing.Point(234, 404);
            this.gomaDD.Name = "gomaDD";
            this.gomaDD.Size = new System.Drawing.Size(49, 24);
            this.gomaDD.TabIndex = 97;
            this.gomaDD.Text = "No";
            this.gomaDD.UseVisualStyleBackColor = true;
            this.gomaDD.CheckedChanged += new System.EventHandler(this.gomaDD_CheckedChanged);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Franklin Gothic Medium", 12.25F, System.Drawing.FontStyle.Italic);
            this.label18.ForeColor = System.Drawing.Color.LightGray;
            this.label18.Location = new System.Drawing.Point(20, 407);
            this.label18.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(193, 21);
            this.label18.TabIndex = 96;
            this.label18.Text = "Goma delantera derecha:";
            // 
            // dgvRenta
            // 
            this.dgvRenta.AllowUserToAddRows = false;
            this.dgvRenta.AllowUserToDeleteRows = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.MediumBlue;
            this.dgvRenta.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvRenta.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvRenta.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvRenta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRenta.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.ID_INSPECCION,
            this.VEHICULO,
            this.CLIENTE,
            this.ID_EMPLEADO,
            this.CODIGO,
            this.ESTADO});
            this.dgvRenta.Location = new System.Drawing.Point(312, 232);
            this.dgvRenta.Name = "dgvRenta";
            this.dgvRenta.ReadOnly = true;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Empty;
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            this.dgvRenta.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvRenta.Size = new System.Drawing.Size(624, 283);
            this.dgvRenta.TabIndex = 104;
            this.dgvRenta.DoubleClick += new System.EventHandler(this.dgvRenta_DoubleClick);
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Visible = false;
            // 
            // ID_INSPECCION
            // 
            this.ID_INSPECCION.DataPropertyName = "ID_INSPECCION";
            this.ID_INSPECCION.HeaderText = "ID_INSPECCION";
            this.ID_INSPECCION.Name = "ID_INSPECCION";
            this.ID_INSPECCION.ReadOnly = true;
            this.ID_INSPECCION.Visible = false;
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
            // ID_EMPLEADO
            // 
            this.ID_EMPLEADO.DataPropertyName = "EMPLEADO";
            this.ID_EMPLEADO.HeaderText = "A cargo de";
            this.ID_EMPLEADO.Name = "ID_EMPLEADO";
            this.ID_EMPLEADO.ReadOnly = true;
            // 
            // CODIGO
            // 
            this.CODIGO.DataPropertyName = "CODIGO";
            this.CODIGO.HeaderText = "Codigo";
            this.CODIGO.Name = "CODIGO";
            this.CODIGO.ReadOnly = true;
            // 
            // ESTADO
            // 
            this.ESTADO.DataPropertyName = "ESTADO";
            this.ESTADO.HeaderText = "Estado";
            this.ESTADO.Name = "ESTADO";
            this.ESTADO.ReadOnly = true;
            // 
            // btnBorrar
            // 
            this.btnBorrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBorrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.btnBorrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBorrar.Location = new System.Drawing.Point(840, 521);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(96, 23);
            this.btnBorrar.TabIndex = 105;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.UseVisualStyleBackColor = false;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // btnCrear
            // 
            this.btnCrear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCrear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.btnCrear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCrear.Location = new System.Drawing.Point(840, 203);
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.Size = new System.Drawing.Size(96, 23);
            this.btnCrear.TabIndex = 106;
            this.btnCrear.Text = "Crear";
            this.btnCrear.UseVisualStyleBackColor = false;
            this.btnCrear.Click += new System.EventHandler(this.btnCrear_Click);
            // 
            // dpDevolucion
            // 
            this.dpDevolucion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.dpDevolucion.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dpDevolucion.Location = new System.Drawing.Point(534, 99);
            this.dpDevolucion.Name = "dpDevolucion";
            this.dpDevolucion.Size = new System.Drawing.Size(120, 26);
            this.dpDevolucion.TabIndex = 83;
            this.dpDevolucion.Value = new System.DateTime(2020, 6, 15, 0, 0, 0, 0);
            this.dpDevolucion.ValueChanged += new System.EventHandler(this.dpDevolucion_ValueChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Franklin Gothic Medium", 12.25F, System.Drawing.FontStyle.Italic);
            this.label6.Location = new System.Drawing.Point(680, 62);
            this.label6.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 21);
            this.label6.TabIndex = 107;
            this.label6.Text = "Total:";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Franklin Gothic Medium", 12.25F, System.Drawing.FontStyle.Italic);
            this.lblTotal.Location = new System.Drawing.Point(793, 62);
            this.lblTotal.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(44, 21);
            this.lblTotal.TabIndex = 108;
            this.lblTotal.Text = "0.00";
            // 
            // lblDias
            // 
            this.lblDias.AutoSize = true;
            this.lblDias.Font = new System.Drawing.Font("Franklin Gothic Medium", 12.25F, System.Drawing.FontStyle.Italic);
            this.lblDias.Location = new System.Drawing.Point(549, 141);
            this.lblDias.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblDias.Name = "lblDias";
            this.lblDias.Size = new System.Drawing.Size(20, 21);
            this.lblDias.TabIndex = 109;
            this.lblDias.Text = "0";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Franklin Gothic Medium", 12.25F, System.Drawing.FontStyle.Italic);
            this.label12.Location = new System.Drawing.Point(612, 141);
            this.label12.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(42, 21);
            this.label12.TabIndex = 110;
            this.label12.Text = "Dias";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Franklin Gothic Medium", 12.25F, System.Drawing.FontStyle.Italic);
            this.label19.Location = new System.Drawing.Point(680, 177);
            this.label19.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(64, 21);
            this.label19.TabIndex = 111;
            this.label19.Text = "Codigo:";
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Font = new System.Drawing.Font("Franklin Gothic Medium", 12.25F, System.Drawing.FontStyle.Italic);
            this.lblCodigo.Location = new System.Drawing.Point(793, 174);
            this.lblCodigo.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(0, 21);
            this.lblCodigo.TabIndex = 112;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(684, 203);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(96, 23);
            this.button1.TabIndex = 113;
            this.button1.Text = "Limpiar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnExportar
            // 
            this.btnExportar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExportar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.btnExportar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExportar.Location = new System.Drawing.Point(683, 521);
            this.btnExportar.Name = "btnExportar";
            this.btnExportar.Size = new System.Drawing.Size(96, 23);
            this.btnExportar.TabIndex = 114;
            this.btnExportar.Text = "Exportar";
            this.btnExportar.UseVisualStyleBackColor = false;
            this.btnExportar.Click += new System.EventHandler(this.btnExportar_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(12, 11);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(38, 30);
            this.button2.TabIndex = 115;
            this.button2.Text = "X";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(308, 206);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(70, 20);
            this.label20.TabIndex = 117;
            this.label20.Text = "Buscar:";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.textBox1.Location = new System.Drawing.Point(399, 202);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(221, 26);
            this.textBox1.TabIndex = 116;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // RentaVehiculo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(954, 545);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnExportar);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblCodigo);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.lblDias);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnCrear);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.dgvRenta);
            this.Controls.Add(this.gomaTI);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.gomaTD);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.gomaDI);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.gomaDD);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.cbEstado);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.numericCostePorDia);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dpDevolucion);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dpRenta);
            this.Controls.Add(this.cmbVehiculo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cristalesRotos);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.gato);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.gomaRepuesto);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.rayaduras);
            this.Controls.Add(this.cmbCliente);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbCantidadCombustible);
            this.Controls.Add(this.lblTipoVehiculo);
            this.Controls.Add(this.lblNumeroPlaca);
            this.Controls.Add(this.lblNumeroChasis);
            this.ForeColor = System.Drawing.Color.LightGray;
            this.MinimumSize = new System.Drawing.Size(970, 584);
            this.Name = "RentaVehiculo";
            this.Text = "RentaVehiculo";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.RentaVehiculo_FormClosed);
            this.Load += new System.EventHandler(this.RentaVehiculo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericCostePorDia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRenta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox cristalesRotos;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox gato;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox gomaRepuesto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox rayaduras;
        private System.Windows.Forms.ComboBox cmbCliente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbCantidadCombustible;
        private System.Windows.Forms.Label lblTipoVehiculo;
        private System.Windows.Forms.Label lblNumeroPlaca;
        private System.Windows.Forms.Label lblNumeroChasis;
        private System.Windows.Forms.ComboBox cmbVehiculo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dpRenta;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.NumericUpDown numericCostePorDia;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.CheckBox cbEstado;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.CheckBox gomaTI;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.CheckBox gomaTD;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.CheckBox gomaDI;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.CheckBox gomaDD;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.DataGridView dgvRenta;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.Button btnCrear;
        private System.Windows.Forms.DateTimePicker dpDevolucion;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblDias;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnExportar;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_INSPECCION;
        private System.Windows.Forms.DataGridViewTextBoxColumn VEHICULO;
        private System.Windows.Forms.DataGridViewTextBoxColumn CLIENTE;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_EMPLEADO;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO;
        private System.Windows.Forms.DataGridViewTextBoxColumn ESTADO;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox textBox1;
    }
}