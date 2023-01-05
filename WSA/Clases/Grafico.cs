using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient;
using System.Configuration;
using System.Data;
using System.Windows.Forms;
using System.Collections;
using System.Windows.Forms.DataVisualization.Charting;

namespace WSA.Clases
{
    class Grafico
    {
        Conexion conexion = new Conexion();
        //METODOS
        public void UltimosMeses(Chart chart)
        {

            try
            {
                conexion.sqlConnection.Open();

                SqlCommand sqlCommand = new SqlCommand("sp_Graficos", conexion.sqlConnection);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.AddWithValue("@accion", "UltimosMeses");

                ArrayList totales = new ArrayList();
                ArrayList meses = new ArrayList();

                using (SqlDataReader rdr = sqlCommand.ExecuteReader())
                {
                    while (rdr.Read())
                    {
                        totales.Add(rdr.GetValue(2));
                        meses.Add(rdr.GetString(1));
                    }

                    

                }
                chart.Series[0].Points.DataBindXY(meses, totales);

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conexion.sqlConnection.Close();
            }
        }

        public void TopOperadores(Chart chart)
        {

            try
            {
                conexion.sqlConnection.Open();

                SqlCommand sqlCommand = new SqlCommand("sp_Graficos", conexion.sqlConnection);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.AddWithValue("@accion", "TopOperadores");

                ArrayList totales = new ArrayList();
                ArrayList operadores = new ArrayList();

                using (SqlDataReader rdr = sqlCommand.ExecuteReader())
                {
                    while (rdr.Read())
                    {
                        totales.Add(rdr.GetValue(1));
                        operadores.Add(rdr.GetString(0));
                    }



                }
                chart.Series[0].Points.DataBindXY(operadores, totales);

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conexion.sqlConnection.Close();
            }
        }

        public void TopConductores(Chart chart)
        {

            try
            {
                conexion.sqlConnection.Open();

                SqlCommand sqlCommand = new SqlCommand("sp_Graficos", conexion.sqlConnection);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.AddWithValue("@accion", "TopConductores");

                ArrayList totales = new ArrayList();
                ArrayList conductores = new ArrayList();

                using (SqlDataReader rdr = sqlCommand.ExecuteReader())
                {
                    while (rdr.Read())
                    {
                        totales.Add(rdr.GetValue(1));
                        conductores.Add(rdr.GetString(0));
                    }



                }
                chart.Series[0].Points.DataBindXY(conductores, totales);

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conexion.sqlConnection.Close();
            }
        }

        public void TopProductos(Chart chart)
        {

            try
            {
                conexion.sqlConnection.Open();

                SqlCommand sqlCommand = new SqlCommand("sp_Graficos", conexion.sqlConnection);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.AddWithValue("@accion", "TopProductos");

                ArrayList totales = new ArrayList();
                ArrayList productos = new ArrayList();

                using (SqlDataReader rdr = sqlCommand.ExecuteReader())
                {
                    while (rdr.Read())
                    {
                        totales.Add(rdr.GetValue(1));
                        productos.Add(rdr.GetString(0));
                    }



                }
                chart.Series[0].Points.DataBindXY(productos, totales);

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conexion.sqlConnection.Close();
            }
        }

        public DataTable Datos()
        {
            DataTable data = new DataTable();
            try
            {

                conexion.sqlConnection.Open();


                SqlCommand sqlCommand = new SqlCommand("sp_Graficos", conexion.sqlConnection);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                

                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);

                using (sqlDataAdapter)
                {

                    sqlCommand.Parameters.AddWithValue("@accion", "Datos");
                    DataTable dataTable = new DataTable();

                    sqlDataAdapter.Fill(dataTable);

                    if (dataTable.Rows.Count == 1) //Si el usuario existe retorna un true
                    {
                        return dataTable;
                    }

                    return data;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return data;

            }
            finally
            {
                conexion.sqlConnection.Close();
            }


        }
    }
}
