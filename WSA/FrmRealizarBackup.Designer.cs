
namespace WSA
{
    partial class FrmRealizarBackup
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
            this.label2 = new System.Windows.Forms.Label();
            this.btnBackup = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(166, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(522, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Realizar copia de seguridad de la base de datos";
            // 
            // btnBackup
            // 
            this.btnBackup.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnBackup.Location = new System.Drawing.Point(303, 78);
            this.btnBackup.Name = "btnBackup";
            this.btnBackup.Size = new System.Drawing.Size(216, 45);
            this.btnBackup.TabIndex = 6;
            this.btnBackup.Text = "Realizar copia de seguridad";
            this.btnBackup.UseVisualStyleBackColor = true;
            this.btnBackup.Click += new System.EventHandler(this.btnBackup_Click);
            // 
            // FrmRealizarBackup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(850, 198);
            this.Controls.Add(this.btnBackup);
            this.Controls.Add(this.label2);
            this.Name = "FrmRealizarBackup";
            this.Text = "FrmRealizarBackup";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnBackup;
    }
}