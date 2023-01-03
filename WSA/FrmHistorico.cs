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
    public partial class FrmHistorico : Form
    {
        Historico historico = new Historico();
        public FrmHistorico()
        {
            InitializeComponent();
            historico.MostrarHistorico(dgvHistorico);
            foreach (Control c in this.Controls)
            {
                if (c is Button)
                {
                    c.BackColor = Color.FromArgb(VariablesGlobales.rgbBotones[0], VariablesGlobales.rgbBotones[1], VariablesGlobales.rgbBotones[2]);
                }
            }
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            historico.Buscar(dgvHistorico, dtpFechaInicio, dtpFechaFinal, txtBuscar.Text);
        }

        private void dtpFechaInicio_ValueChanged(object sender, EventArgs e)
        {
            historico.Buscar(dgvHistorico, dtpFechaInicio, dtpFechaFinal, txtBuscar.Text);
        }

        private void dtpFechaFinal_ValueChanged(object sender, EventArgs e)
        {
            historico.Buscar(dgvHistorico, dtpFechaInicio, dtpFechaFinal, txtBuscar.Text);
        }

        private void btnExportar_Click(object sender, EventArgs e)
        {
            historico.ExportarExcel(dgvHistorico);
        }

        private void dgvHistorico_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvHistorico.Rows[e.RowIndex];
                row.Selected = true;
                
            }
        }
    }
}
