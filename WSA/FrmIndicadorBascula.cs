using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using WSA.Clases;

namespace WSA
{
    public partial class FrmIndicadorBascula : Form
    {
        Indicador indicador = new Indicador();
        public FrmIndicadorBascula()
        {
            InitializeComponent();
            foreach (Control c in this.Controls)
            {
                if (c is Button)
                {
                    c.BackColor = Color.FromArgb(VariablesGlobales.rgbBotones[0], VariablesGlobales.rgbBotones[1], VariablesGlobales.rgbBotones[2]);
                }
            }


            string[] ports = SerialPort.GetPortNames();
            int[] baudRates = new int[] { 300, 600, 1200, 2400, 4800, 9600, 14400, 19200, 28800, 38400, 57600, 115200 };
            int[] dataBits = new int[] { 5,6,7,8};
            string[] parities = new string[] {"None", "Odd", "Even", "Mark", "Space" };
            string[] stopBits = new string[] { "One", "Two", "OnePointFive" };

            cmbPuertos.DataSource = ports;
            cmbVelocidad.DataSource = baudRates;
            cmbDataBits.DataSource = dataBits;
            cmbParidad.DataSource = parities;            
            cmbStopBit.DataSource = stopBits;
           // MessageBox.Show(((int)Enum.Parse(typeof(StopBits), "One")).ToString());
            indicador.CargarFormuarioIndicador(cmbPuertos, cmbVelocidad, cmbDataBits, cmbParidad, cmbStopBit, numMaximo, numMinimo, numPosicion);
            
        
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
           
            if(cmbPuertos.Items.Count > 0)
            {
                if(camposLlenos())
                {
                    getValues();
                    if (!indicador.ExisteIndicador(indicador))
                    {
                        indicador.AgregarIndicador(indicador);
                    }
                    else
                    {
                        indicador.ModificarIndicador(indicador);
                    }
                    MessageBox.Show("Cambios guardados", VariablesGlobales.TitleMessageBox, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    indicador.CargarFormuarioIndicador(cmbPuertos, cmbVelocidad, cmbDataBits, cmbParidad, cmbStopBit, numMaximo, numMinimo, numPosicion);
                }
                else
                {
                    MessageBox.Show("Debe llenar todos los campos", VariablesGlobales.TitleMessageBox, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                MessageBox.Show("No se ha detectado ningún puerto, conecte el cable serial", VariablesGlobales.TitleMessageBox, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            

        }

        private void getValues()
        {
            indicador.PortName = cmbPuertos.SelectedValue.ToString();
            indicador.BaudRate = Convert.ToInt32(cmbVelocidad.SelectedValue);
            indicador.DataBits = Convert.ToInt32(cmbDataBits.SelectedValue);
            indicador.Parity = cmbParidad.SelectedValue.ToString();
            indicador.StopBit = cmbStopBit.SelectedValue.ToString();
            indicador.Maximo = int.Parse(numMaximo.Value.ToString());
            indicador.Minimo = int.Parse(numMinimo.Value.ToString());
            indicador.PosicionSignoMas = int.Parse(numPosicion.Value.ToString());

        }

        private void btnProbarConexion_Click(object sender, EventArgs e)
        {
            indicador.probarConexion();
        }

        private bool camposLlenos()
        {
            if (numMaximo.Text != "" && numMinimo.Text != "" && numPosicion.Text != "")
                return true;
            else
                return false;
        }
    }
}
