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
        Indicador indicador = new Indicador();
        Boleta boleta = new Boleta();
        Conductor conductor = new Conductor();
        private bool conectado = false;
        public FrmIngreso()
        {
            InitializeComponent();
            
            conectado = indicador.LeerDatos(/*mySerialPort,*/ this, lblConexion, txtPesoBascula);
            


        }

        private void txtObtenerPeso_Click(object sender, EventArgs e)
        {

            Match m = Regex.Match(txtPesoBascula.Text, "(\\d+).(\\d+)|(\\d+)");
            if(m.Success)
            {
                if (float.Parse(m.Value) > 0)
                {
                    if (float.Parse(m.Value) < float.Parse(indicador.Variable("MAX")))
                    {
                        txtPesoEntrada.Text = m.Value;
                    }
                    else
                    {
                        MessageBox.Show(String.Format("El peso máximo es {0}", indicador.Variable("MAX")), VariablesGlobales.TitleMessageBox, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }

                }
                else
                {
                    MessageBox.Show("El peso debe ser mayor a 0", VariablesGlobales.TitleMessageBox, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            
            
        }

        private void btnConectar_Click(object sender, EventArgs e)
        {
            if (!conectado)
            {
                conectado = indicador.LeerDatos(/*mySerialPort,*/ this, lblConexion, txtPesoBascula);
            }
            else
            {
                MessageBox.Show("Ya se ecnuentra conectado", VariablesGlobales.TitleMessageBox, MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if(camposLlenos())
            {
                getValues();
                if (boleta.AgregarEntrada(boleta))
                {
                    MessageBox.Show("Entrada agregada", VariablesGlobales.TitleMessageBox, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    FrmTicketEntrada frmTicketEntrada = new FrmTicketEntrada(boleta.UltimaBoleta());
                    frmTicketEntrada.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Error al agregar entrada", VariablesGlobales.TitleMessageBox, MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
               
                
                
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
            boleta.UsuarioId = VariablesGlobales.Usuario.UsuarioId;
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
                if(txtPlacaCabezal.Text != "")
                {
                    if(txtPlacaRastra.Text != "")
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
                                        MessageBox.Show("Obtenga el peso de la báscula", VariablesGlobales.TitleMessageBox, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("Ingrese el código del barco", VariablesGlobales.TitleMessageBox, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                }
                            }
                            else
                            {
                                MessageBox.Show("Ingrese el código del producto", VariablesGlobales.TitleMessageBox, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Ingrese el código del cliente", VariablesGlobales.TitleMessageBox, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Ingrese la placa de la rastra", VariablesGlobales.TitleMessageBox, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                else
                {
                    MessageBox.Show("Ingrese la placa del cabezal", VariablesGlobales.TitleMessageBox, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                MessageBox.Show("Ingrese el código del conductor", VariablesGlobales.TitleMessageBox, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            return false;

        }

        private void FrmIngreso_FormClosed(object sender, FormClosedEventArgs e)
        {

            indicador.Desconectar();



        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lblConsultarConductores_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmConductor frmConductor = new FrmConductor(true);
            frmConductor.ShowDialog();
            if(VariablesGlobales.Conductor != null)
            {
                txtCodigoConductor.Text = VariablesGlobales.Conductor.ConductorId.ToString();
                txtConductor.Text = VariablesGlobales.Conductor.ConductorD;
                VariablesGlobales.Conductor = null;
            }
        }

        private void lblConsultarClientes_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmCliente frmCliente = new FrmCliente(true);
            frmCliente.ShowDialog();
            if (VariablesGlobales.Cliente != null)
            {
                txtCodigoCliente.Text = VariablesGlobales.Cliente.ClienteId.ToString();
                txtCliente.Text = VariablesGlobales.Cliente.ClienteD;
                VariablesGlobales.Cliente = null;
            }
        }

        private void lblConsultarProductos_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmProducto frmProducto = new FrmProducto(true);
            frmProducto.ShowDialog();
            if (VariablesGlobales.Producto != null)
            {
                txtCodigoProducto.Text = VariablesGlobales.Producto.ProductoId.ToString();
                txtProducto.Text = VariablesGlobales.Producto.Descripcion;
                VariablesGlobales.Producto = null;
            }
        }

        private void lblConsultarBarcos_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmBarco frmBarco = new FrmBarco(true);
            frmBarco.ShowDialog();
            if (VariablesGlobales.Barco != null)
            {
                txtCodigoBarco.Text = VariablesGlobales.Barco.BarcoId.ToString();
                txtBarco.Text = VariablesGlobales.Barco.Descripcion;
                VariablesGlobales.Barco = null;
            }
        }

        private void txtPlacaCabezal_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetterOrDigit(e.KeyChar))
            {
                e.Handled = true;
            }

            
        }

        private void txtPlacaRastra_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetterOrDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtPlacaCabezal_TextChanged(object sender, EventArgs e)
        {
           
            txtPlacaCabezal.CharacterCasing = CharacterCasing.Upper;
        }

        private void txtPlacaRastra_TextChanged(object sender, EventArgs e)
        {
           
            txtPlacaRastra.CharacterCasing = CharacterCasing.Upper;

        }
    }
}
