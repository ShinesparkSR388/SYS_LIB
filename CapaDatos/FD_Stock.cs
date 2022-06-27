using CapaModelo;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class FD_Stock
    {
        public static bool registrarStock(Orden Orden_)
        {
            bool QRes = false;
            using (SqlConnection cConn = new SqlConnection(Conexion.cn))
            {
                
                try
                {
                    SqlCommand cmd = new SqlCommand("reg_Stock", cConn);
                    cmd.Parameters.AddWithValue("IdProducto", Orden_.IdProducto);
                    cmd.Parameters.AddWithValue("Descripcion", Orden_.Name);
                    cmd.Parameters.AddWithValue("Paquetes", Orden_.Paquetes);
                    cmd.Parameters.AddWithValue("UnidadPaquete", Orden_.UnidadPaquete);
                    cmd.Parameters.AddWithValue("PrecioPaquete", Orden_.PrecioPaquete);
                    cmd.Parameters.AddWithValue("FechaRegistro", Orden_.FechaRegistro);
                    cmd.Parameters.Add("Result", SqlDbType.Bit).Direction = ParameterDirection.Output;
                    cmd.CommandType = CommandType.StoredProcedure;

                    cConn.Open();
                    cmd.ExecuteNonQuery();

                    QRes = Convert.ToBoolean(cmd.Parameters["Result"].Value);

                    return QRes;
                }
                catch (Exception ex)
                {
                    return QRes;
                }
            }
        }
    }
}
