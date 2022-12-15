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
    public class Conductor
    {
        Conexion conexion = new Conexion();
        Bitacora bitacora = new Bitacora();
        //PROPIEDADES
        public int ConductorId { get; set; }
        public string ConductorD { get; set; }

        //METODOS
        public void MostrarConductor(DataGridView dataGrid)
        {

            try
            {
                conexion.sqlConnection.Open();

                SqlCommand sqlCommand = new SqlCommand("sp_Conductor", conexion.sqlConnection);
                sqlCommand.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);

                // Establecer los valores de los parámetros

                sqlCommand.Parameters.AddWithValue("@accion", "mostrar");

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

        public void BuscarConductor(DataGridView dataGrid, string valorBuscado)
        {

            try
            {
                conexion.sqlConnection.Open();
                //Query para mostrar un cliente
                SqlCommand sqlCommand = new SqlCommand("sp_Conductor", conexion.sqlConnection);
                sqlCommand.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);

                // Establecer los valores de los parámetros
                sqlCommand.Parameters.AddWithValue("@valorBuscado", valorBuscado);
                sqlCommand.Parameters.AddWithValue("@accion", "buscar");

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

        public void AgregarConductor(Conductor conductor)
        {
            try
            {
                conexion.sqlConnection.Open();

                SqlCommand sqlCommand = new SqlCommand("sp_Conductor", conexion.sqlConnection);
                sqlCommand.CommandType = CommandType.StoredProcedure;

                // Establecer los valores de los parámetros
                sqlCommand.Parameters.AddWithValue("@Conductor", conductor.ConductorD.ToUpper());
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

        public void ModificarConductor(Conductor conductor)
        {
            try
            {
                conexion.sqlConnection.Open();

                SqlCommand sqlCommand = new SqlCommand("sp_Conductor", conexion.sqlConnection);
                sqlCommand.CommandType = CommandType.StoredProcedure;

                // Establecer los valores de los parámetros
                sqlCommand.Parameters.AddWithValue("@Conductor_Id", conductor.ConductorId);
                sqlCommand.Parameters.AddWithValue("@Conductor", conductor.ConductorD.ToUpper());
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
