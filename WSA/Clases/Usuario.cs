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
    public class Usuario
    {
        Conexion conexion = new Conexion();
        Bitacora bitacora = new Bitacora();

        //PROPIEDADES
        public int UsuarioId { get; set; }
        public string NombreUsuario { get; set; }
        public string UsuarioD { get; set; }
        public string Contrasena { get; set; }
        public int TipoUsuarioId { get; set; }
        public string TipoUsuario { get; set; }
        public bool Activo { get; set; }

        //METODOS
        public void MostrarUsuario(DataGridView dataGrid)
        {

            try
            {
                conexion.sqlConnection.Open();

                SqlCommand sqlCommand = new SqlCommand("sp_Usuario", conexion.sqlConnection);
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

        public void BuscarUsuario(DataGridView dataGrid, string valorBuscado)
        {

            try
            {
                conexion.sqlConnection.Open();
                //Query para mostrar un cliente
                SqlCommand sqlCommand = new SqlCommand("sp_Usuario", conexion.sqlConnection);
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

        public void AgregarUsuario(Usuario usuario)
        {
            try
            {
                conexion.sqlConnection.Open();

                SqlCommand sqlCommand = new SqlCommand("sp_Usuario", conexion.sqlConnection);
                sqlCommand.CommandType = CommandType.StoredProcedure;

                // Establecer los valores de los parámetros
                sqlCommand.Parameters.AddWithValue("@Nombre_Usuario", usuario.NombreUsuario);
                sqlCommand.Parameters.AddWithValue("@Usuario", usuario.UsuarioD.ToUpper());
                sqlCommand.Parameters.AddWithValue("@Contrasena", usuario.Contrasena);
                sqlCommand.Parameters.AddWithValue("@Tipo_Usuario_Id", usuario.TipoUsuarioId);
                sqlCommand.Parameters.AddWithValue("@Activo", usuario.Activo);
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

        public void ModificarUsuario(Usuario usuario)
        {
            try
            {
                conexion.sqlConnection.Open();

                SqlCommand sqlCommand = new SqlCommand("sp_Usuario", conexion.sqlConnection);
                sqlCommand.CommandType = CommandType.StoredProcedure;

                // Establecer los valores de los parámetros
                sqlCommand.Parameters.AddWithValue("@Usuario_Id", usuario.UsuarioId);
                sqlCommand.Parameters.AddWithValue("@Nombre_Usuario", usuario.NombreUsuario);
                sqlCommand.Parameters.AddWithValue("@Usuario", usuario.UsuarioD.ToUpper());
                sqlCommand.Parameters.AddWithValue("@Contrasena", usuario.Contrasena);
                sqlCommand.Parameters.AddWithValue("@Tipo_Usuario_Id", usuario.TipoUsuarioId);
                sqlCommand.Parameters.AddWithValue("@Activo", usuario.Activo);
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

        public void CargarComboBoxEstado(ComboBox comboBox)
        {
            try
            {
                conexion.sqlConnection.Open();

                SqlCommand sqlCommand = new SqlCommand("sp_Usuario", conexion.sqlConnection);

                sqlCommand.CommandType = CommandType.StoredProcedure;

                sqlCommand.Parameters.AddWithValue("@accion", "CargarTipoUsuario");

                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);

                using (sqlDataAdapter)
                {
                    DataTable dataTable = new DataTable();
                    sqlDataAdapter.Fill(dataTable);
                    comboBox.DisplayMember = "Tipo_Usuario";
                    comboBox.ValueMember = "Tipo_Usuario_Id";
                    comboBox.DataSource = dataTable.DefaultView;
                }

                conexion.sqlConnection.Close();
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

        public bool ExisteUsuario(string user)
        {
            try
            {

                conexion.sqlConnection.Open();

                SqlCommand sqlCommand = new SqlCommand("sp_Usuario", conexion.sqlConnection);
                sqlCommand.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);

                using (sqlDataAdapter)
                {
                    sqlCommand.Parameters.AddWithValue("@Usuario", user.ToLower());
                    sqlCommand.Parameters.AddWithValue("@accion", "existeUsuario");

                    DataTable dataTable = new DataTable();

                    sqlDataAdapter.Fill(dataTable);

                    if (dataTable.Rows.Count == 1) //Si el usuario existe retorna un true
                    {
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

        public void BuscarUsuario(string username, Usuario usuario)
        {

            try
            {
                conexion.sqlConnection.Open();

                SqlCommand sqlCommand = new SqlCommand("sp_Usuario", conexion.sqlConnection);

                sqlCommand.CommandType = CommandType.StoredProcedure;

                // Establecer los valores de los parámetros
                sqlCommand.Parameters.AddWithValue("@Usuario", username.ToLower());
                sqlCommand.Parameters.AddWithValue("@accion", "obtenerUsuario");

                using (SqlDataReader rdr = sqlCommand.ExecuteReader())
                {
                    while (rdr.Read())
                    {
                        // Obtener los valores del empleado si la consulta retorna valores
                        usuario.UsuarioId = Convert.ToInt32(rdr["Usuario_Id"]);
                        usuario.NombreUsuario = rdr["Nombre_Usuario"].ToString();
                        usuario.UsuarioD = rdr["Usuario"].ToString();
                        usuario.Contrasena = rdr["Contrasena"].ToString();
                        usuario.TipoUsuarioId = Convert.ToInt32(rdr["Tipo_Usuario_Id"].ToString());
                        usuario.TipoUsuario = rdr["Tipo_Usuario"].ToString();
                        usuario.Activo = Convert.ToBoolean(rdr["Activo"]);
                    }

                }
                // Retornar el usuario con los valores
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString(), "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);


            }
            finally
            {
                // Cerrar la conexión
                conexion.sqlConnection.Close();
            }
        }

        public void BuscarUsuarioPorId(int usuarioId, Usuario usuario)
        {

            try
            {
                conexion.sqlConnection.Open();

                SqlCommand sqlCommand = new SqlCommand("sp_Usuario", conexion.sqlConnection);

                sqlCommand.CommandType = CommandType.StoredProcedure;

                // Establecer los valores de los parámetros
                sqlCommand.Parameters.AddWithValue("@Usuario_Id", usuarioId);
                sqlCommand.Parameters.AddWithValue("@accion", "obtenerUsuarioPorId");

                using (SqlDataReader rdr = sqlCommand.ExecuteReader())
                {
                    while (rdr.Read())
                    {
                        // Obtener los valores del empleado si la consulta retorna valores
                        usuario.UsuarioId = Convert.ToInt32(rdr["Usuario_Id"]);
                        usuario.NombreUsuario = rdr["Nombre_Usuario"].ToString();
                        usuario.UsuarioD = rdr["Usuario"].ToString();
                        usuario.Contrasena = rdr["Contrasena"].ToString();
                        usuario.TipoUsuarioId = Convert.ToInt32(rdr["Tipo_Usuario_Id"].ToString());
                        usuario.TipoUsuario = rdr["Tipo_Usuario"].ToString();
                        usuario.Activo = Convert.ToBoolean(rdr["Activo"]);
                    }

                }
                // Retornar el usuario con los valores
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString(), "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);


            }
            finally
            {
                // Cerrar la conexión
                conexion.sqlConnection.Close();
            }
        }
    }
}
