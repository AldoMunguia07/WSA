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
    public partial class FrmMotivo : Form
    {
        Boleta boleta = new Boleta();
        public FrmMotivo()
        {
            InitializeComponent();
            panel1.BackColor = Color.FromArgb(VariablesGlobales.rgbPanel[0], VariablesGlobales.rgbPanel[1], VariablesGlobales.rgbPanel[2]);
            panel2.BackColor = Color.FromArgb(VariablesGlobales.rgbPanel[0], VariablesGlobales.rgbPanel[1], VariablesGlobales.rgbPanel[2]);
            boleta = VariablesGlobales.Boleta;
        }

        private void btnAnular_Click(object sender, EventArgs e)
        {
            boleta.Observaciones = txtMotivo.Text;
            boleta.AnularEntrada(boleta);
            MessageBox.Show(String.Format("Entrada {0} anulada", boleta.BoletaId), VariablesGlobales.TitleMessageBox, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
