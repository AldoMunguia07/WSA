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
            cargarGraficos();
        }

        private void cargarGraficos()
        {
            grafico.Datos(lblTotalBoletas, lblProceso, lblAnuladas, lblPesoTotal, lblPesoPromedio, lblMayorPesaje, lblMenorPesaje, lblAdministradores, lblOperadores,
                lblConductores, lblClientes, lblBarcos, lblProductos);

            grafico.UltimosMeses(gpMeses);
            grafico.Operadores(gpOperadores);
            grafico.Producto(gpProductos);
            grafico.Conductores(gpConductores);
        }
    }
}
