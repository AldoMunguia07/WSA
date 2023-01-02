
namespace WSA
{
    partial class FrmIngreso
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmIngreso));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCodigoConductor = new System.Windows.Forms.TextBox();
            this.txtConductor = new System.Windows.Forms.TextBox();
            this.txtPlacaCabezal = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCia = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCliente = new System.Windows.Forms.TextBox();
            this.txtCodigoCliente = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtProducto = new System.Windows.Forms.TextBox();
            this.txtCodigoProducto = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtBarco = new System.Windows.Forms.TextBox();
            this.txtCodigoBarco = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtEnvioN = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtPesoBascula = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtPesoEntrada = new System.Windows.Forms.TextBox();
            this.btnObtenerPeso = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtObservaciones = new System.Windows.Forms.TextBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.lblConexion = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.btnConectar = new System.Windows.Forms.Button();
            this.lblConsultarConductores = new System.Windows.Forms.LinkLabel();
            this.lblConsultarClientes = new System.Windows.Forms.LinkLabel();
            this.lblConsultarProductos = new System.Windows.Forms.LinkLabel();
            this.lblConsultarBarcos = new System.Windows.Forms.LinkLabel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.rbdTara = new System.Windows.Forms.RadioButton();
            this.rbdBruto = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(520, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(279, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingreso de vehículo";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(84, 205);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(187, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Código del conductor:";
            // 
            // txtCodigoConductor
            // 
            this.txtCodigoConductor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtCodigoConductor.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigoConductor.Location = new System.Drawing.Point(270, 202);
            this.txtCodigoConductor.Name = "txtCodigoConductor";
            this.txtCodigoConductor.Size = new System.Drawing.Size(47, 27);
            this.txtCodigoConductor.TabIndex = 0;
            this.txtCodigoConductor.Leave += new System.EventHandler(this.txtCodigoConductor_Leave);
            // 
            // txtConductor
            // 
            this.txtConductor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtConductor.BackColor = System.Drawing.Color.White;
            this.txtConductor.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConductor.Location = new System.Drawing.Point(323, 202);
            this.txtConductor.Name = "txtConductor";
            this.txtConductor.ReadOnly = true;
            this.txtConductor.Size = new System.Drawing.Size(289, 27);
            this.txtConductor.TabIndex = 1;
            // 
            // txtPlacaCabezal
            // 
            this.txtPlacaCabezal.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPlacaCabezal.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPlacaCabezal.Location = new System.Drawing.Point(270, 258);
            this.txtPlacaCabezal.MaxLength = 7;
            this.txtPlacaCabezal.Name = "txtPlacaCabezal";
            this.txtPlacaCabezal.Size = new System.Drawing.Size(128, 27);
            this.txtPlacaCabezal.TabIndex = 3;
            this.txtPlacaCabezal.TextChanged += new System.EventHandler(this.txtPlacaCabezal_TextChanged);
            this.txtPlacaCabezal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPlacaCabezal_KeyPress);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(107, 262);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(157, 18);
            this.label3.TabIndex = 4;
            this.label3.Text = "Placa del cabezal:";
            // 
            // txtCia
            // 
            this.txtCia.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtCia.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCia.Location = new System.Drawing.Point(288, 313);
            this.txtCia.Name = "txtCia";
            this.txtCia.Size = new System.Drawing.Size(91, 27);
            this.txtCia.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(81, 319);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(208, 18);
            this.label5.TabIndex = 8;
            this.label5.Text = "Compañía transportista:";
            // 
            // txtCliente
            // 
            this.txtCliente.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtCliente.BackColor = System.Drawing.Color.White;
            this.txtCliente.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCliente.Location = new System.Drawing.Point(315, 378);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.ReadOnly = true;
            this.txtCliente.Size = new System.Drawing.Size(297, 27);
            this.txtCliente.TabIndex = 8;
            // 
            // txtCodigoCliente
            // 
            this.txtCodigoCliente.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtCodigoCliente.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigoCliente.Location = new System.Drawing.Point(262, 378);
            this.txtCodigoCliente.Name = "txtCodigoCliente";
            this.txtCodigoCliente.Size = new System.Drawing.Size(47, 27);
            this.txtCodigoCliente.TabIndex = 7;
            this.txtCodigoCliente.Leave += new System.EventHandler(this.txtCodigoCliente_Leave);
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(93, 381);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(163, 18);
            this.label6.TabIndex = 10;
            this.label6.Text = "Código del cliente:";
            // 
            // txtProducto
            // 
            this.txtProducto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtProducto.BackColor = System.Drawing.Color.White;
            this.txtProducto.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProducto.Location = new System.Drawing.Point(315, 447);
            this.txtProducto.Name = "txtProducto";
            this.txtProducto.ReadOnly = true;
            this.txtProducto.Size = new System.Drawing.Size(297, 27);
            this.txtProducto.TabIndex = 11;
            // 
            // txtCodigoProducto
            // 
            this.txtCodigoProducto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtCodigoProducto.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigoProducto.Location = new System.Drawing.Point(262, 447);
            this.txtCodigoProducto.Name = "txtCodigoProducto";
            this.txtCodigoProducto.Size = new System.Drawing.Size(47, 27);
            this.txtCodigoProducto.TabIndex = 10;
            this.txtCodigoProducto.Leave += new System.EventHandler(this.txtCodigoProducto_Leave);
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(87, 450);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(179, 18);
            this.label7.TabIndex = 13;
            this.label7.Text = "Código del producto:";
            // 
            // txtBarco
            // 
            this.txtBarco.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtBarco.BackColor = System.Drawing.Color.White;
            this.txtBarco.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBarco.Location = new System.Drawing.Point(315, 524);
            this.txtBarco.Name = "txtBarco";
            this.txtBarco.ReadOnly = true;
            this.txtBarco.Size = new System.Drawing.Size(297, 27);
            this.txtBarco.TabIndex = 14;
            // 
            // txtCodigoBarco
            // 
            this.txtCodigoBarco.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtCodigoBarco.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigoBarco.Location = new System.Drawing.Point(262, 524);
            this.txtCodigoBarco.Name = "txtCodigoBarco";
            this.txtCodigoBarco.Size = new System.Drawing.Size(47, 27);
            this.txtCodigoBarco.TabIndex = 13;
            this.txtCodigoBarco.Leave += new System.EventHandler(this.txtCodigoBarco_Leave);
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(95, 527);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(152, 18);
            this.label8.TabIndex = 16;
            this.label8.Text = "Código del barco:";
            // 
            // txtEnvioN
            // 
            this.txtEnvioN.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtEnvioN.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEnvioN.Location = new System.Drawing.Point(521, 310);
            this.txtEnvioN.Name = "txtEnvioN";
            this.txtEnvioN.Size = new System.Drawing.Size(91, 27);
            this.txtEnvioN.TabIndex = 6;
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(386, 319);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(129, 18);
            this.label9.TabIndex = 19;
            this.label9.Text = "Contrato / OC:";
            // 
            // txtPesoBascula
            // 
            this.txtPesoBascula.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPesoBascula.BackColor = System.Drawing.Color.Black;
            this.txtPesoBascula.Font = new System.Drawing.Font("Consolas", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPesoBascula.ForeColor = System.Drawing.Color.White;
            this.txtPesoBascula.Location = new System.Drawing.Point(867, 188);
            this.txtPesoBascula.Multiline = true;
            this.txtPesoBascula.Name = "txtPesoBascula";
            this.txtPesoBascula.ReadOnly = true;
            this.txtPesoBascula.Size = new System.Drawing.Size(412, 46);
            this.txtPesoBascula.TabIndex = 16;
            this.txtPesoBascula.Text = "0.00 Kg";
            this.txtPesoBascula.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(691, 309);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(123, 18);
            this.label10.TabIndex = 22;
            this.label10.Text = "Peso entrada:";
            // 
            // txtPesoEntrada
            // 
            this.txtPesoEntrada.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPesoEntrada.BackColor = System.Drawing.Color.White;
            this.txtPesoEntrada.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPesoEntrada.Location = new System.Drawing.Point(815, 305);
            this.txtPesoEntrada.Name = "txtPesoEntrada";
            this.txtPesoEntrada.ReadOnly = true;
            this.txtPesoEntrada.Size = new System.Drawing.Size(179, 27);
            this.txtPesoEntrada.TabIndex = 18;
            // 
            // btnObtenerPeso
            // 
            this.btnObtenerPeso.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnObtenerPeso.BackColor = System.Drawing.Color.DarkGreen;
            this.btnObtenerPeso.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnObtenerPeso.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnObtenerPeso.ForeColor = System.Drawing.Color.White;
            this.btnObtenerPeso.Location = new System.Drawing.Point(1014, 304);
            this.btnObtenerPeso.Name = "btnObtenerPeso";
            this.btnObtenerPeso.Size = new System.Drawing.Size(136, 28);
            this.btnObtenerPeso.TabIndex = 19;
            this.btnObtenerPeso.Text = "Obtener peso";
            this.btnObtenerPeso.UseVisualStyleBackColor = false;
            this.btnObtenerPeso.Click += new System.EventHandler(this.txtObtenerPeso_Click);
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(692, 205);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(169, 18);
            this.label11.TabIndex = 25;
            this.label11.Text = "Lectura en báscula:";
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(692, 464);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(134, 18);
            this.label12.TabIndex = 26;
            this.label12.Text = "Observaciones:";
            // 
            // txtObservaciones
            // 
            this.txtObservaciones.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtObservaciones.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtObservaciones.Location = new System.Drawing.Point(835, 466);
            this.txtObservaciones.Multiline = true;
            this.txtObservaciones.Name = "txtObservaciones";
            this.txtObservaciones.Size = new System.Drawing.Size(444, 85);
            this.txtObservaciones.TabIndex = 24;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCancelar.BackColor = System.Drawing.Color.DarkBlue;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCancelar.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.Location = new System.Drawing.Point(1174, 588);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(105, 27);
            this.btnCancelar.TabIndex = 26;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // lblConexion
            // 
            this.lblConexion.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblConexion.AutoSize = true;
            this.lblConexion.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConexion.ForeColor = System.Drawing.Color.Red;
            this.lblConexion.Location = new System.Drawing.Point(996, 259);
            this.lblConexion.Name = "lblConexion";
            this.lblConexion.Size = new System.Drawing.Size(99, 14);
            this.lblConexion.TabIndex = 30;
            this.lblConexion.Text = "Desconectado";
            // 
            // label13
            // 
            this.label13.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(692, 257);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(298, 18);
            this.label13.TabIndex = 31;
            this.label13.Text = "Estado de conexión con la báscula:";
            // 
            // btnConectar
            // 
            this.btnConectar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnConectar.BackColor = System.Drawing.Color.DarkGreen;
            this.btnConectar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnConectar.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConectar.ForeColor = System.Drawing.Color.White;
            this.btnConectar.Location = new System.Drawing.Point(1173, 252);
            this.btnConectar.Name = "btnConectar";
            this.btnConectar.Size = new System.Drawing.Size(106, 28);
            this.btnConectar.TabIndex = 17;
            this.btnConectar.Text = "Conectar";
            this.btnConectar.UseVisualStyleBackColor = false;
            this.btnConectar.Click += new System.EventHandler(this.btnConectar_Click);
            // 
            // lblConsultarConductores
            // 
            this.lblConsultarConductores.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblConsultarConductores.AutoSize = true;
            this.lblConsultarConductores.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConsultarConductores.Location = new System.Drawing.Point(457, 183);
            this.lblConsultarConductores.Name = "lblConsultarConductores";
            this.lblConsultarConductores.Size = new System.Drawing.Size(157, 16);
            this.lblConsultarConductores.TabIndex = 2;
            this.lblConsultarConductores.TabStop = true;
            this.lblConsultarConductores.Text = "Consultar conductores";
            this.lblConsultarConductores.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblConsultarConductores_LinkClicked);
            // 
            // lblConsultarClientes
            // 
            this.lblConsultarClientes.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblConsultarClientes.AutoSize = true;
            this.lblConsultarClientes.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConsultarClientes.Location = new System.Drawing.Point(488, 359);
            this.lblConsultarClientes.Name = "lblConsultarClientes";
            this.lblConsultarClientes.Size = new System.Drawing.Size(126, 16);
            this.lblConsultarClientes.TabIndex = 9;
            this.lblConsultarClientes.TabStop = true;
            this.lblConsultarClientes.Text = "Consultar clientes";
            this.lblConsultarClientes.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblConsultarClientes_LinkClicked);
            // 
            // lblConsultarProductos
            // 
            this.lblConsultarProductos.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblConsultarProductos.AutoSize = true;
            this.lblConsultarProductos.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConsultarProductos.Location = new System.Drawing.Point(477, 428);
            this.lblConsultarProductos.Name = "lblConsultarProductos";
            this.lblConsultarProductos.Size = new System.Drawing.Size(141, 16);
            this.lblConsultarProductos.TabIndex = 12;
            this.lblConsultarProductos.TabStop = true;
            this.lblConsultarProductos.Text = "Consultar productos";
            this.lblConsultarProductos.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblConsultarProductos_LinkClicked);
            // 
            // lblConsultarBarcos
            // 
            this.lblConsultarBarcos.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblConsultarBarcos.AutoSize = true;
            this.lblConsultarBarcos.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConsultarBarcos.Location = new System.Drawing.Point(492, 505);
            this.lblConsultarBarcos.Name = "lblConsultarBarcos";
            this.lblConsultarBarcos.Size = new System.Drawing.Size(119, 16);
            this.lblConsultarBarcos.TabIndex = 15;
            this.lblConsultarBarcos.TabStop = true;
            this.lblConsultarBarcos.Text = "Consultar barcos";
            this.lblConsultarBarcos.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblConsultarBarcos_LinkClicked);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.DarkGreen;
            this.panel2.Location = new System.Drawing.Point(-1, 636);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1341, 30);
            this.panel2.TabIndex = 38;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.DarkBlue;
            this.panel1.Location = new System.Drawing.Point(-1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1341, 30);
            this.panel1.TabIndex = 37;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnGuardar.BackColor = System.Drawing.Color.DarkBlue;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGuardar.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.Color.White;
            this.btnGuardar.Location = new System.Drawing.Point(1034, 588);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(105, 27);
            this.btnGuardar.TabIndex = 25;
            this.btnGuardar.Text = "Guardar ingreso";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // rbdTara
            // 
            this.rbdTara.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rbdTara.AutoSize = true;
            this.rbdTara.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbdTara.Location = new System.Drawing.Point(163, 26);
            this.rbdTara.Name = "rbdTara";
            this.rbdTara.Size = new System.Drawing.Size(105, 22);
            this.rbdTara.TabIndex = 22;
            this.rbdTara.TabStop = true;
            this.rbdTara.Text = "Peso Tara";
            this.rbdTara.UseVisualStyleBackColor = true;
            // 
            // rbdBruto
            // 
            this.rbdBruto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rbdBruto.AutoSize = true;
            this.rbdBruto.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbdBruto.Location = new System.Drawing.Point(349, 26);
            this.rbdBruto.Name = "rbdBruto";
            this.rbdBruto.Size = new System.Drawing.Size(115, 22);
            this.rbdBruto.TabIndex = 23;
            this.rbdBruto.TabStop = true;
            this.rbdBruto.Text = "Peso Bruto";
            this.rbdBruto.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.Controls.Add(this.rbdBruto);
            this.groupBox1.Controls.Add(this.rbdTara);
            this.groupBox1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(695, 374);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(584, 70);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tipo de pesaje";
            // 
            // FrmIngreso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.GhostWhite;
            this.ClientSize = new System.Drawing.Size(1341, 666);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblConsultarBarcos);
            this.Controls.Add(this.lblConsultarProductos);
            this.Controls.Add(this.lblConsultarClientes);
            this.Controls.Add(this.lblConsultarConductores);
            this.Controls.Add(this.btnConectar);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.lblConexion);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.txtObservaciones);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.btnObtenerPeso);
            this.Controls.Add(this.txtPesoEntrada);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtPesoBascula);
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
            this.Controls.Add(this.txtPlacaCabezal);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtConductor);
            this.Controls.Add(this.txtCodigoConductor);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmIngreso";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ingreso de vehículo";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmIngreso_FormClosed);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCodigoConductor;
        private System.Windows.Forms.TextBox txtConductor;
        private System.Windows.Forms.TextBox txtPlacaCabezal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCia;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCliente;
        private System.Windows.Forms.TextBox txtCodigoCliente;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtProducto;
        private System.Windows.Forms.TextBox txtCodigoProducto;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtBarco;
        private System.Windows.Forms.TextBox txtCodigoBarco;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtEnvioN;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtPesoBascula;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtPesoEntrada;
        private System.Windows.Forms.Button btnObtenerPeso;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtObservaciones;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label lblConexion;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btnConectar;
        private System.Windows.Forms.LinkLabel lblConsultarConductores;
        private System.Windows.Forms.LinkLabel lblConsultarClientes;
        private System.Windows.Forms.LinkLabel lblConsultarProductos;
        private System.Windows.Forms.LinkLabel lblConsultarBarcos;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.RadioButton rbdTara;
        private System.Windows.Forms.RadioButton rbdBruto;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}