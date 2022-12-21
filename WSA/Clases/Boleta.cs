using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;
using System.Windows.Forms;

namespace WSA.Clases
{
    class Boleta
    {
        Conexion conexion = new Conexion();
        Bitacora bitacora = new Bitacora();

        //PROPIEDADES
        public int BoletaId { get; set; }
        public DateTime FechaEntrada { get; set; }
        public DateTime FechaSalida { get; set; }
        public string PlacaCabezal { get; set; }
        public string PlacaRastra { get; set; }
        public int ConductorId { get; set; }
        public int ClienteId { get; set; }
        public int ProductoId { get; set; }
        public float PesoIngreso { get; set; }
        public string UnidadesPesoIngreso { get; set; }
        public string CiaTransportista { get; set; }
        public string EnvioN { get; set; }
        public float PesoSalida { get; set; }
        public string UnidadesPesoSalida { get; set; }
        public int BarcoId { get; set; }
        public int UsuarioId { get; set; }
        public char Estado { get; set; }
        public string Observaciones { get; set; }

        ///METODOS
        public bool AgregarEntrada(Boleta boleta)
        {
            try
            {
                conexion.sqlConnection.Open();

                SqlCommand sqlCommand = new SqlCommand("sp_Boleta", conexion.sqlConnection);
                sqlCommand.CommandType = CommandType.StoredProcedure;

                // Establecer los valores de los parámetros
                sqlCommand.Parameters.AddWithValue("@Fecha_Entrada", boleta.FechaEntrada);
                sqlCommand.Parameters.AddWithValue("@Placa_Cabezal", boleta.PlacaCabezal);
                sqlCommand.Parameters.AddWithValue("@Placa_Rastra", boleta.PlacaRastra);
                sqlCommand.Parameters.AddWithValue("@Conductor_Id", boleta.ConductorId);
                sqlCommand.Parameters.AddWithValue("@Cliente_Id", boleta.ClienteId);
                sqlCommand.Parameters.AddWithValue("@Producto_Id", boleta.ProductoId);
                sqlCommand.Parameters.AddWithValue("@Peso_Ingreso", boleta.PesoIngreso);
                sqlCommand.Parameters.AddWithValue("@Unidades_Peso_Ingreso", boleta.UnidadesPesoIngreso.ToUpper());
                sqlCommand.Parameters.AddWithValue("@Cia_Transportista", boleta.CiaTransportista.ToUpper());
                sqlCommand.Parameters.AddWithValue("@Envio_N", boleta.EnvioN.ToUpper());
                sqlCommand.Parameters.AddWithValue("@Barco_Id", boleta.BarcoId);
                sqlCommand.Parameters.AddWithValue("@Usuario_Id", boleta.UsuarioId);
                sqlCommand.Parameters.AddWithValue("@Estado", boleta.Estado);
                sqlCommand.Parameters.AddWithValue("@Observaciones", boleta.Observaciones.ToUpper());
                sqlCommand.Parameters.AddWithValue("@accion", "insertarEntrada");
                bitacora.DefinirUsuarioId(VariablesGlobales.Usuario.UsuarioId, conexion.sqlConnection);
                sqlCommand.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            finally
            {
                // Cerrar la conexión
                conexion.sqlConnection.Close();
            }
        }

        public void MostrarEntradas(DataGridView dataGrid)
        {

            try
            {
                conexion.sqlConnection.Open();

                SqlCommand sqlCommand = new SqlCommand("sp_Boleta", conexion.sqlConnection);
                sqlCommand.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);

                // Establecer los valores de los parámetros

                sqlCommand.Parameters.AddWithValue("@accion", "mostrarEntradas");

                using (sqlDataAdapter)
                {
                    DataTable dataTable = new DataTable();

                    sqlDataAdapter.Fill(dataTable);

                    dataGrid.DataSource = dataTable;

                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conexion.sqlConnection.Close();
            }
        }

        public void AnularEntrada(Boleta boleta)
        {
            try
            {
                conexion.sqlConnection.Open();

                SqlCommand sqlCommand = new SqlCommand("sp_Boleta", conexion.sqlConnection);
                sqlCommand.CommandType = CommandType.StoredProcedure;

                // Establecer los valores de los parámetros
                sqlCommand.Parameters.AddWithValue("@Boleta_Id", boleta.BoletaId);
                sqlCommand.Parameters.AddWithValue("@Estado", boleta.Estado);
                sqlCommand.Parameters.AddWithValue("@Observaciones", boleta.Observaciones.ToUpper());
                
                sqlCommand.Parameters.AddWithValue("@accion", "anularEntrada");
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

        public void MostrarEntradasAnuladas(DataGridView dataGrid)
        {

            try
            {
                conexion.sqlConnection.Open();

                SqlCommand sqlCommand = new SqlCommand("sp_Boleta", conexion.sqlConnection);
                sqlCommand.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);

                // Establecer los valores de los parámetros

                sqlCommand.Parameters.AddWithValue("@accion", "mostrarAnuladas");

                using (sqlDataAdapter)
                {
                    DataTable dataTable = new DataTable();

                    sqlDataAdapter.Fill(dataTable);

                    dataGrid.DataSource = dataTable;

                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conexion.sqlConnection.Close();
            }
        }

        public void BuscarAnuladas(DataGridView dataGrid, DateTimePicker dtpFechaInicio, DateTimePicker dtpFechaFinal, string valorBuscado)
        {

            try
            {
                conexion.sqlConnection.Open();

                SqlCommand sqlCommand = new SqlCommand("sp_Boleta", conexion.sqlConnection);
                sqlCommand.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);

                // Establecer los valores de los parámetros
                sqlCommand.Parameters.AddWithValue("@fechaInicio", dtpFechaInicio.Value.Date);
                sqlCommand.Parameters.AddWithValue("@fechaFinal", dtpFechaFinal.Value.Date);
                sqlCommand.Parameters.AddWithValue("@valorBuscado", valorBuscado);
                sqlCommand.Parameters.AddWithValue("@accion", "buscarAnuladas");

                using (sqlDataAdapter)
                {
                    DataTable dataTable = new DataTable();
                    sqlDataAdapter.Fill(dataTable);
                    dataGrid.DataSource = dataTable;

                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conexion.sqlConnection.Close();
            }
        }

        public bool AgregarSalida(Boleta boleta)
        {
            try
            {
                conexion.sqlConnection.Open();

                SqlCommand sqlCommand = new SqlCommand("sp_Boleta", conexion.sqlConnection);
                sqlCommand.CommandType = CommandType.StoredProcedure;

                // Establecer los valores de los parámetros
                sqlCommand.Parameters.AddWithValue("@Boleta_Id", boleta.BoletaId);
                sqlCommand.Parameters.AddWithValue("@Fecha_Salida", boleta.FechaSalida);
                sqlCommand.Parameters.AddWithValue("@Peso_Salida", boleta.PesoSalida);
                sqlCommand.Parameters.AddWithValue("@Unidades_Peso_Salida", boleta.UnidadesPesoSalida.ToUpper());
                sqlCommand.Parameters.AddWithValue("@Estado", boleta.Estado);
                sqlCommand.Parameters.AddWithValue("@Observaciones", boleta.Observaciones.ToUpper());

                sqlCommand.Parameters.AddWithValue("@accion", "insertarSalida");
                bitacora.DefinirUsuarioId(VariablesGlobales.Usuario.UsuarioId, conexion.sqlConnection);
                sqlCommand.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            finally
            {
                // Cerrar la conexión
                conexion.sqlConnection.Close();
            }
        }

        public void MostrarBoletas(DataGridView dataGrid)
        {

            try
            {
                conexion.sqlConnection.Open();

                SqlCommand sqlCommand = new SqlCommand("sp_Boleta", conexion.sqlConnection);
                sqlCommand.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);

                // Establecer los valores de los parámetros

                sqlCommand.Parameters.AddWithValue("@accion", "mostrarSalidas");

                using (sqlDataAdapter)
                {
                    DataTable dataTable = new DataTable();

                    sqlDataAdapter.Fill(dataTable);

                    dataGrid.DataSource = dataTable;

                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conexion.sqlConnection.Close();
            }
        }

        public void BuscarBoletas(DataGridView dataGrid, DateTimePicker dtpFechaInicio, DateTimePicker dtpFechaFinal, string valorBuscado)
        {

            try
            {
                conexion.sqlConnection.Open();

                SqlCommand sqlCommand = new SqlCommand("sp_Boleta", conexion.sqlConnection);
                sqlCommand.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);

                // Establecer los valores de los parámetros
                sqlCommand.Parameters.AddWithValue("@fechaInicio", dtpFechaInicio.Value.Date);
                sqlCommand.Parameters.AddWithValue("@fechaFinal", dtpFechaFinal.Value.Date);
                sqlCommand.Parameters.AddWithValue("@valorBuscado", valorBuscado);
                sqlCommand.Parameters.AddWithValue("@accion", "buscarSalidas");

                using (sqlDataAdapter)
                {
                    DataTable dataTable = new DataTable();
                    sqlDataAdapter.Fill(dataTable);
                    dataGrid.DataSource = dataTable;

                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conexion.sqlConnection.Close();
            }
        }

        public void BuscarConductor(TextBox txtCodigoConductor, TextBox txtConductor)
        {

            try
            {
                conexion.sqlConnection.Open();

                SqlCommand sqlCommand = new SqlCommand("sp_Boleta", conexion.sqlConnection);

                sqlCommand.CommandType = CommandType.StoredProcedure;

                // Establecer los valores de los parámetros
                sqlCommand.Parameters.AddWithValue("@Conductor_Id", int.Parse(txtCodigoConductor.Text));
                sqlCommand.Parameters.AddWithValue("@accion", "buscarConductor");

                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
                using (SqlDataReader rdr = sqlCommand.ExecuteReader())
                {
                    while (rdr.Read())
                    {
                        txtConductor.Text = rdr["Conductor"].ToString();

                    }

                }


                DataTable dataTable = new DataTable();

                sqlDataAdapter.Fill(dataTable);

                if (dataTable.Rows.Count == 0)
                {
                    MessageBox.Show("Conductor no encontrado", "WAS", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtCodigoConductor.Clear();
                    txtConductor.Clear();
                }


            }
            catch (Exception ex)
            {
                txtCodigoConductor.Clear();
                txtConductor.Clear();
                MessageBox.Show(ex.Message.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);



            }
            finally
            {
                // Cerrar la conexión
                conexion.sqlConnection.Close();
            }
        }

        public void BuscarCliente(TextBox txtCodigoCliente, TextBox txtCliente)
        {

            try
            {
                conexion.sqlConnection.Open();

                SqlCommand sqlCommand = new SqlCommand("sp_Boleta", conexion.sqlConnection);

                sqlCommand.CommandType = CommandType.StoredProcedure;

                // Establecer los valores de los parámetros
                sqlCommand.Parameters.AddWithValue("@Cliente_Id", int.Parse(txtCodigoCliente.Text));
                sqlCommand.Parameters.AddWithValue("@accion", "buscarCliente");

                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
                using (SqlDataReader rdr = sqlCommand.ExecuteReader())
                {
                    while (rdr.Read())
                    {
                        txtCliente.Text = rdr["Cliente"].ToString();

                    }

                }

                DataTable dataTable = new DataTable();
                sqlDataAdapter.Fill(dataTable);

                if (dataTable.Rows.Count == 0)
                {
                    MessageBox.Show("Cliente no encontrado", "WAS", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtCodigoCliente.Clear();
                    txtCliente.Clear();
                }
            }
            catch (Exception ex)
            {
                txtCodigoCliente.Clear();
                txtCliente.Clear();
                MessageBox.Show(ex.Message.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                // Cerrar la conexión
                conexion.sqlConnection.Close();
            }
        }

        public void BuscarProducto(TextBox txtCodigoProducto, TextBox txtProducto)
        {

            try
            {
                conexion.sqlConnection.Open();

                SqlCommand sqlCommand = new SqlCommand("sp_Boleta", conexion.sqlConnection);

                sqlCommand.CommandType = CommandType.StoredProcedure;

                // Establecer los valores de los parámetros
                sqlCommand.Parameters.AddWithValue("@Producto_Id", int.Parse(txtCodigoProducto.Text));
                sqlCommand.Parameters.AddWithValue("@accion", "buscarProducto");

                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
                using (SqlDataReader rdr = sqlCommand.ExecuteReader())
                {
                    while (rdr.Read())
                    {
                        txtProducto.Text = rdr["Descripcion"].ToString();

                    }

                }

                DataTable dataTable = new DataTable();
                sqlDataAdapter.Fill(dataTable);

                if (dataTable.Rows.Count == 0)
                {
                    MessageBox.Show("Producto no encontrado", "AWS", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtCodigoProducto.Clear();
                    txtProducto.Clear();
                }
            }
            catch (Exception ex)
            {
                txtCodigoProducto.Clear();
                txtProducto.Clear();
                MessageBox.Show(ex.Message.ToString(), "AWS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                // Cerrar la conexión
                conexion.sqlConnection.Close();
            }
        }

        public void BuscarBarco(TextBox txtCodigoBarco, TextBox txtBarco)
        {

            try
            {
                conexion.sqlConnection.Open();

                SqlCommand sqlCommand = new SqlCommand("sp_Boleta", conexion.sqlConnection);

                sqlCommand.CommandType = CommandType.StoredProcedure;

                // Establecer los valores de los parámetros
                sqlCommand.Parameters.AddWithValue("@Barco_Id", int.Parse(txtCodigoBarco.Text));
                sqlCommand.Parameters.AddWithValue("@accion", "buscarBarco");

                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
                using (SqlDataReader rdr = sqlCommand.ExecuteReader())
                {
                    while (rdr.Read())
                    {
                        txtBarco.Text = rdr["Descripcion"].ToString();

                    }

                }

                DataTable dataTable = new DataTable();
                sqlDataAdapter.Fill(dataTable);

                if (dataTable.Rows.Count == 0)
                {
                    MessageBox.Show("Barco no encontrado", "AWS", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtCodigoBarco.Clear();
                    txtBarco.Clear();
                }
            }
            catch (Exception ex)
            {
                txtCodigoBarco.Clear();
                txtBarco.Clear();
                MessageBox.Show(ex.Message.ToString(), "AWS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                // Cerrar la conexión
                conexion.sqlConnection.Close();
            }
        }

        public void CargarFormularioSalida(int boletaId, DateTimePicker dtpFechaEntrada, DateTimePicker dtpHoraEntrada, TextBox txtCodigoConductor, TextBox txtConductor, TextBox txtPlacaCabezal, TextBox txtPlacaRastra,
            TextBox txtCia, TextBox txtEnvioN, TextBox txtCodigoCliente, TextBox txtCliente, TextBox txtCodigoProducto, TextBox txtProducto, TextBox txtCodigoBarco, TextBox txtBarco,
           TextBox txtPesoEntrada, TextBox txtObservaciones)
        {

            try
            {
                conexion.sqlConnection.Open();

                SqlCommand sqlCommand = new SqlCommand("sp_Boleta", conexion.sqlConnection);

                sqlCommand.CommandType = CommandType.StoredProcedure;

                // Establecer los valores de los parámetros
                sqlCommand.Parameters.AddWithValue("@Boleta_Id", boletaId);
                sqlCommand.Parameters.AddWithValue("@accion", "cagarFormSalida");

                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
                using (SqlDataReader rdr = sqlCommand.ExecuteReader())
                {
                    while (rdr.Read())
                    {
                        dtpFechaEntrada.Value = Convert.ToDateTime(rdr["Fecha_Entrada"]);
                        dtpHoraEntrada.Value = Convert.ToDateTime(rdr["Fecha_Entrada"]);
                        txtCodigoConductor.Text = rdr["Conductor_Id"].ToString();
                        txtConductor.Text = rdr["Conductor"].ToString();
                        txtPlacaCabezal.Text = rdr["Placa_Cabezal"].ToString();
                        txtPlacaRastra.Text = rdr["Placa_Rastra"].ToString();
                        txtCia.Text = rdr["Cia_Transportista"].ToString();
                        txtEnvioN.Text = rdr["Envio_N"].ToString();
                        txtCodigoCliente.Text = rdr["Cliente_Id"].ToString();
                        txtCliente.Text = rdr["Cliente"].ToString();
                        txtCodigoProducto.Text = rdr["Producto_Id"].ToString();
                        txtProducto.Text = rdr["Descripcion_Producto"].ToString();
                        txtCodigoBarco.Text = rdr["Barco_Id"].ToString();
                        txtBarco.Text = rdr["Descripcion_Barco"].ToString();
                        txtPesoEntrada.Text = String.Format("{0:n}", float.Parse(rdr["Peso_Ingreso"].ToString()));
                        txtObservaciones.Text = rdr["Observaciones"].ToString();

                    }

                }


            }
            catch (Exception ex)
            {
                
                MessageBox.Show(ex.Message.ToString(), "AWS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                // Cerrar la conexión
                conexion.sqlConnection.Close();
            }
        }

        public void CargarFormularioVerBoleta(int boletaId, DateTimePicker dtpFechaEntrada, DateTimePicker dtpHoraEntrada, DateTimePicker dtpFechaSalida, DateTimePicker dtpHoraSalida, 
            TextBox txtCodigoConductor, TextBox txtConductor, TextBox txtPlacaCabezal, TextBox txtPlacaRastra, TextBox txtCia, TextBox txtEnvioN, TextBox txtCodigoCliente, TextBox txtCliente,
            TextBox txtCodigoProducto, TextBox txtProducto, TextBox txtCodigoBarco, TextBox txtBarco, TextBox txtPesoEntrada, TextBox txtPesoSalida, TextBox txtPesoNeto, TextBox txtObservaciones)
        {

            try
            {
                conexion.sqlConnection.Open();

                SqlCommand sqlCommand = new SqlCommand("sp_Boleta", conexion.sqlConnection);

                sqlCommand.CommandType = CommandType.StoredProcedure;

                // Establecer los valores de los parámetros
                sqlCommand.Parameters.AddWithValue("@Boleta_Id", boletaId);
                sqlCommand.Parameters.AddWithValue("@accion", "cagarFormSalida");

                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
                using (SqlDataReader rdr = sqlCommand.ExecuteReader())
                {
                    while (rdr.Read())
                    {
                        dtpFechaEntrada.Value = Convert.ToDateTime(rdr["Fecha_Entrada"]);
                        dtpHoraEntrada.Value = Convert.ToDateTime(rdr["Fecha_Entrada"]);
                        dtpFechaSalida.Value = Convert.ToDateTime(rdr["Fecha_Salida"]);
                        dtpHoraSalida.Value = Convert.ToDateTime(rdr["Fecha_Salida"]);
                        txtCodigoConductor.Text = rdr["Conductor_Id"].ToString();
                        txtConductor.Text = rdr["Conductor"].ToString();
                        txtPlacaCabezal.Text = rdr["Placa_Cabezal"].ToString();
                        txtPlacaRastra.Text = rdr["Placa_Rastra"].ToString();
                        txtCia.Text = rdr["Cia_Transportista"].ToString();
                        txtEnvioN.Text = rdr["Envio_N"].ToString();
                        txtCodigoCliente.Text = rdr["Cliente_Id"].ToString();
                        txtCliente.Text = rdr["Cliente"].ToString();
                        txtCodigoProducto.Text = rdr["Producto_Id"].ToString();
                        txtProducto.Text = rdr["Descripcion_Producto"].ToString();
                        txtCodigoBarco.Text = rdr["Barco_Id"].ToString();
                        txtBarco.Text = rdr["Descripcion_Barco"].ToString();
                        txtPesoEntrada.Text = String.Format("{0:n}", float.Parse(rdr["Peso_Ingreso"].ToString()));
                        txtPesoSalida.Text = String.Format("{0:n}", float.Parse(rdr["Peso_Salida"].ToString()));
                        txtPesoNeto.Text = String.Format("{0:n}", float.Parse(rdr["Peso_Neto"].ToString()));

                        txtObservaciones.Text = rdr["Observaciones"].ToString();

                    }

                }


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message.ToString(), "AWS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                // Cerrar la conexión
                conexion.sqlConnection.Close();
            }
        }

        public int UltimaBoleta()
        {
            try
            {

                conexion.sqlConnection.Open();

                SqlCommand sqlCommand = new SqlCommand("sp_Boleta", conexion.sqlConnection);
                sqlCommand.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);

                using (sqlDataAdapter)
                {
           
                    sqlCommand.Parameters.AddWithValue("@accion", "ultimaBoleta");

                    DataTable dataTable = new DataTable();

                    sqlDataAdapter.Fill(dataTable);

                    if (dataTable.Rows.Count == 1) //Si el usuario existe retorna un true
                    {
                        return Convert.ToInt32(dataTable.Rows[0]["Boleta_Id"]);
                    }

                    return 0;
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


    }
}
