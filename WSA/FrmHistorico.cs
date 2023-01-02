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
    }
}
