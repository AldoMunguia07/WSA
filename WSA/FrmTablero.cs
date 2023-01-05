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
    public partial class FrmTablero: Form
    {
        Grafico grafico = new Grafico();
        public FrmTablero()
        {
            InitializeComponent();
            grafico.UltimosMeses(gpMeses);
            grafico.TopOperadores(gpOperadores);
            grafico.TopProductos(gpProductos);
            grafico.TopConductores(gpConductores);





        }
    }
}
