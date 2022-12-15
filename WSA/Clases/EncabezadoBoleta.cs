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
    class EncabezadoBoleta
    {
        Conexion conexion = new Conexion();
        Bitacora bitacora = new Bitacora();

        //PROPIEDADES
        public int EncabezadoBoletaId { get; set; }
        public string Empresa { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }

        //METODOS
        public void CargarFormularioEncabezadoBoleta(TextBox txtEmpresa, TextBox txtDireccion, TextBox txtTelefono)
        {

            try
            {
                conexion.sqlConnection.Open();

                SqlCommand sqlCommand = new SqlCommand("sp_Encabezado_Boleta", conexion.sqlConnection);

                sqlCommand.CommandType = CommandType.StoredProcedure;

                // Establecer los valores de los parámetros
                
                sqlCommand.Parameters.AddWithValue("@accion", "obtenerEncabezado");

                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
                using (SqlDataReader rdr = sqlCommand.ExecuteReader())
                {
                    while (rdr.Read())
                    {
                        txtEmpresa.Text = rdr["Empresa"].ToString();
                        txtDireccion.Text = rdr["Direccion"].ToString();
                        txtTelefono.Text = rdr["Telefono"].ToString();
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

        public bool ExisteEncabezado(EncabezadoBoleta encabezadoBoleta)
        {
            try
            {

                conexion.sqlConnection.Open();

                SqlCommand sqlCommand = new SqlCommand("sp_Encabezado_Boleta", conexion.sqlConnection);
                sqlCommand.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);

                using (sqlDataAdapter)
                {
                    sqlCommand.Parameters.AddWithValue("@accion", "obtenerEncabezado");

                    DataTable dataTable = new DataTable();

                    sqlDataAdapter.Fill(dataTable);

                    if (dataTable.Rows.Count == 1)
                    {
                        encabezadoBoleta.EncabezadoBoletaId = int.Parse(dataTable.Rows[0]["Encabezado_Boleta_Id"].ToString());
                        return true;
                    }

                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            finally
            {
                conexion.sqlConnection.Close();
            }


        }

        public void AgregarEncabezadoBoleta(EncabezadoBoleta encabezadoBoleta)
        {
            try
            {
                conexion.sqlConnection.Open();

                SqlCommand sqlCommand = new SqlCommand("sp_Encabezado_Boleta", conexion.sqlConnection);
                sqlCommand.CommandType = CommandType.StoredProcedure;

                // Establecer los valores de los parámetros
                sqlCommand.Parameters.AddWithValue("@Empresa", encabezadoBoleta.Empresa.ToUpper());
                sqlCommand.Parameters.AddWithValue("@Direccion", encabezadoBoleta.Direccion.ToUpper());
                sqlCommand.Parameters.AddWithValue("@Telefono", encabezadoBoleta.Telefono.ToUpper());

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

        public void ModificarEncabezadoBoleta(EncabezadoBoleta encabezadoBoleta)
        {
            try
            {
                conexion.sqlConnection.Open();

                SqlCommand sqlCommand = new SqlCommand("sp_Encabezado_Boleta", conexion.sqlConnection);
                sqlCommand.CommandType = CommandType.StoredProcedure;

                // Establecer los valores de los parámetros
                sqlCommand.Parameters.AddWithValue("@Encabezado_Boleta_Id", encabezadoBoleta.EncabezadoBoletaId);
                sqlCommand.Parameters.AddWithValue("@Empresa", encabezadoBoleta.Empresa.ToUpper());
                sqlCommand.Parameters.AddWithValue("@Direccion", encabezadoBoleta.Direccion.ToUpper());
                sqlCommand.Parameters.AddWithValue("@Telefono", encabezadoBoleta.Telefono.ToUpper());

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
    }
}
