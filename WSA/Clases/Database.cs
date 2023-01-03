using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;
using System.Windows.Forms;

namespace WSA.Clases
{
    class Database
    {
        Conexion conexion = new Conexion();
        public void RealizarBackup()
        {

            try
            {
                string nombreBackup = String.Format("{0}_{1}.bak","AWS_DB", DateTime.Now.ToString().Replace("/", "").Replace(":", "").Replace(" ", ""));
                string path = @"c:\Backups_AWS_Database";

                if (!Directory.Exists(path))
                {
                    DirectoryInfo di = Directory.CreateDirectory(path);
                }

                conexion.sqlConnection.Open();

                SqlCommand sqlCommand = new SqlCommand("sp_Database", conexion.sqlConnection);
                sqlCommand.CommandType = CommandType.StoredProcedure;

                // Establecer los valores de los parámetros
                sqlCommand.Parameters.AddWithValue("@Ruta", String.Format(@"{0}\{1}", path, nombreBackup));
                sqlCommand.Parameters.AddWithValue("@accion", "realizarBackup");

                sqlCommand.ExecuteNonQuery();

                MessageBox.Show(String.Format(@"Copia de seguridad creada: {0}\{1}", path,nombreBackup), VariablesGlobales.TitleMessageBox, MessageBoxButtons.OK, MessageBoxIcon.Information);
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
