using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WSA
{
    public partial class FrmTicket : Form
    {
        int boletaId;
        public FrmTicket(int idBoleta)
        {
            InitializeComponent();
            boletaId = idBoleta;
        }

        private void FrmTicket_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'WSA_ALGDataSet.sp_Obtener_Encabezado_Boleta' Puede moverla o quitarla según sea necesario.
            this.sp_Obtener_Encabezado_BoletaTableAdapter.Fill(this.WSA_ALGDataSet.sp_Obtener_Encabezado_Boleta);
            // TODO: esta línea de código carga datos en la tabla 'WSA_ALGDataSet.sp_Datos_Boleta' Puede moverla o quitarla según sea necesario.
            this.sp_Datos_BoletaTableAdapter.Fill(this.WSA_ALGDataSet.sp_Datos_Boleta, boletaId);
            this.reportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout);
            
            this.reportViewer1.RefreshReport();
           
        }

        private void reportViewer1_RenderingComplete(object sender, Microsoft.Reporting.WinForms.RenderingCompleteEventArgs e)
        {
            try
            { 
                if(this.reportViewer1.DisplayMode == Microsoft.Reporting.WinForms.DisplayMode.PrintLayout)
                {
                    this.reportViewer1.PrintDialog();
                    this.Close();
                }
               
            }
            catch (Exception ex)
            {
               // MessageBox.Show(ex.Message.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
