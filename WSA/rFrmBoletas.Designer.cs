
namespace WSA
{
    partial class rFrmBoletas
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(rFrmBoletas));
            this.sp_Reporte_Mostrar_SalidasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.AWS_DATA_SET = new WSA.AWS_DATA_SET();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.dtpFechaFinal = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpFechaInicio = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCargarReporte = new System.Windows.Forms.Button();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.sp_Reporte_Mostrar_BoletasTableAdapter = new WSA.AWS_DATA_SETTableAdapters.sp_Reporte_Mostrar_BoletasTableAdapter();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbEstado = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.sp_Reporte_Mostrar_SalidasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AWS_DATA_SET)).BeginInit();
            this.SuspendLayout();
            // 
            // sp_Reporte_Mostrar_SalidasBindingSource
            // 
            this.sp_Reporte_Mostrar_SalidasBindingSource.DataMember = "sp_Reporte_Mostrar_Boletas";
            this.sp_Reporte_Mostrar_SalidasBindingSource.DataSource = this.AWS_DATA_SET;
            // 
            // AWS_DATA_SET
            // 
            this.AWS_DATA_SET.DataSetName = "AWS_DATA_SET";
            this.AWS_DATA_SET.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(174, 175);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 18);
            this.label4.TabIndex = 17;
            this.label4.Text = "Buscar:";
            // 
            // txtBuscar
            // 
            this.txtBuscar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtBuscar.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscar.Location = new System.Drawing.Point(243, 171);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(330, 27);
            this.txtBuscar.TabIndex = 13;
            // 
            // dtpFechaFinal
            // 
            this.dtpFechaFinal.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dtpFechaFinal.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaFinal.Location = new System.Drawing.Point(669, 107);
            this.dtpFechaFinal.Name = "dtpFechaFinal";
            this.dtpFechaFinal.Size = new System.Drawing.Size(333, 27);
            this.dtpFechaFinal.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(607, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 20);
            this.label3.TabIndex = 16;
            this.label3.Text = "Hasta:";
            // 
            // dtpFechaInicio
            // 
            this.dtpFechaInicio.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dtpFechaInicio.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaInicio.Location = new System.Drawing.Point(243, 107);
            this.dtpFechaInicio.Name = "dtpFechaInicio";
            this.dtpFechaInicio.Size = new System.Drawing.Size(330, 27);
            this.dtpFechaInicio.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(177, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 18);
            this.label1.TabIndex = 15;
            this.label1.Text = "Desde:";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(444, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(267, 29);
            this.label2.TabIndex = 14;
            this.label2.Text = "Reporte de boletas";
            // 
            // btnCargarReporte
            // 
            this.btnCargarReporte.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnCargarReporte.BackColor = System.Drawing.Color.DarkGreen;
            this.btnCargarReporte.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCargarReporte.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCargarReporte.ForeColor = System.Drawing.Color.White;
            this.btnCargarReporte.Location = new System.Drawing.Point(863, 168);
            this.btnCargarReporte.Name = "btnCargarReporte";
            this.btnCargarReporte.Size = new System.Drawing.Size(139, 32);
            this.btnCargarReporte.TabIndex = 18;
            this.btnCargarReporte.Text = "Cargar reporte";
            this.btnCargarReporte.UseVisualStyleBackColor = false;
            this.btnCargarReporte.Click += new System.EventHandler(this.btnCargarReporte_Click);
            // 
            // reportViewer1
            // 
            this.reportViewer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            reportDataSource1.Name = "Boletas";
            reportDataSource1.Value = this.sp_Reporte_Mostrar_SalidasBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "WSA.Reportes.rptBoletas.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(8, 219);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1126, 406);
            this.reportViewer1.TabIndex = 19;
            this.reportViewer1.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.PageWidth;
            // 
            // sp_Reporte_Mostrar_BoletasTableAdapter
            // 
            this.sp_Reporte_Mostrar_BoletasTableAdapter.ClearBeforeFill = true;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(608, 175);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 18);
            this.label5.TabIndex = 20;
            this.label5.Text = "Estado";
            // 
            // cmbEstado
            // 
            this.cmbEstado.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cmbEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEstado.FormattingEnabled = true;
            this.cmbEstado.Location = new System.Drawing.Point(678, 174);
            this.cmbEstado.Name = "cmbEstado";
            this.cmbEstado.Size = new System.Drawing.Size(156, 21);
            this.cmbEstado.TabIndex = 21;
            // 
            // rFrmBoletas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1146, 637);
            this.Controls.Add(this.cmbEstado);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.btnCargarReporte);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.dtpFechaFinal);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtpFechaInicio);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "rFrmBoletas";
            this.Text = "Reporte de boletas";
            this.Load += new System.EventHandler(this.rFrmBoletas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sp_Reporte_Mostrar_SalidasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AWS_DATA_SET)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.DateTimePicker dtpFechaFinal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpFechaInicio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCargarReporte;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource sp_Reporte_Mostrar_SalidasBindingSource;
        private AWS_DATA_SET AWS_DATA_SET;
        private AWS_DATA_SETTableAdapters.sp_Reporte_Mostrar_BoletasTableAdapter sp_Reporte_Mostrar_BoletasTableAdapter;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbEstado;
    }
}