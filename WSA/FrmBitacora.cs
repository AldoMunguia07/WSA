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
    public partial class FrmBitacora : Form
    {
        Bitacora bitacora = new Bitacora();
        public FrmBitacora()
        {
            InitializeComponent();
         
            cargarBitacora();
        }

        private void cargarBitacora()
        {
           // MessageBox.Show(dtpFechaInicio.Value.ToString());
            bitacora.MostrarBitacora(dgvBitacora, dtpFechaInicio, dtpFechaFinal, txtBuscar.Text);
        }

        private void dtpFechaInicio_ValueChanged(object sender, EventArgs e)
        {
            cargarBitacora();
        }

    
        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            cargarBitacora();
        }

        private void dtpFechaFinal_ValueChanged(object sender, EventArgs e)
        {
            cargarBitacora();
        }

        private void dgvBitacora_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvBitacora.Rows[e.RowIndex];
                row.Selected = true;
                
            }
        }
    }
}
