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
        public FrmBoletas()
        {
            InitializeComponent();
            boleta.MostrarSalidas(dgvBoletas);
        }
    }
}
