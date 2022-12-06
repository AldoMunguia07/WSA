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

        //PROPIEDADES
        public int BoletaId { get; set; }
        public DateTime FechaEntrada { get; set; }
        public DateTime FechaSalida{ get; set; }
        public string PlacaCabezal { get; set; }
        public string PlacaRastra { get; set; }
        public int ConductorId { get; set; }
        public int ClienteId { get; set; }
        public int ProductoId { get; set; }
        public float PesoIngreso { get; set; }
        public string UnidadesPesoIngreso { get; set; }
        public string CiaTransportista { get; set; }
        public string EnvioN { get; set; }
        public float PesoSalida{ get; set; }
        public string UnidadesPesoSalida { get; set; }
        public int BarcoId { get; set; }
        public int UsuarioId { get; set; }
        public char Estado { get; set; }
        public string Observaciones { get; set; }

        ///METODOS
        public void AgregarEntrada(Boleta boleta)
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
                sqlCommand.Parameters.AddWithValue("@Unidades_Peso_Ingreso", boleta.UnidadesPesoIngreso);
                sqlCommand.Parameters.AddWithValue("@Cia_Transportista", boleta.CiaTransportista);
                sqlCommand.Parameters.AddWithValue("@Envio_N", boleta.EnvioN);
                sqlCommand.Parameters.AddWithValue("@Barco_Id", boleta.BarcoId);
                sqlCommand.Parameters.AddWithValue("@Usuario_Id", boleta.UsuarioId);
                sqlCommand.Parameters.AddWithValue("@Estado", boleta.Estado);
                sqlCommand.Parameters.AddWithValue("@Observaciones", boleta.Observaciones);
                sqlCommand.Parameters.AddWithValue("@accion", "insertarEntrada");
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
                MessageBox.Show(ex.Message.ToString(), "WAS", MessageBoxButtons.OK, MessageBoxIcon.Error);
          


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
                MessageBox.Show(ex.Message.ToString(), "WAS", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                    MessageBox.Show("Producto no encontrado", "WAS", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtCodigoProducto.Clear();
                    txtProducto.Clear();
                }
            }
            catch (Exception ex)
            {
                txtCodigoProducto.Clear();
                txtProducto.Clear();
                MessageBox.Show(ex.Message.ToString(), "WAS", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                    MessageBox.Show("Barco no encontrado", "WAS", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtCodigoBarco.Clear();
                    txtBarco.Clear();
                }
            }
            catch (Exception ex)
            {
                txtCodigoBarco.Clear();
                txtBarco.Clear();
                MessageBox.Show(ex.Message.ToString(), "WAS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                // Cerrar la conexión
                conexion.sqlConnection.Close();
            }
        }



    }
}
