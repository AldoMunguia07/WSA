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

                SqlCommand sqlCommand = new SqlCommand("sp_Cliente", conexion.sqlConnection);
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



    }
}
