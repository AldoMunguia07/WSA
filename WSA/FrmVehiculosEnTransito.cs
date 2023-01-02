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
            panel1.BackColor = Color.FromArgb(VariablesGlobales.rgbPanel[0], VariablesGlobales.rgbPanel[1], VariablesGlobales.rgbPanel[2]);
            panel2.BackColor = Color.FromArgb(VariablesGlobales.rgbPanel[0], VariablesGlobales.rgbPanel[1], VariablesGlobales.rgbPanel[2]);

            btnEntrada.BackColor = Color.FromArgb(VariablesGlobales.rgbBotones[0], VariablesGlobales.rgbBotones[1], VariablesGlobales.rgbBotones[2]);
            btnSalida.BackColor = Color.FromArgb(VariablesGlobales.rgbBotones[0], VariablesGlobales.rgbBotones[1], VariablesGlobales.rgbBotones[2]);
            btnImprimir.BackColor = Color.FromArgb(VariablesGlobales.rgbBotones[0], VariablesGlobales.rgbBotones[1], VariablesGlobales.rgbBotones[2]);
            btnAnular.BackColor = Color.FromArgb(VariablesGlobales.rgbBotones[0], VariablesGlobales.rgbBotones[1], VariablesGlobales.rgbBotones[2]);


            boleta.MostrarEntradas(dgvEntradas);
        }

        private void btnEntrada_Click(object sender, EventArgs e)
        {
            FrmIngreso frmIngreso = new FrmIngreso();
            frmIngreso.ShowDialog();
            refresh();
        }

        private void refresh()
        {
            boleta.MostrarEntradas(dgvEntradas);
            seleccionado = false;
            txtBuscar.Clear();
        }
        private void btnSalida_Click(object sender, EventArgs e)
        {
            if(seleccionado)
            {
                FrmSalida frmSalida = new FrmSalida(idBoleta);
                frmSalida.ShowDialog();
                refresh();
            }
            else
            {
                MessageBox.Show("Seleccione una entrada", VariablesGlobales.TitleMessageBox, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }

        private void dgvEntradas_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvEntradas.Rows[e.RowIndex];
                row.Selected = true;
                idBoleta = int.Parse(row.Cells[0].Value.ToString());
                boleta.BoletaId = int.Parse(row.Cells[0].Value.ToString());
                boleta.Estado = 'A';
                seleccionado = true;
            }
           
        }

        private void btnAnular_Click(object sender, EventArgs e)
        {
            if (seleccionado)
            {
              DialogResult dialogResult =  MessageBox.Show(String.Format("¿Está seguro de anular la entrada con código {0}?", boleta.BoletaId), VariablesGlobales.TitleMessageBox, MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if(dialogResult == DialogResult.Yes)
                {
                    VariablesGlobales.Boleta = boleta;
                    FrmMotivo frmMotivo = new FrmMotivo();
                    frmMotivo.ShowDialog();
                    
                    
                }
                VariablesGlobales.Boleta = null;
                refresh();


            }
            else
            {
                MessageBox.Show("Seleccione una entrada", VariablesGlobales.TitleMessageBox, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            if (seleccionado)
            {
                FrmTicketEntrada frmTicketEntrada = new FrmTicketEntrada(idBoleta);
                frmTicketEntrada.ShowDialog();
                refresh();
            }
            else
            {
                MessageBox.Show("Seleccione una entrada", VariablesGlobales.TitleMessageBox, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            boleta.BuscarEntradaPorCodigo(txtBuscar.Text, dgvEntradas);
        }
    }
}
