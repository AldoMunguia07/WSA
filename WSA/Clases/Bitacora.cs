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
    class Bitacora
    {
        Conexion conexion = new Conexion();
      

        public void DefinirUsuarioId(int usuarioId, SqlConnection sqlConnection)
        {

            try
            {
                conexion.sqlConnection.Open();

                SqlCommand sqlCommand = new SqlCommand("sp_bitacora", sqlConnection);
                sqlCommand.CommandType = CommandType.StoredProcedure;

                // Establecer los valores de los parámetros
                sqlCommand.Parameters.AddWithValue("@value", usuarioId);
                sqlCommand.Parameters.AddWithValue("@key", "user_id");


                sqlCommand.Parameters.AddWithValue("@accion", "Usuario_Id");

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

        //METODOS
        public void MostrarBitacora(DataGridView dataGrid, DateTimePicker dtpFechaInicio, DateTimePicker dtpFechaFinal, string valorBuscado)
        {

            try
            {
                conexion.sqlConnection.Open();

                SqlCommand sqlCommand = new SqlCommand("sp_Bitacora", conexion.sqlConnection);
                sqlCommand.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
               
                // Establecer los valores de los parámetros
                sqlCommand.Parameters.AddWithValue("@fechaInicio", dtpFechaInicio.Value.Date);
                sqlCommand.Parameters.AddWithValue("@fechaFinal", dtpFechaFinal.Value.Date);
                sqlCommand.Parameters.AddWithValue("@buscado", "");
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
    }
}
