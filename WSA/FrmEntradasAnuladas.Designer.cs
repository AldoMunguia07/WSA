
namespace WSA
{
    partial class FrmEntradasAnuladas
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
            this.dgvEntradasAnuladas = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEntradasAnuladas)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvEntradasAnuladas
            // 
            this.dgvEntradasAnuladas.AllowUserToAddRows = false;
            this.dgvEntradasAnuladas.AllowUserToDeleteRows = false;
            this.dgvEntradasAnuladas.AllowUserToOrderColumns = true;
            this.dgvEntradasAnuladas.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvEntradasAnuladas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvEntradasAnuladas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEntradasAnuladas.GridColor = System.Drawing.Color.DimGray;
            this.dgvEntradasAnuladas.Location = new System.Drawing.Point(12, 152);
            this.dgvEntradasAnuladas.Name = "dgvEntradasAnuladas";
            this.dgvEntradasAnuladas.ReadOnly = true;
            this.dgvEntradasAnuladas.Size = new System.Drawing.Size(1012, 193);
            this.dgvEntradasAnuladas.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(367, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(209, 25);
            this.label1.TabIndex = 13;
            this.label1.Text = "Entradas anuladas";
            // 
            // FrmEntradasAnuladas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1036, 465);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvEntradasAnuladas);
            this.Name = "FrmEntradasAnuladas";
            this.Text = "Entradas anuladas";
            ((System.ComponentModel.ISupportInitialize)(this.dgvEntradasAnuladas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvEntradasAnuladas;
        private System.Windows.Forms.Label label1;
    }
}