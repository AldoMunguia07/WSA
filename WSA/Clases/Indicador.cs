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
using System.Data.SqlClient;
using System.Configuration;
using System.Data;
using System.Windows.Forms;

namespace WSA.Clases
{
    class Indicador
    {
        Conexion conexion = new Conexion();
        Bitacora bitacora = new Bitacora();

        //PROPIEDADES
        public int IndicadorId { get; set; }
        public string PortName { get; set; }
        public int BaudRate { get; set; }
        public int DataBits { get; set; }
        public string Parity { get; set; }
        public string StopBit { get; set; }
        public int Maximo { get; set; }
        public int Minimo { get; set; }
        public int PosicionSignoMas { get; set; }

        SerialPort mySerialPort = new SerialPort() ;


        //METODOS
        public void CargarFormuarioIndicador(ComboBox cmbPuertos, ComboBox cmbVelocidad, ComboBox cmbDataBits, ComboBox cmbParidad, ComboBox cmbStopBit, NumericUpDown numMaximo,
            NumericUpDown numMinimo, NumericUpDown numPosicion)
        {

            try
            {
                conexion.sqlConnection.Open();

                SqlCommand sqlCommand = new SqlCommand("sp_Indicador", conexion.sqlConnection);

                sqlCommand.CommandType = CommandType.StoredProcedure;

                // Establecer los valores de los parámetros

                sqlCommand.Parameters.AddWithValue("@accion", "obtenerIndicador");

                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
                using (SqlDataReader rdr = sqlCommand.ExecuteReader())
                {
                    while (rdr.Read())
                    {
                        cmbPuertos.SelectedItem = rdr["Port_Name"].ToString();
                        cmbVelocidad.SelectedItem = int.Parse(rdr["Baud_Rate"].ToString());
                        cmbDataBits.SelectedItem = int.Parse(rdr["Data_Bits"].ToString());
                        cmbParidad.SelectedItem = rdr["Parity"].ToString();
                        cmbStopBit.SelectedItem = rdr["Stop_Bit"].ToString();
                        numMaximo.Value = int.Parse(rdr["Maximo"].ToString());
                        numMinimo.Value = int.Parse(rdr["Minimo"].ToString());
                        numPosicion.Value = int.Parse(rdr["Posicion_Signo_Mas"].ToString());

                    }

                }


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message.ToString(), "WAS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                // Cerrar la conexión
                conexion.sqlConnection.Close();
            }
        }

        public bool ExisteIndicador(Indicador indicador)
        {
            try
            {

                conexion.sqlConnection.Open();

                SqlCommand sqlCommand = new SqlCommand("sp_Indicador", conexion.sqlConnection);
                sqlCommand.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);

                using (sqlDataAdapter)
                {
                    sqlCommand.Parameters.AddWithValue("@accion", "obtenerIndicador");

                    DataTable dataTable = new DataTable();

                    sqlDataAdapter.Fill(dataTable);

                    if (dataTable.Rows.Count == 1)
                    {
                        indicador.IndicadorId = int.Parse(dataTable.Rows[0]["Indicador_Id"].ToString());
                        return true;
                    }

                    return false;
                }
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                conexion.sqlConnection.Close();
            }
        }

        public void AgregarIndicador(Indicador indicador)
        {
            try
            {
                conexion.sqlConnection.Open();

                SqlCommand sqlCommand = new SqlCommand("sp_Indicador", conexion.sqlConnection);
                sqlCommand.CommandType = CommandType.StoredProcedure;

                // Establecer los valores de los parámetros
                sqlCommand.Parameters.AddWithValue("@Port_Name", indicador.PortName);
                sqlCommand.Parameters.AddWithValue("@Baud_Rate", indicador.BaudRate);
                sqlCommand.Parameters.AddWithValue("@Data_Bits", indicador.DataBits);
                sqlCommand.Parameters.AddWithValue("@Parity", indicador.Parity);
                sqlCommand.Parameters.AddWithValue("@Stop_Bit", indicador.StopBit);
                sqlCommand.Parameters.AddWithValue("@Maximo", indicador.Maximo);
                sqlCommand.Parameters.AddWithValue("@Minimo", indicador.Minimo);
                sqlCommand.Parameters.AddWithValue("@Posicion_Signo_Mas", indicador.PosicionSignoMas);
                sqlCommand.Parameters.AddWithValue("@accion", "insertar");
                bitacora.DefinirUsuarioId(VariablesGlobales.Usuario.UsuarioId, conexion.sqlConnection);
                sqlCommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                // Cerrar la conexión
                conexion.sqlConnection.Close();
            }
        }

        public void ModificarIndicador(Indicador indicador)
        {
            try
            {
                conexion.sqlConnection.Open();

                SqlCommand sqlCommand = new SqlCommand("sp_Indicador", conexion.sqlConnection);
                sqlCommand.CommandType = CommandType.StoredProcedure;

                // Establecer los valores de los parámetros
                sqlCommand.Parameters.AddWithValue("@Indicador_Id", indicador.IndicadorId);
                sqlCommand.Parameters.AddWithValue("@Port_Name", indicador.PortName);
                sqlCommand.Parameters.AddWithValue("@Baud_Rate", indicador.BaudRate);
                sqlCommand.Parameters.AddWithValue("@Data_Bits", indicador.DataBits);
                sqlCommand.Parameters.AddWithValue("@Parity", indicador.Parity);
                sqlCommand.Parameters.AddWithValue("@Stop_Bit", indicador.StopBit);
                sqlCommand.Parameters.AddWithValue("@Maximo", indicador.Maximo);
                sqlCommand.Parameters.AddWithValue("@Minimo", indicador.Minimo);
                sqlCommand.Parameters.AddWithValue("@Posicion_Signo_Mas", indicador.PosicionSignoMas);
                sqlCommand.Parameters.AddWithValue("@accion", "modificar");
                bitacora.DefinirUsuarioId(VariablesGlobales.Usuario.UsuarioId, conexion.sqlConnection);
                sqlCommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                // Cerrar la conexión
                conexion.sqlConnection.Close();
            }
        }

        private void ConfigurarPuertoSerial()
        {

            try
            {
                conexion.sqlConnection.Open();

                SqlCommand sqlCommand = new SqlCommand("sp_Indicador", conexion.sqlConnection);

                sqlCommand.CommandType = CommandType.StoredProcedure;


                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
               

                using (sqlDataAdapter)
                {
                    sqlCommand.Parameters.AddWithValue("@accion", "obtenerIndicador");

                    DataTable dataTable = new DataTable();

                    sqlDataAdapter.Fill(dataTable);

                    if (dataTable.Rows.Count == 1)
                    {
                        
                        mySerialPort.PortName = dataTable.Rows[0]["Port_Name"].ToString();
                        mySerialPort.BaudRate = int.Parse(dataTable.Rows[0]["Baud_Rate"].ToString());
                        mySerialPort.DataBits = int.Parse(dataTable.Rows[0]["Data_Bits"].ToString());
                        mySerialPort.Parity = (Parity)Enum.GetValues(typeof(Parity)).GetValue((int)Enum.Parse(typeof(Parity), dataTable.Rows[0]["Parity"].ToString()));
                        mySerialPort.StopBits = (StopBits)Enum.GetValues(typeof(StopBits)).GetValue((int)Enum.Parse(typeof(StopBits), dataTable.Rows[0]["Stop_Bit"].ToString())); ;
                    }

                  
                }


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                // Cerrar la conexión
                conexion.sqlConnection.Close();
            }
        }



        public delegate void DelegadoAcceso(string accion, TextBox txtDatos);

        
        public void probarConexion()
        {
            
            try
            {
                ConfigurarPuertoSerial();
                if (!mySerialPort.IsOpen)
                {
                    //mySerialPort = new SerialPort(variable("PORT"), 9600, Parity.None, 8, StopBits.One);

                    mySerialPort.Open();

                    MessageBox.Show(String.Format("Conexión al puerto {0} éxitosa", mySerialPort.PortName), VariablesGlobales.TitleMessageBox, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show(String.Format("El puerto {0} está abierto", mySerialPort.PortName), VariablesGlobales.TitleMessageBox, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            finally
            {
                mySerialPort.Close();
            }

        }
        public void Desconectar()
        {
            try
            {
                mySerialPort.Close();
            } 
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            
        }

        public bool LeerDatos(/*SerialPort mySerialPort,*/ Form form, Label lblConexion, TextBox txtPeso)
        {
            
            try
            {
                ConfigurarPuertoSerial();
                if (!mySerialPort.IsOpen)
                {
                    //mySerialPort = new SerialPort(variable("PORT"), 9600, Parity.None, 8, StopBits.One);
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
                
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            


            void sp_DataReceived(object sender, SerialDataReceivedEventArgs e)
            {
                
                try
                {
                    if(mySerialPort.IsOpen)
                    {
                        Thread.Sleep(500);
                        string data = mySerialPort.ReadExisting();
                        form.BeginInvoke(new DelegadoAcceso(si_DataReceived), new object[] { data, txtPeso });
                    }
                    
                    
                 }
                catch(InvalidOperationException inEx)
                {

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
            }
        }

        private static string variable(string var)
        {
            try
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
            catch(Exception ex)
            {
                
                MessageBox.Show(ex.Message.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return "";
            }
            
            

        }

        public string Variable(string var)
        {
            try
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
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return "";
            }
        }

        public DataTable indicadorTable()
        {
            try
            {

                conexion.sqlConnection.Open();

                SqlCommand sqlCommand = new SqlCommand("sp_Indicador", conexion.sqlConnection);
                sqlCommand.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);

                using (sqlDataAdapter)
                {

                    sqlCommand.Parameters.AddWithValue("@accion", "obtenerIndicador");

                    DataTable dataTable = new DataTable();

                    sqlDataAdapter.Fill(dataTable);

                    if (dataTable.Rows.Count == 1)
                    {
                        return dataTable;
                    }
                }

                return null;
            }
            catch (Exception ex)
            {
                return null;
                MessageBox.Show(ex.Message.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conexion.sqlConnection.Close();
            }
        }



        private void si_DataReceived(string accion, TextBox txtDatos)
        {
            try
            {

                conexion.sqlConnection.Open();

                SqlCommand sqlCommand = new SqlCommand("sp_Indicador", conexion.sqlConnection);
                sqlCommand.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);

                using (sqlDataAdapter)
                {

                    sqlCommand.Parameters.AddWithValue("@accion", "obtenerIndicador");

                    DataTable dataTable = new DataTable();

                    sqlDataAdapter.Fill(dataTable);

                    if (dataTable.Rows.Count == 1) 
                    {
                        txtDatos.Text = accion;
                        Match m = Regex.Match(accion, "(\\d+).(\\d+)|(\\d+)");

                        if (m.Success)
                        {
                            if (accion.Substring(int.Parse(dataTable.Rows[0]["Posicion_Signo_Mas"].ToString()) - 1, 1) == "+")
                            {
                                if (float.Parse(m.Value) <= float.Parse(dataTable.Rows[0]["Maximo"].ToString()))
                                {
                                    if (float.Parse(m.Value) >= float.Parse(dataTable.Rows[0]["Minimo"].ToString()))
                                    {
                                        txtDatos.Text = string.Format("{0:n} Kg", float.Parse(m.Value));
                                    }
                                    else
                                    {
                                        txtDatos.Text = String.Format("Mínimo - {0:n} Kg", dataTable.Rows[0]["Minimo"].ToString());
                                    }
                                }
                                else
                                {
                                    txtDatos.Text = String.Format("Máximo - {0:n} Kg", dataTable.Rows[0]["Maximo"].ToString());
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
            catch (Exception ex)
            {
                txtDatos.Text = "Error";
                MessageBox.Show(ex.Message.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);


            }
            finally
            {
                conexion.sqlConnection.Close();
            }

            /*try
            {
                txtDatos.Text = accion;
                Match m = Regex.Match(accion, "(\\d+).(\\d+)|(\\d+)");

                if (m.Success)
                {
                    if (accion.Substring(int.Parse(variable("POSICION_SIGNO_MAS")) - 1, 1) == "+")
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
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }*/

            

        }
    }
}
