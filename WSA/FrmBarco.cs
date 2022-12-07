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
    public partial class FrmBarco : Form
    {
        Barco barco = new Barco();
        private bool seleccionado = false;
        public FrmBarco()
        {
            InitializeComponent();
            barco.MostrarBarcos(dgvClientes);
        }
    }
}
