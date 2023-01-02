using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Printing;
using WSA.Clases;

namespace WSA
{
    public partial class rFrmBitacora : Form
    {
        public rFrmBitacora()
        {
            InitializeComponent();
            foreach (Control c in this.Controls)
            {
                if (c is Button )
                {
                    c.BackColor = Color.FromArgb(VariablesGlobales.rgbBotones[0], VariablesGlobales.rgbBotones[1], VariablesGlobales.rgbBotones[2]);
                }
            }

        }

        private void rFrmBitacora_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'AWS_DATA_SET.sp_Reporte_Bitacora' Puede moverla o quitarla según sea necesario.
            this.sp_Reporte_BitacoraTableAdapter.Fill(this.AWS_DATA_SET.sp_Reporte_Bitacora, txtBuscar.Text, dtpFechaInicio.Value.Date, dtpFechaFinal.Value.Date);
            /*PageSettings ps = new PageSettings();
            ps.Landscape = true;
            ps.PaperSize = new System.Drawing.Printing.PaperSize("A4", 210, 297);
           // ps.PaperSize.RawKind = (int)System.Drawing.Printing.PaperKind.A4;

            reportViewer1.SetPageSettings(ps);*/
            //this.reportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout);
            
            this.reportViewer1.RefreshReport();

        }

        private void btnCargarReporte_Click(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'AWS_DATA_SET.sp_Reporte_Bitacora' Puede moverla o quitarla según sea necesario.
            this.sp_Reporte_BitacoraTableAdapter.Fill(this.AWS_DATA_SET.sp_Reporte_Bitacora, txtBuscar.Text, dtpFechaInicio.Value.Date, dtpFechaFinal.Value.Date);
            this.reportViewer1.RefreshReport();
        }
    }
}
