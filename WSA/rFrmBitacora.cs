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

namespace WSA
{
    public partial class rFrmBitacora : Form
    {
        public rFrmBitacora()
        {
            InitializeComponent();
           
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
