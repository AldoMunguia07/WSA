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

        public void Operadores(Chart chart)
        {

            try
            {
                conexion.sqlConnection.Open();

                SqlCommand sqlCommand = new SqlCommand("sp_Graficos", conexion.sqlConnection);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.AddWithValue("@accion", "Operadores");

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

        public void Conductores(Chart chart)
        {

            try
            {
                conexion.sqlConnection.Open();

                SqlCommand sqlCommand = new SqlCommand("sp_Graficos", conexion.sqlConnection);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.AddWithValue("@accion", "Conductores");

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

        public void Producto(Chart chart)
        {

            try
            {
                conexion.sqlConnection.Open();

                SqlCommand sqlCommand = new SqlCommand("sp_Graficos", conexion.sqlConnection);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.AddWithValue("@accion", "Productos");

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

        public void Datos(Label lblTotalBoletas, Label lblProceso, Label lblAnuladas, Label lblPesoTotal, Label lblPesoPromedio, Label lblMayorPesaje,
            Label lblMenorPesaje, Label lblAdministradores, Label lblOperadores, Label lblConductores, Label lblClientes, Label lblBarcos, Label lblProductos)
        {
         
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
                        lblTotalBoletas.Text = String.Format("Cerradas: {0:n0}", int.Parse(dataTable.Rows[0]["Boletas"].ToString()));
                        lblProceso.Text = String.Format("En proceso: {0:n0}", int.Parse(dataTable.Rows[0]["Proceso"].ToString()));
                        lblAnuladas.Text = String.Format("Anuladas: {0:n0}", int.Parse(dataTable.Rows[0]["Anuladas"].ToString()));
                        lblPesoTotal.Text = String.Format("Peso total general: {0:n} Kg", float.Parse(dataTable.Rows[0]["Peso_Total"].ToString()));
                        lblPesoPromedio.Text = String.Format("Peso promedio general: {0:n} Kg", float.Parse(dataTable.Rows[0]["Peso_Promedio"].ToString()));
                        lblMayorPesaje.Text = String.Format("Mayor pesaje: {0:n} Kg", float.Parse(dataTable.Rows[0]["Mayor_Pesaje"].ToString()));
                        lblMenorPesaje.Text = String.Format("Menor pesaje: {0:n} Kg", float.Parse(dataTable.Rows[0]["Menor_Pesaje"].ToString()));
                        lblAdministradores.Text = String.Format("Administradores: {0:n0}", int.Parse(dataTable.Rows[0]["Administradores"].ToString()));
                        lblOperadores.Text = String.Format("Operadores: {0:n0}", int.Parse(dataTable.Rows[0]["Operadores"].ToString()));
                        lblConductores.Text = String.Format("Conductores: {0:n0}", int.Parse(dataTable.Rows[0]["Conductores"].ToString()));
                        lblClientes.Text = String.Format("Clientes: {0:n0}", int.Parse(dataTable.Rows[0]["Clientes"].ToString()));
                        lblBarcos.Text = String.Format("Barcos: {0:n0}", int.Parse(dataTable.Rows[0]["Barcos"].ToString()));
                        lblProductos.Text = String.Format("Productos: {0:n0}", int.Parse(dataTable.Rows[0]["Productos"].ToString()));
                    }
                  

                    
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
