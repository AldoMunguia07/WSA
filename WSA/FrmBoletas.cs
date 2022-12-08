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
    public partial class FrmBoletas : Form
    {
        Boleta boleta = new Boleta();
        private int idBoleta = 0;
        private bool seleccionado = false;
        public FrmBoletas()
        {
            InitializeComponent();
            boleta.MostrarBoletas(dgvBoletas);
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            
            if (seleccionado)
            {
                FrmTicket frmTicket = new FrmTicket(idBoleta);
                frmTicket.ShowDialog();
                boleta.MostrarBoletas(dgvBoletas);
                seleccionado = false;
            }
            else
            {
                MessageBox.Show("Seleccione una boleta", "WAS", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnVerBoleta_Click(object sender, EventArgs e)
        {
            if (seleccionado)
            {
                FrmVerBoleta frmVerBoleta = new FrmVerBoleta(idBoleta);
                frmVerBoleta.ShowDialog();
                boleta.MostrarBoletas(dgvBoletas);
                seleccionado = false;
            }
            else
            {
                MessageBox.Show("Seleccione una boleta", "WAS", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void dgvBoletas_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvBoletas.Rows[e.RowIndex];
                row.Selected = true;
                idBoleta = int.Parse(row.Cells[0].Value.ToString());
                seleccionado = true;
            }
        }
    }
}
