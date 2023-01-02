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
    class Historico
    {
        ConexionHistorico conexionHistorico = new ConexionHistorico();

        public void MostrarHistorico(DataGridView dataGrid)
        {

            try
            {
                conexionHistorico.sqlConnection.Open();

                SqlCommand sqlCommand = new SqlCommand("sp_Historico", conexionHistorico.sqlConnection);
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
                conexionHistorico.sqlConnection.Close();
            }
        }

        public void Buscar(DataGridView dataGrid, DateTimePicker dtpFechaInicio, DateTimePicker dtpFechaFinal, string valorBuscado)
        {

            try
            {
                conexionHistorico.sqlConnection.Open();

                SqlCommand sqlCommand = new SqlCommand("sp_Historico", conexionHistorico.sqlConnection);
                sqlCommand.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);

                // Establecer los valores de los parámetros
                sqlCommand.Parameters.AddWithValue("@fechaInicio", dtpFechaInicio.Value.Date);
                sqlCommand.Parameters.AddWithValue("@fechaFinal", dtpFechaFinal.Value.Date);
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
                conexionHistorico.sqlConnection.Close();
            }
        }

        public void ExportarExcel(DataGridView tabla)
        {
            try
            {
                Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application();

                excel.Application.Workbooks.Add(true);

                int IndiceColumna = 0;

                foreach (DataGridViewColumn col in tabla.Columns)
                {

                    IndiceColumna++;

                    excel.Cells[1, IndiceColumna] = col.Name;

                }

                int IndeceFila = 0;

                foreach (DataGridViewRow row in tabla.Rows)
                {

                    IndeceFila++;

                    IndiceColumna = 0;

                    foreach (DataGridViewColumn col in tabla.Columns)
                    {

                        IndiceColumna++;

                        excel.Cells[IndeceFila + 1, IndiceColumna] = row.Cells[col.Name].Value;

                    }

                }

                excel.Visible = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
