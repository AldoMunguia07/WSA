
namespace WSA
{
    partial class FrmTablero
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.gpMeses = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label2 = new System.Windows.Forms.Label();
            this.gpOperadores = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.gpProductos = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.gpConductores = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.gpMeses)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gpOperadores)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gpProductos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gpConductores)).BeginInit();
            this.SuspendLayout();
            // 
            // gpMeses
            // 
            this.gpMeses.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea1.Name = "ChartArea1";
            this.gpMeses.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.gpMeses.Legends.Add(legend1);
            this.gpMeses.Location = new System.Drawing.Point(54, 73);
            this.gpMeses.Name = "gpMeses";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.gpMeses.Series.Add(series1);
            this.gpMeses.Size = new System.Drawing.Size(990, 503);
            this.gpMeses.TabIndex = 0;
            this.gpMeses.Text = "chart1";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(384, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(268, 29);
            this.label2.TabIndex = 4;
            this.label2.Text = "GRÁFICOS DE AWS";
            // 
            // gpOperadores
            // 
            this.gpOperadores.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea2.Name = "ChartArea1";
            this.gpOperadores.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.gpOperadores.Legends.Add(legend2);
            this.gpOperadores.Location = new System.Drawing.Point(54, 622);
            this.gpOperadores.Name = "gpOperadores";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.gpOperadores.Series.Add(series2);
            this.gpOperadores.Size = new System.Drawing.Size(990, 503);
            this.gpOperadores.TabIndex = 5;
            this.gpOperadores.Text = "chart1";
            // 
            // gpProductos
            // 
            this.gpProductos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea3.Name = "ChartArea1";
            this.gpProductos.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.gpProductos.Legends.Add(legend3);
            this.gpProductos.Location = new System.Drawing.Point(54, 1178);
            this.gpProductos.Name = "gpProductos";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.gpProductos.Series.Add(series3);
            this.gpProductos.Size = new System.Drawing.Size(990, 503);
            this.gpProductos.TabIndex = 6;
            this.gpProductos.Text = "chart1";
            // 
            // gpConductores
            // 
            this.gpConductores.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea4.Name = "ChartArea1";
            this.gpConductores.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.gpConductores.Legends.Add(legend4);
            this.gpConductores.Location = new System.Drawing.Point(54, 1731);
            this.gpConductores.Name = "gpConductores";
            series4.ChartArea = "ChartArea1";
            series4.Legend = "Legend1";
            series4.Name = "Series1";
            this.gpConductores.Series.Add(series4);
            this.gpConductores.Size = new System.Drawing.Size(990, 503);
            this.gpConductores.TabIndex = 7;
            this.gpConductores.Text = "chart1";
            // 
            // FrmTablero
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1112, 418);
            this.Controls.Add(this.gpConductores);
            this.Controls.Add(this.gpProductos);
            this.Controls.Add(this.gpOperadores);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.gpMeses);
            this.Name = "FrmTablero";
            this.Text = "FrmTablero";
            ((System.ComponentModel.ISupportInitialize)(this.gpMeses)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gpOperadores)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gpProductos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gpConductores)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart gpMeses;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataVisualization.Charting.Chart gpOperadores;
        private System.Windows.Forms.DataVisualization.Charting.Chart gpProductos;
        private System.Windows.Forms.DataVisualization.Charting.Chart gpConductores;
    }
}