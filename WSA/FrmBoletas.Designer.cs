
namespace WSA
{
    partial class FrmBoletas
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
            this.dgvBoletas = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btnVerBoleta = new System.Windows.Forms.Button();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBoletas)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvBoletas
            // 
            this.dgvBoletas.AllowUserToAddRows = false;
            this.dgvBoletas.AllowUserToDeleteRows = false;
            this.dgvBoletas.AllowUserToOrderColumns = true;
            this.dgvBoletas.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvBoletas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBoletas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBoletas.GridColor = System.Drawing.Color.DimGray;
            this.dgvBoletas.Location = new System.Drawing.Point(32, 199);
            this.dgvBoletas.Name = "dgvBoletas";
            this.dgvBoletas.ReadOnly = true;
            this.dgvBoletas.Size = new System.Drawing.Size(1228, 196);
            this.dgvBoletas.TabIndex = 13;
            this.dgvBoletas.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvBoletas_CellMouseClick);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(597, 133);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 29);
            this.label1.TabIndex = 12;
            this.label1.Text = "Boletas";
            // 
            // btnVerBoleta
            // 
            this.btnVerBoleta.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnVerBoleta.BackColor = System.Drawing.Color.DarkBlue;
            this.btnVerBoleta.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnVerBoleta.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerBoleta.ForeColor = System.Drawing.Color.White;
            this.btnVerBoleta.Location = new System.Drawing.Point(1052, 422);
            this.btnVerBoleta.Name = "btnVerBoleta";
            this.btnVerBoleta.Size = new System.Drawing.Size(102, 26);
            this.btnVerBoleta.TabIndex = 14;
            this.btnVerBoleta.Text = "Ver boleta";
            this.btnVerBoleta.UseVisualStyleBackColor = false;
            this.btnVerBoleta.Click += new System.EventHandler(this.btnVerBoleta_Click);
            // 
            // btnImprimir
            // 
            this.btnImprimir.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnImprimir.BackColor = System.Drawing.Color.DarkBlue;
            this.btnImprimir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnImprimir.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImprimir.ForeColor = System.Drawing.Color.White;
            this.btnImprimir.Location = new System.Drawing.Point(1174, 422);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(86, 26);
            this.btnImprimir.TabIndex = 15;
            this.btnImprimir.Text = "Imprimir";
            this.btnImprimir.UseVisualStyleBackColor = false;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.DarkGreen;
            this.panel2.Location = new System.Drawing.Point(-1, 562);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1288, 30);
            this.panel2.TabIndex = 23;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.DarkBlue;
            this.panel1.Location = new System.Drawing.Point(-1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1288, 30);
            this.panel1.TabIndex = 22;
            // 
            // FrmBoletas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1287, 592);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnImprimir);
            this.Controls.Add(this.btnVerBoleta);
            this.Controls.Add(this.dgvBoletas);
            this.Controls.Add(this.label1);
            this.Name = "FrmBoletas";
            this.Text = "Boletas";
            ((System.ComponentModel.ISupportInitialize)(this.dgvBoletas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvBoletas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnVerBoleta;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
    }
}