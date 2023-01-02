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
    public partial class FrmVerBoleta : Form
    {
        Boleta boleta = new Boleta();
        private int idBoleta;
        public FrmVerBoleta(int boletaId)
        {
            InitializeComponent();
            panel1.BackColor = Color.FromArgb(VariablesGlobales.rgbPanel[0], VariablesGlobales.rgbPanel[1], VariablesGlobales.rgbPanel[2]);
            panel2.BackColor = Color.FromArgb(VariablesGlobales.rgbPanel[0], VariablesGlobales.rgbPanel[1], VariablesGlobales.rgbPanel[2]);
            idBoleta = boletaId;
            boleta.BoletaId = idBoleta;
            boleta.CargarFormularioVerBoleta(idBoleta, dtpFechaEntrada, dtpHoraEntrada, dtpFechaSalida, dtpHoraSalida, txtCodigoConductor, txtConductor, txtPlacaCabezal, txtCia, txtEnvioN, txtCodigoCliente,
               txtCliente, txtCodigoProducto, txtProducto, txtCodigoBarco, txtBarco, txtPesoEntrada, txtPesoSalida, txtPesoNeto, txtObservaciones);
            lblTitulo.Text = String.Format("{0}{1}", lblTitulo.Text, idBoleta);

            lblTipoPesoEntrada.Text = boleta.ObtenerTipoPesaje(boleta).Rows[0]["Entrada"].ToString();
            lblTipoPesoSalida.Text = boleta.ObtenerTipoPesaje(boleta).Rows[0]["Salida"].ToString();

        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            FrmTicket frmTicket = new FrmTicket(idBoleta);
            frmTicket.ShowDialog();
        }

      
    }
}
