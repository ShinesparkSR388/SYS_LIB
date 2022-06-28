using CapaModelo;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class FD_Productos
    {
        public static List<Producto> ObtenerPoductos()
        {
            List<Producto> products = new List<Producto>();
            using (SqlConnection cConn = new SqlConnection(Conexion.cn))
            {
                SqlCommand cmd = new SqlCommand("get_Products", cConn);
                cmd.CommandType = CommandType.StoredProcedure;

                try
                {
                    cConn.Open();
                    SqlDataReader dr = cmd.ExecuteReader();

                    while (dr.Read())
                    {
                        products.Add(new Producto()
                        {
                            Id = System.Convert.ToInt32(dr["IdProducto"].ToString()),
#pragma warning disable CS8601 // Posible asignación de referencia nula
                            Descripcion = dr["Descripcion"].ToString(),
                            IdProveedor = System.Convert.ToInt32(dr["IdProveedor"].ToString()),
                            UnidadPaquete = System.Convert.ToInt32(dr["UnidadPaquete"].ToString()),
                            PrecioPaquete = System.Convert.ToDouble(dr["PrecioPaquete"].ToString()),
                            FechaRegistro = dr["FechaRegistro"].ToString()
#pragma warning restore CS8601 // Posible asignación de referencia nula
                        });
                    }
                    dr.Close();
                    return products;
                }
                catch (Exception ex)
                {
                    return null;
                }
            }
        }
        public static List<Producto> BuscarProductos(string Nombre)
        {
            List<Producto> products = new List<Producto>();
            using (SqlConnection cConn = new SqlConnection(Conexion.cn))
            {
                SqlCommand cmd = new SqlCommand("search_Products", cConn);
                cmd.Parameters.AddWithValue("Nombre", Nombre);
                cmd.CommandType = CommandType.StoredProcedure;

                try
                {
                    cConn.Open();
                    SqlDataReader dr = cmd.ExecuteReader();

                    while (dr.Read())
                    {
                        products.Add(new Producto()
                        {
                            Id = System.Convert.ToInt32(dr["IdProducto"].ToString()),
#pragma warning disable CS8601 // Posible asignación de referencia nula
                            Descripcion = dr["Descripcion"].ToString(),
                            IdProveedor = System.Convert.ToInt32(dr["IdProveedor"].ToString()),
                            UnidadPaquete = System.Convert.ToInt32(dr["UnidadPaquete"].ToString()),
                            PrecioPaquete = System.Convert.ToDouble(dr["PrecioPaquete"].ToString()),
                            FechaRegistro = dr["FechaRegistro"].ToString()
#pragma warning restore CS8601 // Posible asignación de referencia nula
                        });
                    }
                    dr.Close();
                    return products;
                }
                catch (Exception ex)
                {
                    return null;
                }
            }
        }

        public static bool GuardarProducto(Producto datos)
        {
            bool QRes = false;
            using (SqlConnection cConn = new SqlConnection(Conexion.cn))
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("reg_Products", cConn);
                    cmd.Parameters.AddWithValue("Descripcion", datos.Descripcion);
                    cmd.Parameters.AddWithValue("IdProveedor", datos.IdProveedor);
                    cmd.Parameters.AddWithValue("UnidadPaquete", datos.UnidadPaquete);
                    cmd.Parameters.AddWithValue("PrecioPaquete", datos.PrecioPaquete);
                    cmd.Parameters.AddWithValue("FechaRegistro", datos.FechaRegistro);
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

        public static bool ModificarProducto(Producto datos)
        {
            bool QRes = false;
            using (SqlConnection cConn = new SqlConnection(Conexion.cn))
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("upd_Products", cConn);
                    cmd.Parameters.AddWithValue("IdProducto", datos.Id);
                    cmd.Parameters.AddWithValue("IdProveedor", datos.IdProveedor);
                    cmd.Parameters.AddWithValue("Descripcion", datos.Descripcion);
                    cmd.Parameters.AddWithValue("UnidadPaquete", datos.UnidadPaquete);
                    cmd.Parameters.AddWithValue("PrecioPaquete", datos.PrecioPaquete);
                    cmd.Parameters.Add("Result", SqlDbType.Bit).Direction = ParameterDirection.Output;
                    cmd.CommandType = CommandType.StoredProcedure;

                    cConn.Open();
                    cmd.ExecuteNonQuery();

                    QRes = System.Convert.ToBoolean(cmd.Parameters["Result"].Value);

                    return QRes;
                }
                catch
                {
                    return QRes;
                }
            }
        }

    }
}
