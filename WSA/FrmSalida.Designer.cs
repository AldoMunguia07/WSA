
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
            this.btnConectar = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.lblConexion = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.txtObservaciones = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtObtenerPeso = new System.Windows.Forms.Button();
            this.txtPesoSalida = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtPesoBascula = new System.Windows.Forms.TextBox();
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.dtpFechaEntrada = new System.Windows.Forms.DateTimePicker();
            this.txtPesoEntrada = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.mySerialPort = new System.IO.Ports.SerialPort(this.components);
            this.SuspendLayout();
            // 
            // btnConectar
            // 
            this.btnConectar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnConectar.Location = new System.Drawing.Point(820, 147);
            this.btnConectar.Name = "btnConectar";
            this.btnConectar.Size = new System.Drawing.Size(75, 23);
            this.btnConectar.TabIndex = 65;
            this.btnConectar.Text = "Conectar";
            this.btnConectar.UseVisualStyleBackColor = true;
            this.btnConectar.Click += new System.EventHandler(this.btnConectar_Click);
            // 
            // label13
            // 
            this.label13.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(480, 152);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(176, 13);
            this.label13.TabIndex = 64;
            this.label13.Text = "Estado de conexión con la báscula:";
            // 
            // lblConexion
            // 
            this.lblConexion.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblConexion.AutoSize = true;
            this.lblConexion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConexion.ForeColor = System.Drawing.Color.Red;
            this.lblConexion.Location = new System.Drawing.Point(653, 152);
            this.lblConexion.Name = "lblConexion";
            this.lblConexion.Size = new System.Drawing.Size(89, 13);
            this.lblConexion.TabIndex = 63;
            this.lblConexion.Text = "Desconectado";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCancelar.Location = new System.Drawing.Point(813, 432);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(105, 27);
            this.btnCancelar.TabIndex = 62;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnGuardar.Location = new System.Drawing.Point(567, 432);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(105, 27);
            this.btnGuardar.TabIndex = 61;
            this.btnGuardar.Text = "Guardar salida";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // txtObservaciones
            // 
            this.txtObservaciones.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtObservaciones.Location = new System.Drawing.Point(587, 303);
            this.txtObservaciones.Multiline = true;
            this.txtObservaciones.Name = "txtObservaciones";
            this.txtObservaciones.Size = new System.Drawing.Size(308, 90);
            this.txtObservaciones.TabIndex = 60;
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(500, 303);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(81, 13);
            this.label12.TabIndex = 59;
            this.label12.Text = "Observaciones:";
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(480, 100);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(101, 13);
            this.label11.TabIndex = 58;
            this.label11.Text = "Lectura en báscula:";
            // 
            // txtObtenerPeso
            // 
            this.txtObtenerPeso.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtObtenerPeso.Location = new System.Drawing.Point(785, 245);
            this.txtObtenerPeso.Name = "txtObtenerPeso";
            this.txtObtenerPeso.Size = new System.Drawing.Size(110, 23);
            this.txtObtenerPeso.TabIndex = 57;
            this.txtObtenerPeso.Text = "Obtener peso";
            this.txtObtenerPeso.UseVisualStyleBackColor = true;
            this.txtObtenerPeso.Click += new System.EventHandler(this.txtObtenerPeso_Click);
            // 
            // txtPesoSalida
            // 
            this.txtPesoSalida.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPesoSalida.BackColor = System.Drawing.Color.White;
            this.txtPesoSalida.Location = new System.Drawing.Point(587, 246);
            this.txtPesoSalida.Name = "txtPesoSalida";
            this.txtPesoSalida.ReadOnly = true;
            this.txtPesoSalida.Size = new System.Drawing.Size(179, 20);
            this.txtPesoSalida.TabIndex = 56;
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(517, 250);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(64, 13);
            this.label10.TabIndex = 55;
            this.label10.Text = "Peso salida:";
            // 
            // txtPesoBascula
            // 
            this.txtPesoBascula.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPesoBascula.BackColor = System.Drawing.Color.Black;
            this.txtPesoBascula.Font = new System.Drawing.Font("Consolas", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPesoBascula.ForeColor = System.Drawing.Color.White;
            this.txtPesoBascula.Location = new System.Drawing.Point(587, 83);
            this.txtPesoBascula.Multiline = true;
            this.txtPesoBascula.Name = "txtPesoBascula";
            this.txtPesoBascula.ReadOnly = true;
            this.txtPesoBascula.Size = new System.Drawing.Size(308, 46);
            this.txtPesoBascula.TabIndex = 54;
            this.txtPesoBascula.Text = "0.00 Kg";
            this.txtPesoBascula.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtEnvioN
            // 
            this.txtEnvioN.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtEnvioN.Location = new System.Drawing.Point(339, 198);
            this.txtEnvioN.Name = "txtEnvioN";
            this.txtEnvioN.Size = new System.Drawing.Size(91, 20);
            this.txtEnvioN.TabIndex = 53;
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(257, 202);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(76, 13);
            this.label9.TabIndex = 52;
            this.label9.Text = "Contrato / OC:";
            // 
            // txtBarco
            // 
            this.txtBarco.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtBarco.BackColor = System.Drawing.Color.White;
            this.txtBarco.Location = new System.Drawing.Point(215, 377);
            this.txtBarco.Name = "txtBarco";
            this.txtBarco.ReadOnly = true;
            this.txtBarco.Size = new System.Drawing.Size(215, 20);
            this.txtBarco.TabIndex = 51;
            // 
            // txtCodigoBarco
            // 
            this.txtCodigoBarco.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtCodigoBarco.Location = new System.Drawing.Point(162, 377);
            this.txtCodigoBarco.Name = "txtCodigoBarco";
            this.txtCodigoBarco.Size = new System.Drawing.Size(47, 20);
            this.txtCodigoBarco.TabIndex = 50;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(58, 380);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(87, 13);
            this.label8.TabIndex = 49;
            this.label8.Text = "Código del barco";
            // 
            // txtProducto
            // 
            this.txtProducto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtProducto.BackColor = System.Drawing.Color.White;
            this.txtProducto.Location = new System.Drawing.Point(215, 313);
            this.txtProducto.Name = "txtProducto";
            this.txtProducto.ReadOnly = true;
            this.txtProducto.Size = new System.Drawing.Size(215, 20);
            this.txtProducto.TabIndex = 48;
            // 
            // txtCodigoProducto
            // 
            this.txtCodigoProducto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtCodigoProducto.Location = new System.Drawing.Point(162, 313);
            this.txtCodigoProducto.Name = "txtCodigoProducto";
            this.txtCodigoProducto.Size = new System.Drawing.Size(47, 20);
            this.txtCodigoProducto.TabIndex = 47;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(50, 316);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(102, 13);
            this.label7.TabIndex = 46;
            this.label7.Text = "Código del producto";
            // 
            // txtCliente
            // 
            this.txtCliente.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtCliente.BackColor = System.Drawing.Color.White;
            this.txtCliente.Location = new System.Drawing.Point(215, 248);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.ReadOnly = true;
            this.txtCliente.Size = new System.Drawing.Size(215, 20);
            this.txtCliente.TabIndex = 45;
            // 
            // txtCodigoCliente
            // 
            this.txtCodigoCliente.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtCodigoCliente.Location = new System.Drawing.Point(162, 248);
            this.txtCodigoCliente.Name = "txtCodigoCliente";
            this.txtCodigoCliente.Size = new System.Drawing.Size(47, 20);
            this.txtCodigoCliente.TabIndex = 44;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(56, 251);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 13);
            this.label6.TabIndex = 43;
            this.label6.Text = "Código del cliente";
            // 
            // txtCia
            // 
            this.txtCia.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtCia.Location = new System.Drawing.Point(162, 198);
            this.txtCia.Name = "txtCia";
            this.txtCia.Size = new System.Drawing.Size(91, 20);
            this.txtCia.TabIndex = 42;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(44, 202);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 13);
            this.label5.TabIndex = 41;
            this.label5.Text = "Compañia transportista";
            // 
            // txtPlacaRastra
            // 
            this.txtPlacaRastra.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPlacaRastra.Location = new System.Drawing.Point(339, 150);
            this.txtPlacaRastra.Name = "txtPlacaRastra";
            this.txtPlacaRastra.Size = new System.Drawing.Size(91, 20);
            this.txtPlacaRastra.TabIndex = 40;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(270, 154);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 39;
            this.label4.Text = "Placa rastra";
            // 
            // txtPlacaCabezal
            // 
            this.txtPlacaCabezal.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPlacaCabezal.Location = new System.Drawing.Point(162, 150);
            this.txtPlacaCabezal.Name = "txtPlacaCabezal";
            this.txtPlacaCabezal.Size = new System.Drawing.Size(91, 20);
            this.txtPlacaCabezal.TabIndex = 38;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(64, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 37;
            this.label3.Text = "Placa cabezal";
            // 
            // txtConductor
            // 
            this.txtConductor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtConductor.BackColor = System.Drawing.Color.White;
            this.txtConductor.Location = new System.Drawing.Point(215, 97);
            this.txtConductor.Name = "txtConductor";
            this.txtConductor.ReadOnly = true;
            this.txtConductor.Size = new System.Drawing.Size(215, 20);
            this.txtConductor.TabIndex = 36;
            // 
            // txtCodigoConductor
            // 
            this.txtCodigoConductor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtCodigoConductor.Location = new System.Drawing.Point(162, 97);
            this.txtCodigoConductor.Name = "txtCodigoConductor";
            this.txtCodigoConductor.Size = new System.Drawing.Size(47, 20);
            this.txtCodigoConductor.TabIndex = 35;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 13);
            this.label2.TabIndex = 34;
            this.label2.Text = "Código del conductor";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(345, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(206, 25);
            this.label1.TabIndex = 33;
            this.label1.Text = "Salida de vehículo";
            // 
            // btnImprimir
            // 
            this.btnImprimir.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnImprimir.Location = new System.Drawing.Point(691, 432);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(105, 27);
            this.btnImprimir.TabIndex = 66;
            this.btnImprimir.Text = "Imprimir";
            this.btnImprimir.UseVisualStyleBackColor = true;
            // 
            // label14
            // 
            this.label14.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(74, 58);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(82, 13);
            this.label14.TabIndex = 67;
            this.label14.Text = "Fecha entrada: ";
            // 
            // dtpFechaEntrada
            // 
            this.dtpFechaEntrada.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtpFechaEntrada.Location = new System.Drawing.Point(162, 54);
            this.dtpFechaEntrada.Name = "dtpFechaEntrada";
            this.dtpFechaEntrada.Size = new System.Drawing.Size(200, 20);
            this.dtpFechaEntrada.TabIndex = 68;
            // 
            // txtPesoEntrada
            // 
            this.txtPesoEntrada.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPesoEntrada.BackColor = System.Drawing.Color.White;
            this.txtPesoEntrada.Location = new System.Drawing.Point(587, 195);
            this.txtPesoEntrada.Name = "txtPesoEntrada";
            this.txtPesoEntrada.ReadOnly = true;
            this.txtPesoEntrada.Size = new System.Drawing.Size(179, 20);
            this.txtPesoEntrada.TabIndex = 70;
            // 
            // label15
            // 
            this.label15.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(511, 199);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(73, 13);
            this.label15.TabIndex = 69;
            this.label15.Text = "Peso entrada:";
            // 
            // FrmSalida
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(938, 492);
            this.Controls.Add(this.txtPesoEntrada);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.dtpFechaEntrada);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.btnImprimir);
            this.Controls.Add(this.btnConectar);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.lblConexion);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.txtObservaciones);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtObtenerPeso);
            this.Controls.Add(this.txtPesoSalida);
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
            this.Controls.Add(this.txtPlacaRastra);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtPlacaCabezal);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtConductor);
            this.Controls.Add(this.txtCodigoConductor);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmSalida";
            this.Text = "FrmSalida";
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
        private System.Windows.Forms.Button txtObtenerPeso;
        private System.Windows.Forms.TextBox txtPesoSalida;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtPesoBascula;
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.DateTimePicker dtpFechaEntrada;
        private System.Windows.Forms.TextBox txtPesoEntrada;
        private System.Windows.Forms.Label label15;
        private System.IO.Ports.SerialPort mySerialPort;
    }
}