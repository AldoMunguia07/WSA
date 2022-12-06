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
    public partial class FrmIngreso : Form
    {
        ConfiguracionBascula configuracionBascula = new ConfiguracionBascula();
        Boleta boleta = new Boleta();
        private bool conectado = false;
        public FrmIngreso()
        {
            InitializeComponent();
            conectado = configuracionBascula.LeerDatos(mySerialPort, this, lblConexion, txtPesoBascula);
           

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
                MessageBox.Show("El peso debe ser mayor a 0", "WAS", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            
        }

        private void btnConectar_Click(object sender, EventArgs e)
        {
            if(!conectado)
            {
                conectado = configuracionBascula.LeerDatos(mySerialPort, this, lblConexion, txtPesoBascula);
            }
            else
            {
                MessageBox.Show(String.Format("Ya se ecnuentra conectado al puerto {0}", mySerialPort.PortName), "WAS", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

                    
            
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            //boleta.AgregarEntrada();
        }
    }
}
