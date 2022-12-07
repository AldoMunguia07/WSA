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
using System.Text.RegularExpressions;
using System.IO.Ports;

namespace WSA
{
    public partial class FrmIngreso : Form
    {
        ConfiguracionBascula configuracionBascula = new ConfiguracionBascula();
        Boleta boleta = new Boleta();
        private bool conectado = false;
        public FrmIngreso()
        {
            InitializeComponent();
            
            conectado = configuracionBascula.LeerDatos(/*mySerialPort,*/ this, lblConexion, txtPesoBascula);
            


        }

        private void txtObtenerPeso_Click(object sender, EventArgs e)
        {

            Match m = Regex.Match(txtPesoBascula.Text, "(\\d+).(\\d+)|(\\d+)");
            if(float.Parse(m.Value) > 0)
            {
                txtPesoEntrada.Text = m.Value;
            }
            else
            {
                MessageBox.Show("El peso debe ser mayor a 0", "WAS", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
        }

        private void btnConectar_Click(object sender, EventArgs e)
        {
            if(!conectado)
            {
                conectado = configuracionBascula.LeerDatos(/*mySerialPort,*/ this, lblConexion, txtPesoBascula);
            }
            else
            {
                MessageBox.Show(String.Format("Ya se ecnuentra conectado al puerto {0}", ""), "WAS", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                
            }

                    
            
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if(camposLlenos())
            {
                getValues();
                boleta.AgregarEntrada(boleta);
                MessageBox.Show("Entrada agregada", "WAS", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.Close();
            }
           
        }

        private void getValues()
        {
            boleta.FechaEntrada = DateTime.Now;
            boleta.PlacaCabezal = txtPlacaCabezal.Text;
            boleta.PlacaRastra = txtPlacaRastra.Text;
            boleta.ConductorId = int.Parse(txtCodigoConductor.Text);
            boleta.ClienteId = int.Parse(txtCodigoCliente.Text);
            boleta.ProductoId = int.Parse(txtCodigoProducto.Text);
            boleta.PesoIngreso = float.Parse(txtPesoEntrada.Text);
            boleta.UnidadesPesoIngreso = Regex.Match(txtPesoBascula.Text, "([A-Za-z]+)").Value;
            boleta.CiaTransportista = txtCia.Text;
            boleta.EnvioN = txtEnvioN.Text;
            boleta.BarcoId = int.Parse(txtCodigoBarco.Text);
            boleta.UsuarioId = 1;
            boleta.Estado = 'P';
            boleta.Observaciones = txtObservaciones.Text;

        }

        private void txtCodigoConductor_Leave(object sender, EventArgs e)
        {
            if(txtCodigoConductor.Text != "")
            {
                boleta.BuscarConductor(txtCodigoConductor, txtConductor);
            }
            
        }

        private void txtCodigoCliente_Leave(object sender, EventArgs e)
        {
            if(txtCodigoCliente.Text != "")
            {
                boleta.BuscarCliente(txtCodigoCliente, txtCliente);
            }
            
        }

        private void txtCodigoProducto_Leave(object sender, EventArgs e)
        {
            if(txtCodigoProducto.Text != "")
            {
                boleta.BuscarProducto(txtCodigoProducto, txtProducto);
            }
            
        }

        private void txtCodigoBarco_Leave(object sender, EventArgs e)
        {
            if(txtCodigoBarco.Text != "")
            {
                boleta.BuscarBarco(txtCodigoBarco, txtBarco);
            }
            
        }

        private bool camposLlenos()
        {
            if (txtCodigoConductor.Text != "")
            {
                if(/*txtPlacaCabezal.Text != ""*/true)
                {
                    if(/*txtPlacaRastra.Text != ""*/true)
                    {
                        if(txtCodigoCliente.Text != "")
                        {
                            if(txtCodigoProducto.Text != "")
                            {
                                if(txtCodigoBarco.Text != "")
                                {
                                    if(txtPesoEntrada.Text != "")
                                    {
                                        return true;
                                    }
                                    else
                                    {
                                        MessageBox.Show("Obtenga el peso de la báscula", "WAS", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("Ingrese el código del barco", "WAS", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                }
                            }
                            else
                            {
                                MessageBox.Show("Ingrese el código del producto", "WAS", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Ingrese el código del cliente", "WAS", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Ingrese la placa de la rastra", "WAS", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                else
                {
                    MessageBox.Show("Ingrese la placa del cabezal", "WAS", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                MessageBox.Show("Ingrese el código del conductor", "WAS", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            return false;

        }

        private void FrmIngreso_FormClosed(object sender, FormClosedEventArgs e)
        {

            configuracionBascula.Desconectar();



        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
