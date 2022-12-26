
namespace WSA
{
    partial class FrmSalida
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSalida));
            this.btnConectar = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.lblConexion = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.txtObservaciones = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.btnObtenerPeso = new System.Windows.Forms.Button();
            this.txtPesoSalida = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.dtpFechaEntrada = new System.Windows.Forms.DateTimePicker();
            this.txtPesoEntrada = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.mySerialPort = new System.IO.Ports.SerialPort(this.components);
            this.label16 = new System.Windows.Forms.Label();
            this.dtpHoraEntrada = new System.Windows.Forms.DateTimePicker();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtPesoBascula = new System.Windows.Forms.TextBox();
            this.lblConsultarBarcos = new System.Windows.Forms.LinkLabel();
            this.lblConsultarProductos = new System.Windows.Forms.LinkLabel();
            this.lblConsultarClientes = new System.Windows.Forms.LinkLabel();
            this.lblConsultarConductores = new System.Windows.Forms.LinkLabel();
            this.txtEnvioN = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtBarco = new System.Windows.Forms.TextBox();
            this.txtCodigoBarco = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtProducto = new System.Windows.Forms.TextBox();
            this.txtCodigoProducto = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtCliente = new System.Windows.Forms.TextBox();
            this.txtCodigoCliente = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCia = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPlacaRastra = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPlacaCabezal = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtConductor = new System.Windows.Forms.TextBox();
            this.txtCodigoConductor = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnConectar
            // 
            this.btnConectar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnConectar.BackColor = System.Drawing.Color.DarkGreen;
            this.btnConectar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnConectar.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConectar.ForeColor = System.Drawing.Color.White;
            this.btnConectar.Location = new System.Drawing.Point(1200, 203);
            this.btnConectar.Name = "btnConectar";
            this.btnConectar.Size = new System.Drawing.Size(88, 28);
            this.btnConectar.TabIndex = 16;
            this.btnConectar.Text = "Conectar";
            this.btnConectar.UseVisualStyleBackColor = false;
            this.btnConectar.Click += new System.EventHandler(this.btnConectar_Click);
            // 
            // label13
            // 
            this.label13.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(701, 199);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(298, 18);
            this.label13.TabIndex = 64;
            this.label13.Text = "Estado de conexión con la báscula:";
            // 
            // lblConexion
            // 
            this.lblConexion.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblConexion.AutoSize = true;
            this.lblConexion.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConexion.ForeColor = System.Drawing.Color.Red;
            this.lblConexion.Location = new System.Drawing.Point(1005, 203);
            this.lblConexion.Name = "lblConexion";
            this.lblConexion.Size = new System.Drawing.Size(99, 14);
            this.lblConexion.TabIndex = 63;
            this.lblConexion.Text = "Desconectado";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCancelar.BackColor = System.Drawing.Color.DarkBlue;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCancelar.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.Location = new System.Drawing.Point(1191, 547);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(105, 27);
            this.btnCancelar.TabIndex = 22;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnGuardar.BackColor = System.Drawing.Color.DarkBlue;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGuardar.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.Color.White;
            this.btnGuardar.Location = new System.Drawing.Point(1070, 547);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(105, 27);
            this.btnGuardar.TabIndex = 21;
            this.btnGuardar.Text = "Guardar salida";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // txtObservaciones
            // 
            this.txtObservaciones.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtObservaciones.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtObservaciones.Location = new System.Drawing.Point(819, 362);
            this.txtObservaciones.Multiline = true;
            this.txtObservaciones.Name = "txtObservaciones";
            this.txtObservaciones.Size = new System.Drawing.Size(401, 142);
            this.txtObservaciones.TabIndex = 20;
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(679, 365);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(134, 18);
            this.label12.TabIndex = 59;
            this.label12.Text = "Observaciones:";
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(701, 152);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(169, 18);
            this.label11.TabIndex = 58;
            this.label11.Text = "Lectura en báscula:";
            // 
            // btnObtenerPeso
            // 
            this.btnObtenerPeso.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnObtenerPeso.BackColor = System.Drawing.Color.DarkGreen;
            this.btnObtenerPeso.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnObtenerPeso.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnObtenerPeso.ForeColor = System.Drawing.Color.White;
            this.btnObtenerPeso.Location = new System.Drawing.Point(1017, 306);
            this.btnObtenerPeso.Name = "btnObtenerPeso";
            this.btnObtenerPeso.Size = new System.Drawing.Size(133, 28);
            this.btnObtenerPeso.TabIndex = 19;
            this.btnObtenerPeso.Text = "Obtener peso";
            this.btnObtenerPeso.UseVisualStyleBackColor = false;
            this.btnObtenerPeso.Click += new System.EventHandler(this.txtObtenerPeso_Click);
            // 
            // txtPesoSalida
            // 
            this.txtPesoSalida.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPesoSalida.BackColor = System.Drawing.Color.White;
            this.txtPesoSalida.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPesoSalida.Location = new System.Drawing.Point(819, 307);
            this.txtPesoSalida.Name = "txtPesoSalida";
            this.txtPesoSalida.ReadOnly = true;
            this.txtPesoSalida.Size = new System.Drawing.Size(179, 27);
            this.txtPesoSalida.TabIndex = 18;
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(698, 311);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(109, 18);
            this.label10.TabIndex = 55;
            this.label10.Text = "Peso salida:";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(543, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(225, 25);
            this.label1.TabIndex = 33;
            this.label1.Text = "Salida de vehículo";
            // 
            // label14
            // 
            this.label14.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(121, 150);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(137, 18);
            this.label14.TabIndex = 67;
            this.label14.Text = "Fecha entrada: ";
            // 
            // dtpFechaEntrada
            // 
            this.dtpFechaEntrada.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtpFechaEntrada.CalendarMonthBackground = System.Drawing.Color.White;
            this.dtpFechaEntrada.Enabled = false;
            this.dtpFechaEntrada.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaEntrada.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaEntrada.Location = new System.Drawing.Point(258, 146);
            this.dtpFechaEntrada.Name = "dtpFechaEntrada";
            this.dtpFechaEntrada.Size = new System.Drawing.Size(115, 27);
            this.dtpFechaEntrada.TabIndex = 0;
            // 
            // txtPesoEntrada
            // 
            this.txtPesoEntrada.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPesoEntrada.BackColor = System.Drawing.Color.White;
            this.txtPesoEntrada.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPesoEntrada.Location = new System.Drawing.Point(819, 256);
            this.txtPesoEntrada.Name = "txtPesoEntrada";
            this.txtPesoEntrada.ReadOnly = true;
            this.txtPesoEntrada.Size = new System.Drawing.Size(179, 27);
            this.txtPesoEntrada.TabIndex = 17;
            // 
            // label15
            // 
            this.label15.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(692, 260);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(123, 18);
            this.label15.TabIndex = 69;
            this.label15.Text = "Peso entrada:";
            // 
            // label16
            // 
            this.label16.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(396, 150);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(128, 18);
            this.label16.TabIndex = 71;
            this.label16.Text = "Hora entrada: ";
            // 
            // dtpHoraEntrada
            // 
            this.dtpHoraEntrada.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtpHoraEntrada.CalendarMonthBackground = System.Drawing.Color.White;
            this.dtpHoraEntrada.Enabled = false;
            this.dtpHoraEntrada.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpHoraEntrada.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpHoraEntrada.Location = new System.Drawing.Point(520, 146);
            this.dtpHoraEntrada.Name = "dtpHoraEntrada";
            this.dtpHoraEntrada.Size = new System.Drawing.Size(102, 27);
            this.dtpHoraEntrada.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.DarkGreen;
            this.panel2.Location = new System.Drawing.Point(-1, 617);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1492, 30);
            this.panel2.TabIndex = 74;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.DarkBlue;
            this.panel1.Location = new System.Drawing.Point(-1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1492, 30);
            this.panel1.TabIndex = 73;
            // 
            // txtPesoBascula
            // 
            this.txtPesoBascula.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPesoBascula.BackColor = System.Drawing.Color.Black;
            this.txtPesoBascula.Font = new System.Drawing.Font("Consolas", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPesoBascula.ForeColor = System.Drawing.Color.White;
            this.txtPesoBascula.Location = new System.Drawing.Point(876, 135);
            this.txtPesoBascula.Multiline = true;
            this.txtPesoBascula.Name = "txtPesoBascula";
            this.txtPesoBascula.ReadOnly = true;
            this.txtPesoBascula.Size = new System.Drawing.Size(412, 46);
            this.txtPesoBascula.TabIndex = 15;
            this.txtPesoBascula.Text = "0.00 Kg";
            this.txtPesoBascula.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblConsultarBarcos
            // 
            this.lblConsultarBarcos.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblConsultarBarcos.AutoSize = true;
            this.lblConsultarBarcos.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConsultarBarcos.Location = new System.Drawing.Point(502, 508);
            this.lblConsultarBarcos.Name = "lblConsultarBarcos";
            this.lblConsultarBarcos.Size = new System.Drawing.Size(119, 16);
            this.lblConsultarBarcos.TabIndex = 96;
            this.lblConsultarBarcos.TabStop = true;
            this.lblConsultarBarcos.Text = "Consultar barcos";
            this.lblConsultarBarcos.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblConsultarBarcos_LinkClicked);
            // 
            // lblConsultarProductos
            // 
            this.lblConsultarProductos.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblConsultarProductos.AutoSize = true;
            this.lblConsultarProductos.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConsultarProductos.Location = new System.Drawing.Point(487, 431);
            this.lblConsultarProductos.Name = "lblConsultarProductos";
            this.lblConsultarProductos.Size = new System.Drawing.Size(141, 16);
            this.lblConsultarProductos.TabIndex = 92;
            this.lblConsultarProductos.TabStop = true;
            this.lblConsultarProductos.Text = "Consultar productos";
            this.lblConsultarProductos.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblConsultarProductos_LinkClicked);
            // 
            // lblConsultarClientes
            // 
            this.lblConsultarClientes.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblConsultarClientes.AutoSize = true;
            this.lblConsultarClientes.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConsultarClientes.Location = new System.Drawing.Point(498, 362);
            this.lblConsultarClientes.Name = "lblConsultarClientes";
            this.lblConsultarClientes.Size = new System.Drawing.Size(126, 16);
            this.lblConsultarClientes.TabIndex = 88;
            this.lblConsultarClientes.TabStop = true;
            this.lblConsultarClientes.Text = "Consultar clientes";
            this.lblConsultarClientes.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblConsultarClientes_LinkClicked);
            // 
            // lblConsultarConductores
            // 
            this.lblConsultarConductores.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblConsultarConductores.AutoSize = true;
            this.lblConsultarConductores.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConsultarConductores.Location = new System.Drawing.Point(467, 186);
            this.lblConsultarConductores.Name = "lblConsultarConductores";
            this.lblConsultarConductores.Size = new System.Drawing.Size(157, 16);
            this.lblConsultarConductores.TabIndex = 78;
            this.lblConsultarConductores.TabStop = true;
            this.lblConsultarConductores.Text = "Consultar conductores";
            this.lblConsultarConductores.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblConsultarConductores_LinkClicked);
            // 
            // txtEnvioN
            // 
            this.txtEnvioN.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtEnvioN.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEnvioN.Location = new System.Drawing.Point(531, 313);
            this.txtEnvioN.Name = "txtEnvioN";
            this.txtEnvioN.Size = new System.Drawing.Size(91, 27);
            this.txtEnvioN.TabIndex = 83;
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(396, 322);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(129, 18);
            this.label9.TabIndex = 98;
            this.label9.Text = "Contrato / OC:";
            // 
            // txtBarco
            // 
            this.txtBarco.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtBarco.BackColor = System.Drawing.Color.White;
            this.txtBarco.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBarco.Location = new System.Drawing.Point(325, 527);
            this.txtBarco.Name = "txtBarco";
            this.txtBarco.ReadOnly = true;
            this.txtBarco.Size = new System.Drawing.Size(297, 27);
            this.txtBarco.TabIndex = 95;
            // 
            // txtCodigoBarco
            // 
            this.txtCodigoBarco.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtCodigoBarco.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigoBarco.Location = new System.Drawing.Point(272, 527);
            this.txtCodigoBarco.Name = "txtCodigoBarco";
            this.txtCodigoBarco.Size = new System.Drawing.Size(47, 27);
            this.txtCodigoBarco.TabIndex = 94;
            this.txtCodigoBarco.Leave += new System.EventHandler(this.txtCodigoBarco_Leave);
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(105, 530);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(152, 18);
            this.label8.TabIndex = 97;
            this.label8.Text = "Código del barco:";
            // 
            // txtProducto
            // 
            this.txtProducto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtProducto.BackColor = System.Drawing.Color.White;
            this.txtProducto.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProducto.Location = new System.Drawing.Point(325, 450);
            this.txtProducto.Name = "txtProducto";
            this.txtProducto.ReadOnly = true;
            this.txtProducto.Size = new System.Drawing.Size(297, 27);
            this.txtProducto.TabIndex = 91;
            // 
            // txtCodigoProducto
            // 
            this.txtCodigoProducto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtCodigoProducto.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigoProducto.Location = new System.Drawing.Point(272, 450);
            this.txtCodigoProducto.Name = "txtCodigoProducto";
            this.txtCodigoProducto.Size = new System.Drawing.Size(47, 27);
            this.txtCodigoProducto.TabIndex = 89;
            this.txtCodigoProducto.Leave += new System.EventHandler(this.txtCodigoProducto_Leave);
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(97, 453);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(179, 18);
            this.label7.TabIndex = 93;
            this.label7.Text = "Código del producto:";
            // 
            // txtCliente
            // 
            this.txtCliente.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtCliente.BackColor = System.Drawing.Color.White;
            this.txtCliente.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCliente.Location = new System.Drawing.Point(325, 381);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.ReadOnly = true;
            this.txtCliente.Size = new System.Drawing.Size(297, 27);
            this.txtCliente.TabIndex = 87;
            // 
            // txtCodigoCliente
            // 
            this.txtCodigoCliente.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtCodigoCliente.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigoCliente.Location = new System.Drawing.Point(272, 381);
            this.txtCodigoCliente.Name = "txtCodigoCliente";
            this.txtCodigoCliente.Size = new System.Drawing.Size(47, 27);
            this.txtCodigoCliente.TabIndex = 85;
            this.txtCodigoCliente.Leave += new System.EventHandler(this.txtCodigoCliente_Leave);
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(103, 384);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(163, 18);
            this.label6.TabIndex = 90;
            this.label6.Text = "Código del cliente:";
            // 
            // txtCia
            // 
            this.txtCia.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtCia.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCia.Location = new System.Drawing.Point(298, 316);
            this.txtCia.Name = "txtCia";
            this.txtCia.Size = new System.Drawing.Size(91, 27);
            this.txtCia.TabIndex = 82;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(91, 322);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(208, 18);
            this.label5.TabIndex = 86;
            this.label5.Text = "Compañia transportista:";
            // 
            // txtPlacaRastra
            // 
            this.txtPlacaRastra.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPlacaRastra.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPlacaRastra.Location = new System.Drawing.Point(497, 263);
            this.txtPlacaRastra.MaxLength = 7;
            this.txtPlacaRastra.Name = "txtPlacaRastra";
            this.txtPlacaRastra.Size = new System.Drawing.Size(125, 27);
            this.txtPlacaRastra.TabIndex = 81;
            this.txtPlacaRastra.TextChanged += new System.EventHandler(this.txtPlacaRastra_TextChanged);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(379, 267);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 18);
            this.label4.TabIndex = 84;
            this.label4.Text = "Placa rastra:";
            // 
            // txtPlacaCabezal
            // 
            this.txtPlacaCabezal.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPlacaCabezal.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPlacaCabezal.Location = new System.Drawing.Point(245, 263);
            this.txtPlacaCabezal.MaxLength = 7;
            this.txtPlacaCabezal.Name = "txtPlacaCabezal";
            this.txtPlacaCabezal.Size = new System.Drawing.Size(128, 27);
            this.txtPlacaCabezal.TabIndex = 79;
            this.txtPlacaCabezal.TextChanged += new System.EventHandler(this.txtPlacaCabezal_TextChanged);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(111, 267);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 18);
            this.label3.TabIndex = 80;
            this.label3.Text = "Placa cabezal:";
            // 
            // txtConductor
            // 
            this.txtConductor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtConductor.BackColor = System.Drawing.Color.White;
            this.txtConductor.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConductor.Location = new System.Drawing.Point(333, 205);
            this.txtConductor.Name = "txtConductor";
            this.txtConductor.ReadOnly = true;
            this.txtConductor.Size = new System.Drawing.Size(289, 27);
            this.txtConductor.TabIndex = 77;
            // 
            // txtCodigoConductor
            // 
            this.txtCodigoConductor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtCodigoConductor.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigoConductor.Location = new System.Drawing.Point(280, 205);
            this.txtCodigoConductor.Name = "txtCodigoConductor";
            this.txtCodigoConductor.Size = new System.Drawing.Size(47, 27);
            this.txtCodigoConductor.TabIndex = 75;
            this.txtCodigoConductor.Leave += new System.EventHandler(this.txtCodigoConductor_Leave);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(94, 208);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(187, 18);
            this.label2.TabIndex = 76;
            this.label2.Text = "Código del conductor:";
            // 
            // FrmSalida
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1367, 647);
            this.Controls.Add(this.lblConsultarBarcos);
            this.Controls.Add(this.lblConsultarProductos);
            this.Controls.Add(this.lblConsultarClientes);
            this.Controls.Add(this.lblConsultarConductores);
            this.Controls.Add(this.txtEnvioN);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtBarco);
            this.Controls.Add(this.txtCodigoBarco);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtProducto);
            this.Controls.Add(this.txtCodigoProducto);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtCliente);
            this.Controls.Add(this.txtCodigoCliente);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtCia);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtPlacaRastra);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtPlacaCabezal);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtConductor);
            this.Controls.Add(this.txtCodigoConductor);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtPesoBascula);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dtpHoraEntrada);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.txtPesoEntrada);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.dtpFechaEntrada);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.btnConectar);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.lblConexion);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.txtObservaciones);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.btnObtenerPeso);
            this.Controls.Add(this.txtPesoSalida);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmSalida";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Salida de vehículo";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmSalida_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConectar;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lblConexion;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.TextBox txtObservaciones;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnObtenerPeso;
        private System.Windows.Forms.TextBox txtPesoSalida;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.DateTimePicker dtpFechaEntrada;
        private System.Windows.Forms.TextBox txtPesoEntrada;
        private System.Windows.Forms.Label label15;
        private System.IO.Ports.SerialPort mySerialPort;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.DateTimePicker dtpHoraEntrada;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtPesoBascula;
        private System.Windows.Forms.LinkLabel lblConsultarBarcos;
        private System.Windows.Forms.LinkLabel lblConsultarProductos;
        private System.Windows.Forms.LinkLabel lblConsultarClientes;
        private System.Windows.Forms.LinkLabel lblConsultarConductores;
        private System.Windows.Forms.TextBox txtEnvioN;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtBarco;
        private System.Windows.Forms.TextBox txtCodigoBarco;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtProducto;
        private System.Windows.Forms.TextBox txtCodigoProducto;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtCliente;
        private System.Windows.Forms.TextBox txtCodigoCliente;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtCia;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtPlacaRastra;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPlacaCabezal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtConductor;
        private System.Windows.Forms.TextBox txtCodigoConductor;
        private System.Windows.Forms.Label label2;
    }
}