
namespace WSA
{
    partial class FrmTicketEntrada
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmTicketEntrada));
            this.sp_Obtener_Encabezado_BoletaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.WSA_ALGDataSet = new WSA.WSA_ALGDataSet();
            this.sp_Datos_Boleta_EntradaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.sp_Obtener_Encabezado_BoletaTableAdapter = new WSA.WSA_ALGDataSetTableAdapters.sp_Obtener_Encabezado_BoletaTableAdapter();
            this.sp_Datos_Boleta_EntradaTableAdapter = new WSA.WSA_ALGDataSetTableAdapters.sp_Datos_Boleta_EntradaTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.sp_Obtener_Encabezado_BoletaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.WSA_ALGDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sp_Datos_Boleta_EntradaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // sp_Obtener_Encabezado_BoletaBindingSource
            // 
            this.sp_Obtener_Encabezado_BoletaBindingSource.DataMember = "sp_Obtener_Encabezado_Boleta";
            this.sp_Obtener_Encabezado_BoletaBindingSource.DataSource = this.WSA_ALGDataSet;
            // 
            // WSA_ALGDataSet
            // 
            this.WSA_ALGDataSet.DataSetName = "WSA_ALGDataSet";
            this.WSA_ALGDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sp_Datos_Boleta_EntradaBindingSource
            // 
            this.sp_Datos_Boleta_EntradaBindingSource.DataMember = "sp_Datos_Boleta_Entrada";
            this.sp_Datos_Boleta_EntradaBindingSource.DataSource = this.WSA_ALGDataSet;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DatosEncabezado";
            reportDataSource1.Value = this.sp_Obtener_Encabezado_BoletaBindingSource;
            reportDataSource2.Name = "DatosBoleta";
            reportDataSource2.Value = this.sp_Datos_Boleta_EntradaBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "WSA.Reportes.rptTicketEntrada.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            this.reportViewer1.RenderingComplete += new Microsoft.Reporting.WinForms.RenderingCompleteEventHandler(this.reportViewer1_RenderingComplete);
            // 
            // sp_Obtener_Encabezado_BoletaTableAdapter
            // 
            this.sp_Obtener_Encabezado_BoletaTableAdapter.ClearBeforeFill = true;
            // 
            // sp_Datos_Boleta_EntradaTableAdapter
            // 
            this.sp_Datos_Boleta_EntradaTableAdapter.ClearBeforeFill = true;
            // 
            // FrmTicketEntrada
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmTicketEntrada";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Boleta de entrada";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmTicketEntrada_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sp_Obtener_Encabezado_BoletaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.WSA_ALGDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sp_Datos_Boleta_EntradaBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource sp_Obtener_Encabezado_BoletaBindingSource;
        private WSA_ALGDataSet WSA_ALGDataSet;
        private System.Windows.Forms.BindingSource sp_Datos_Boleta_EntradaBindingSource;
        private WSA_ALGDataSetTableAdapters.sp_Obtener_Encabezado_BoletaTableAdapter sp_Obtener_Encabezado_BoletaTableAdapter;
        private WSA_ALGDataSetTableAdapters.sp_Datos_Boleta_EntradaTableAdapter sp_Datos_Boleta_EntradaTableAdapter;
    }
}