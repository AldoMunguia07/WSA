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

namespace WSA
{
    public partial class FrmSalida : Form
    {
        Boleta boleta = new Boleta();
        Indicador indicador = new Indicador();
        private bool conectado = false;
        private int idBoleta = 0;
        public FrmSalida(int boletaId)
        {
            InitializeComponent();
            idBoleta = boletaId;
            boleta.CargarFormularioSalida(idBoleta, dtpFechaEntrada, dtpHoraEntrada, txtCodigoConductor, txtConductor, txtPlacaCabezal, txtPlacaRastra, txtCia, txtEnvioN, txtCodigoCliente, 
                txtCliente, txtCodigoProducto, txtProducto, txtCodigoBarco, txtBarco, txtPesoEntrada, txtObservaciones);
            conectado = indicador.LeerDatos(/*mySerialPort,*/ this, lblConexion, txtPesoBascula);
        }

        private void btnConectar_Click(object sender, EventArgs e)
        {
            if (!conectado)
            {
                conectado = indicador.LeerDatos(/*mySerialPort,*/ this, lblConexion, txtPesoBascula);
            }
            else
            {
                MessageBox.Show("Ya se ecnuentra conectado", VariablesGlobales.TitleMessageBox, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void txtObtenerPeso_Click(object sender, EventArgs e)
        {
            

            Match m = Regex.Match(txtPesoBascula.Text, "(\\d+).(\\d+)|(\\d+)");
            Match maximo = Regex.Match(txtPesoBascula.Text, "Máximo");
            Match minimo = Regex.Match(txtPesoBascula.Text, "Mínimo");
            DataTable data = indicador.indicadorTable();

            
            if (m.Success)
            {
                if (float.Parse(m.Value) > 0)
                {
                    if (!maximo.Success)
                    {
                        if (!minimo.Success)
                        {
                            txtPesoSalida.Text = String.Format("{0:n}", float.Parse(m.Value));
                        }
                        else
                        {
                            MessageBox.Show(String.Format("El peso mínimo es {0:n} Kg", float.Parse(data.Rows[0]["Minimo"].ToString())), VariablesGlobales.TitleMessageBox, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    else
                    {
                        MessageBox.Show(String.Format("El peso máximo es {0:n} Kg", float.Parse(data.Rows[0]["Maximo"].ToString())), VariablesGlobales.TitleMessageBox, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }

                    


                }
                else
                {
                    MessageBox.Show("El peso debe ser mayor a 0", VariablesGlobales.TitleMessageBox, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                txtPesoSalida.Clear();
            }
            
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if(camposLlenos())
            {
                if(float.Parse(txtPesoSalida.Text) > float.Parse(txtPesoEntrada.Text))
                {
                    getValues();
                    if(boleta.AgregarSalida(boleta))
                    {
                        MessageBox.Show("Salida agregada", VariablesGlobales.TitleMessageBox, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        FrmTicket frmTicket = new FrmTicket(boleta.UltimaBoleta());
                        frmTicket.ShowDialog();
                    }
                    else
                    {
                       MessageBox.Show("Error al agregar salida", VariablesGlobales.TitleMessageBox, MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }

                    this.Close();
                }
                else
                {
                    MessageBox.Show("El peso de salida debe ser mayor al peso de entrada", VariablesGlobales.TitleMessageBox, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

            }
            
        }

        private void getValues()
        {
            boleta.BoletaId = idBoleta;
            boleta.FechaSalida = DateTime.Now;
            boleta.PlacaCabezal = txtPlacaCabezal.Text;
            boleta.PlacaRastra = txtPlacaRastra.Text;
            boleta.ConductorId = int.Parse(txtCodigoConductor.Text);
            boleta.ClienteId = int.Parse(txtCodigoCliente.Text);
            boleta.ProductoId = int.Parse(txtCodigoProducto.Text);
            boleta.CiaTransportista = txtCia.Text;
            boleta.EnvioN = txtEnvioN.Text;
            boleta.BarcoId = int.Parse(txtCodigoBarco.Text);
            boleta.PesoSalida = float.Parse(txtPesoSalida.Text);
            boleta.UnidadesPesoSalida = Regex.Match(txtPesoBascula.Text, "([A-Za-z]+)").Value;
            boleta.UsuarioId = VariablesGlobales.Usuario.UsuarioId;
            boleta.Estado = 'C';
            boleta.Observaciones = txtObservaciones.Text;

        }

        private bool camposLlenos()
        {
            if (txtCodigoConductor.Text != "")
            {
                if (txtPlacaCabezal.Text != "")
                {
                    if (txtPlacaRastra.Text != "")
                    {
                        if (txtCodigoCliente.Text != "")
                        {
                            if (txtCodigoProducto.Text != "")
                            {
                                if (txtCodigoBarco.Text != "")
                                {
                                    if (txtPesoSalida.Text != "")
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

        private void FrmSalida_FormClosed(object sender, FormClosedEventArgs e)
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
            if (VariablesGlobales.Conductor != null)
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

        private void txtCodigoConductor_Leave(object sender, EventArgs e)
        {
            if (txtCodigoConductor.Text != "")
            {
                boleta.BuscarConductor(txtCodigoConductor, txtConductor);
            }
        }

        private void txtCodigoCliente_Leave(object sender, EventArgs e)
        {
            if (txtCodigoCliente.Text != "")
            {
                boleta.BuscarCliente(txtCodigoCliente, txtCliente);
            }
        }

        private void txtCodigoProducto_Leave(object sender, EventArgs e)
        {
            if (txtCodigoProducto.Text != "")
            {
                boleta.BuscarProducto(txtCodigoProducto, txtProducto);
            }
        }

        private void txtCodigoBarco_Leave(object sender, EventArgs e)
        {
            if (txtCodigoBarco.Text != "")
            {
                boleta.BuscarBarco(txtCodigoBarco, txtBarco);
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
