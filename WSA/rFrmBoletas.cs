using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WSA.Clases;
namespace WSA
{
    public partial class rFrmBoletas : Form
    {
        CargarComboBox cargarComboBox = new CargarComboBox();
        public rFrmBoletas()
        {
            InitializeComponent();
            cargarComboBox.CargarComboBoxEstadoBoleta(cmbEstado);
        }

        private void rFrmBoletas_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'AWS_DATA_SET.sp_Reporte_Mostrar_Salidas' Puede moverla o quitarla según sea necesario.
            this.sp_Reporte_Mostrar_BoletasTableAdapter.Fill(this.AWS_DATA_SET.sp_Reporte_Mostrar_Boletas, txtBuscar.Text, dtpFechaInicio.Value.Date, dtpFechaFinal.Value.Date, cmbEstado.SelectedValue.ToString());

            this.reportViewer1.RefreshReport();
        }

        private void btnCargarReporte_Click(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'AWS_DATA_SET.sp_Reporte_Mostrar_Salidas' Puede moverla o quitarla según sea necesario.
            this.sp_Reporte_Mostrar_BoletasTableAdapter.Fill(this.AWS_DATA_SET.sp_Reporte_Mostrar_Boletas, txtBuscar.Text, dtpFechaInicio.Value.Date, dtpFechaFinal.Value.Date, cmbEstado.SelectedValue.ToString());

            this.reportViewer1.RefreshReport();
        }
    }
}
