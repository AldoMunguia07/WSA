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
    public partial class FrmVehiculosEnTransito : Form
    {
        Boleta boleta = new Boleta();
        private int idBoleta = 0;
        private bool seleccionado = false;
        
        public FrmVehiculosEnTransito()
        {
            InitializeComponent();
            boleta.MostrarEntradas(dgvEntradas);
        }

        private void btnEntrada_Click(object sender, EventArgs e)
        {
            FrmIngreso frmIngreso = new FrmIngreso();
            frmIngreso.ShowDialog();
            boleta.MostrarEntradas(dgvEntradas);
            seleccionado = false;
        }

        private void btnSalida_Click(object sender, EventArgs e)
        {
            if(seleccionado)
            {
                FrmSalida frmSalida = new FrmSalida(idBoleta);
                frmSalida.ShowDialog();
                boleta.MostrarEntradas(dgvEntradas);
                seleccionado = false;
            }
            else
            {
                MessageBox.Show("Seleccione una entrada", "WAS", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }

        private void dgvEntradas_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvEntradas.Rows[e.RowIndex];
                row.Selected = true;
                idBoleta = int.Parse(row.Cells[0].Value.ToString());
                seleccionado = true;
            }
           
        }
    }
}
