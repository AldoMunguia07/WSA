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
        ConfiguracionBascula configuracionBascula = new ConfiguracionBascula();
        private bool conectado = false;
        private int idBoleta = 0;
        public FrmSalida(int boletaId)
        {
            InitializeComponent();
            idBoleta = boletaId;
            boleta.CargarFormularioSalida(idBoleta, dtpFechaEntrada, dtpHoraEntrada, txtCodigoConductor, txtConductor, txtPlacaCabezal, txtPlacaRastra, txtCia, txtEnvioN, txtCodigoCliente, 
                txtCliente, txtCodigoProducto, txtProducto, txtCodigoBarco, txtBarco, txtPesoEntrada, txtObservaciones);
            conectado = configuracionBascula.LeerDatos(/*mySerialPort,*/ this, lblConexion, txtPesoBascula);
        }

        private void btnConectar_Click(object sender, EventArgs e)
        {
            if (!conectado)
            {
                conectado = configuracionBascula.LeerDatos(/*mySerialPort,*/ this, lblConexion, txtPesoBascula);
            }
            else
            {
                MessageBox.Show(String.Format("Ya se ecnuentra conectado al puerto {0}", mySerialPort.PortName), "WAS", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void txtObtenerPeso_Click(object sender, EventArgs e)
        {
            Match m = Regex.Match(txtPesoBascula.Text, "(\\d+).(\\d+)|(\\d+)");
            if (float.Parse(m.Value) > 0)
            {
                txtPesoSalida.Text = m.Value;
            }
            else
            {
                MessageBox.Show("El peso debe ser mayor a 0", "WAS", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if(txtPesoSalida.Text != "")
            {
                if(float.Parse(txtPesoSalida.Text) > float.Parse(txtPesoEntrada.Text))
                {
                    getValues();
                    boleta.AgregarSalida(boleta);
                    MessageBox.Show("Salida agregada", "WAS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("El peso de salida debe ser mayor al peso de entrada", "WAS", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

            }
            else
            {
                MessageBox.Show("Obtenga el peso de la báscula", "WAS", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            
        }

        private void getValues()
        {
            boleta.BoletaId = idBoleta;
            boleta.FechaSalida = DateTime.Now;
            boleta.PesoSalida = float.Parse(txtPesoSalida.Text);
            boleta.UnidadesPesoSalida = Regex.Match(txtPesoBascula.Text, "([A-Za-z]+)").Value;
            boleta.UsuarioId = VariablesGlobales.Usuario.UsuarioId;
            boleta.Estado = 'C';
            boleta.Observaciones = txtObservaciones.Text;

        }

        private void FrmSalida_FormClosed(object sender, FormClosedEventArgs e)
        {
            configuracionBascula.Desconectar();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
