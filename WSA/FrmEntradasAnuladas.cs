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
    public partial class FrmEntradasAnuladas : Form
    {
        Boleta boleta = new Boleta();
        public FrmEntradasAnuladas()
        {
            InitializeComponent();
            boleta.BuscarAnuladas(dgvEntradasAnuladas, dtpFechaInicio, dtpFechaFinal, txtBuscar.Text);
        }

        private void dgvEntradasAnuladas_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvEntradasAnuladas.Rows[e.RowIndex];
                row.Selected = true;

            }
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            boleta.BuscarAnuladas(dgvEntradasAnuladas, dtpFechaInicio, dtpFechaFinal, txtBuscar.Text);
        }

        private void dtpFechaInicio_ValueChanged(object sender, EventArgs e)
        {
            boleta.BuscarAnuladas(dgvEntradasAnuladas, dtpFechaInicio, dtpFechaFinal, txtBuscar.Text);
        }

        private void dtpFechaFinal_ValueChanged(object sender, EventArgs e)
        {
            boleta.BuscarAnuladas(dgvEntradasAnuladas, dtpFechaInicio, dtpFechaFinal, txtBuscar.Text);
        }
    }
}
