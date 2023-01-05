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
           lblTotalBoletas.Text = grafico.Datos().Rows[0]["Boletas"].ToString();
            lblProceso.Text = grafico.Datos().Rows[0]["Proceso"].ToString();
            lblAnuladas.Text = grafico.Datos().Rows[0]["Proceso"].ToString();
            lblPesoTotal.Text = grafico.Datos().Rows[0]["Peso_Total"].ToString();
            lblPesoPromedio.Text = grafico.Datos().Rows[0]["Peso_Promedio"].ToString();
            lblMayorPesaje.Text = grafico.Datos().Rows[0]["Mayor_Pesaje"].ToString();
            lblMenorPesaje.Text = grafico.Datos().Rows[0]["Menor_Pesaje"].ToString();
            lblAdministradores.Text = grafico.Datos().Rows[0]["Administradores"].ToString();
            lblOperadores.Text = grafico.Datos().Rows[0]["Operadores"].ToString();
            lblConductores.Text = grafico.Datos().Rows[0]["Conductores"].ToString();
            lblClientes.Text = grafico.Datos().Rows[0]["Clientes"].ToString();
            lblBarcos.Text = grafico.Datos().Rows[0]["Barcos"].ToString();
            lblProductos.Text = grafico.Datos().Rows[0]["Productos"].ToString();

            grafico.UltimosMeses(gpMeses);
            grafico.TopOperadores(gpOperadores);
            grafico.TopProductos(gpProductos);
            grafico.TopConductores(gpConductores);
        }
    }
}
