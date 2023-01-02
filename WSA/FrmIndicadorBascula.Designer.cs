
namespace WSA
{
    partial class FrmIndicadorBascula
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmIndicadorBascula));
            this.cmbParidad = new System.Windows.Forms.ComboBox();
            this.cmbPuertos = new System.Windows.Forms.ComboBox();
            this.cmbStopBit = new System.Windows.Forms.ComboBox();
            this.cmbVelocidad = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbDataBits = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnProbarConexion = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.numMaximo = new System.Windows.Forms.NumericUpDown();
            this.numMinimo = new System.Windows.Forms.NumericUpDown();
            this.numPosicion = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numMaximo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMinimo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPosicion)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbParidad
            // 
            this.cmbParidad.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbParidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbParidad.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbParidad.FormattingEnabled = true;
            this.cmbParidad.Location = new System.Drawing.Point(207, 259);
            this.cmbParidad.Name = "cmbParidad";
            this.cmbParidad.Size = new System.Drawing.Size(121, 26);
            this.cmbParidad.TabIndex = 3;
            // 
            // cmbPuertos
            // 
            this.cmbPuertos.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbPuertos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPuertos.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbPuertos.FormattingEnabled = true;
            this.cmbPuertos.Location = new System.Drawing.Point(207, 124);
            this.cmbPuertos.Name = "cmbPuertos";
            this.cmbPuertos.Size = new System.Drawing.Size(121, 26);
            this.cmbPuertos.TabIndex = 0;
            // 
            // cmbStopBit
            // 
            this.cmbStopBit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbStopBit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStopBit.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbStopBit.FormattingEnabled = true;
            this.cmbStopBit.Location = new System.Drawing.Point(207, 309);
            this.cmbStopBit.Name = "cmbStopBit";
            this.cmbStopBit.Size = new System.Drawing.Size(121, 26);
            this.cmbStopBit.TabIndex = 4;
            // 
            // cmbVelocidad
            // 
            this.cmbVelocidad.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbVelocidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbVelocidad.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbVelocidad.FormattingEnabled = true;
            this.cmbVelocidad.Location = new System.Drawing.Point(207, 169);
            this.cmbVelocidad.Name = "cmbVelocidad";
            this.cmbVelocidad.Size = new System.Drawing.Size(121, 26);
            this.cmbVelocidad.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(121, 128);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 18);
            this.label1.TabIndex = 4;
            this.label1.Text = "Puerto:";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(112, 173);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 18);
            this.label2.TabIndex = 5;
            this.label2.Text = "Velocidad:";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(121, 263);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 18);
            this.label3.TabIndex = 6;
            this.label3.Text = "Paridad:";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(120, 313);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 18);
            this.label4.TabIndex = 7;
            this.label4.Text = "Stop Bit:";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(117, 211);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 18);
            this.label5.TabIndex = 8;
            this.label5.Text = "Data Bits:";
            // 
            // cmbDataBits
            // 
            this.cmbDataBits.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbDataBits.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDataBits.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbDataBits.FormattingEnabled = true;
            this.cmbDataBits.Location = new System.Drawing.Point(207, 207);
            this.cmbDataBits.Name = "cmbDataBits";
            this.cmbDataBits.Size = new System.Drawing.Size(121, 26);
            this.cmbDataBits.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(139, 56);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(634, 29);
            this.label6.TabIndex = 10;
            this.label6.Text = "CONFIGURACIÓN DE INDICADOR DE BÁSCULA\r\n";
            // 
            // btnGuardar
            // 
            this.btnGuardar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnGuardar.BackColor = System.Drawing.Color.DarkBlue;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGuardar.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.Color.White;
            this.btnGuardar.Location = new System.Drawing.Point(280, 381);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(162, 38);
            this.btnGuardar.TabIndex = 5;
            this.btnGuardar.Text = "Guardar cambios";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnProbarConexion
            // 
            this.btnProbarConexion.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnProbarConexion.BackColor = System.Drawing.Color.DarkGreen;
            this.btnProbarConexion.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnProbarConexion.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProbarConexion.ForeColor = System.Drawing.Color.White;
            this.btnProbarConexion.Location = new System.Drawing.Point(463, 381);
            this.btnProbarConexion.Name = "btnProbarConexion";
            this.btnProbarConexion.Size = new System.Drawing.Size(162, 38);
            this.btnProbarConexion.TabIndex = 6;
            this.btnProbarConexion.Text = "Probar conexión";
            this.btnProbarConexion.UseVisualStyleBackColor = false;
            this.btnProbarConexion.Click += new System.EventHandler(this.btnProbarConexion_Click);
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(461, 128);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 18);
            this.label7.TabIndex = 26;
            this.label7.Text = "Máximo:";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(460, 173);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 18);
            this.label8.TabIndex = 27;
            this.label8.Text = "Mínimo:";
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(342, 216);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(196, 18);
            this.label9.TabIndex = 28;
            this.label9.Text = "Posición del signo \"+\":";
            // 
            // numMaximo
            // 
            this.numMaximo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.numMaximo.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numMaximo.Location = new System.Drawing.Point(544, 123);
            this.numMaximo.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.numMaximo.Name = "numMaximo";
            this.numMaximo.Size = new System.Drawing.Size(120, 27);
            this.numMaximo.TabIndex = 29;
            // 
            // numMinimo
            // 
            this.numMinimo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.numMinimo.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numMinimo.Location = new System.Drawing.Point(544, 168);
            this.numMinimo.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.numMinimo.Name = "numMinimo";
            this.numMinimo.Size = new System.Drawing.Size(120, 27);
            this.numMinimo.TabIndex = 30;
            // 
            // numPosicion
            // 
            this.numPosicion.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.numPosicion.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numPosicion.Location = new System.Drawing.Point(544, 211);
            this.numPosicion.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.numPosicion.Name = "numPosicion";
            this.numPosicion.Size = new System.Drawing.Size(120, 27);
            this.numPosicion.TabIndex = 31;
            // 
            // FrmIndicadorBascula
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.GhostWhite;
            this.ClientSize = new System.Drawing.Size(908, 503);
            this.Controls.Add(this.numPosicion);
            this.Controls.Add(this.numMinimo);
            this.Controls.Add(this.numMaximo);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnProbarConexion);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cmbDataBits);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbVelocidad);
            this.Controls.Add(this.cmbStopBit);
            this.Controls.Add(this.cmbPuertos);
            this.Controls.Add(this.cmbParidad);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmIndicadorBascula";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Indicador de la báscula";
            ((System.ComponentModel.ISupportInitialize)(this.numMaximo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMinimo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPosicion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbParidad;
        private System.Windows.Forms.ComboBox cmbPuertos;
        private System.Windows.Forms.ComboBox cmbStopBit;
        private System.Windows.Forms.ComboBox cmbVelocidad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbDataBits;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnProbarConexion;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown numMaximo;
        private System.Windows.Forms.NumericUpDown numMinimo;
        private System.Windows.Forms.NumericUpDown numPosicion;
    }
}