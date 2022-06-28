using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaModelo;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class FD_Output
    {
        public static bool registrarVenta(Venta venta_)
        {
            bool QRes = false;
            using (SqlConnection cConn = new SqlConnection(Conexion.cn))
            {

                try
                {
                    SqlCommand cmd = new SqlCommand("reg_Output", cConn);
                    cmd.Parameters.AddWithValue("IdProducto", venta_.IdProducto);
                    cmd.Parameters.AddWithValue("Descripcion", venta_.Name);
                    cmd.Parameters.AddWithValue("Unidades", venta_.Unidades);
                    cmd.Parameters.AddWithValue("Paquetes", venta_.Paquetes);
                    cmd.Parameters.AddWithValue("PrecioTotal", venta_.PrecioTotal);
                    cmd.Parameters.AddWithValue("FechaRegistro", venta_.fechaRegistro);
                    cmd.Parameters.Add("Result", SqlDbType.Bit).Direction = ParameterDirection.Output;
                    cmd.CommandType = CommandType.StoredProcedure;

                    cConn.Open();
                    cmd.ExecuteNonQuery();

                    QRes = System.Convert.ToBoolean(cmd.Parameters["Result"].Value);

                    return QRes;
                }
                catch (Exception ex)
                {
                    return QRes;
                }
            }
        }
        public static bool EliminarVenta(Venta venta_)
        {
            bool QRes = false;
            using (SqlConnection cConn = new SqlConnection(Conexion.cn))
            {

                try
                {
                    SqlCommand cmd = new SqlCommand("del_Output", cConn);
                    cmd.Parameters.AddWithValue("IdProducto", venta_.IdProducto);
                    cmd.Parameters.Add("Result", SqlDbType.Bit).Direction = ParameterDirection.Output;
                    cmd.CommandType = CommandType.StoredProcedure;

                    cConn.Open();
                    cmd.ExecuteNonQuery();

                    QRes = System.Convert.ToBoolean(cmd.Parameters["Result"].Value);

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
