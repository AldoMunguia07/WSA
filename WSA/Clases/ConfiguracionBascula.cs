using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using System.Threading;
using System.IO;
using System.Text.RegularExpressions;
using System.Drawing;

namespace WSA.Clases
{
    class ConfiguracionBascula
    {
        public delegate void DelegadoAcceso(string accion, TextBox txtDatos);

        public bool LeerDatos(SerialPort mySerialPort, FrmIngreso frmIngreso, Label lblConexion, TextBox txtPeso)
        {
            try
            {
                if (!mySerialPort.IsOpen)
                {
                    mySerialPort = new SerialPort(variable("PORT"), 9600, Parity.None, 8, StopBits.One);
                    mySerialPort.Handshake = Handshake.None;
                    mySerialPort.DataReceived += new SerialDataReceivedEventHandler(sp_DataReceived);
                    mySerialPort.ReadTimeout = 500;
                    mySerialPort.WriteTimeout = 500;
                    mySerialPort.Open();
                    lblConexion.Text = "Conectado";
                    lblConexion.ForeColor = Color.Green;
                    return true;
                }
                else
                {
                    return false;
                }

            }
            catch (Exception ex)
            {
                
                MessageBox.Show(ex.Message);
                return false;
            }

            void sp_DataReceived(object sender, SerialDataReceivedEventArgs e)
            {

                try
                {
                    Thread.Sleep(500);
                    string data = mySerialPort.ReadExisting();
                    frmIngreso.BeginInvoke(new DelegadoAcceso(si_DataReceived), new object[] { data, txtPeso });
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private string variable(string var)
        {
            
            string[] lineas = File.ReadAllLines("c:/config/CONFIGURACION.txt");

            string valor = "";


            foreach (string val in lineas)
            {
                Match match = Regex.Match(val, string.Format("{0}", var));

                if (match.Value == var)
                {
                    valor = val.Substring(match.Value.Length + 1);
                }

            }
            return valor;

        }



        private void si_DataReceived(string accion, TextBox txtDatos)
        {
            txtDatos.Text = accion;
            Match m = Regex.Match(accion, "(\\d+).(\\d+)|(\\d+)");

            if (m.Success)
            {
                if (accion.Substring(6, 1) == "+")
                {
                    if (float.Parse(m.Value) <= float.Parse(variable("MAX")))
                    {
                        if (float.Parse(m.Value) >= float.Parse(variable("MIN")))
                        {
                            txtDatos.Text = string.Format("{0:n} Kg", float.Parse(m.Value));
                        }
                        else
                        {
                            txtDatos.Text = String.Format("Mínimo - {0} Kg", variable("MIN"));
                        }
                    }
                    else
                    {
                        txtDatos.Text = String.Format("Máximo - {0} Kg", variable("MAX"));
                    }
                }
                else
                {
                    txtDatos.Text = "No valores negativos";
                }
            }
            else
            {
                txtDatos.Text = "Sin valores numéricos";
            }
        }
    }
}
