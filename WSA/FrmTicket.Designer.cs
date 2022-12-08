
namespace WSA
{
    partial class FrmTicket
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource5 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource6 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.WSA_ALGDataSet = new WSA.WSA_ALGDataSet();
            this.sp_Obtener_Encabezado_BoletaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sp_Obtener_Encabezado_BoletaTableAdapter = new WSA.WSA_ALGDataSetTableAdapters.sp_Obtener_Encabezado_BoletaTableAdapter();
            this.sp_Datos_BoletaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sp_Datos_BoletaTableAdapter = new WSA.WSA_ALGDataSetTableAdapters.sp_Datos_BoletaTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.WSA_ALGDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sp_Obtener_Encabezado_BoletaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sp_Datos_BoletaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource5.Name = "DatosEncabezado";
            reportDataSource5.Value = this.sp_Obtener_Encabezado_BoletaBindingSource;
            reportDataSource6.Name = "DatosBoleta";
            reportDataSource6.Value = this.sp_Datos_BoletaBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource5);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource6);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "WSA.Reportes.rptBoleta.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // WSA_ALGDataSet
            // 
            this.WSA_ALGDataSet.DataSetName = "WSA_ALGDataSet";
            this.WSA_ALGDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sp_Obtener_Encabezado_BoletaBindingSource
            // 
            this.sp_Obtener_Encabezado_BoletaBindingSource.DataMember = "sp_Obtener_Encabezado_Boleta";
            this.sp_Obtener_Encabezado_BoletaBindingSource.DataSource = this.WSA_ALGDataSet;
            // 
            // sp_Obtener_Encabezado_BoletaTableAdapter
            // 
            this.sp_Obtener_Encabezado_BoletaTableAdapter.ClearBeforeFill = true;
            // 
            // sp_Datos_BoletaBindingSource
            // 
            this.sp_Datos_BoletaBindingSource.DataMember = "sp_Datos_Boleta";
            this.sp_Datos_BoletaBindingSource.DataSource = this.WSA_ALGDataSet;
            // 
            // sp_Datos_BoletaTableAdapter
            // 
            this.sp_Datos_BoletaTableAdapter.ClearBeforeFill = true;
            // 
            // FrmTicket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FrmTicket";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Imprimir boleta";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmTicket_Load);
            ((System.ComponentModel.ISupportInitialize)(this.WSA_ALGDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sp_Obtener_Encabezado_BoletaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sp_Datos_BoletaBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource sp_Obtener_Encabezado_BoletaBindingSource;
        private WSA_ALGDataSet WSA_ALGDataSet;
        private System.Windows.Forms.BindingSource sp_Datos_BoletaBindingSource;
        private WSA_ALGDataSetTableAdapters.sp_Obtener_Encabezado_BoletaTableAdapter sp_Obtener_Encabezado_BoletaTableAdapter;
        private WSA_ALGDataSetTableAdapters.sp_Datos_BoletaTableAdapter sp_Datos_BoletaTableAdapter;
    }
}