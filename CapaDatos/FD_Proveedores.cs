using CapaModelo;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class FD_Proveedores
    {
        public static List<Proveedor> ObtenerProveedores()
        {
            List<Proveedor> providers = new List<Proveedor>();
            using (SqlConnection cConn = new SqlConnection(Conexion.cn))
            {
                SqlCommand cmd = new SqlCommand("get_Provider", cConn);
                cmd.CommandType = CommandType.StoredProcedure;

                try
                {
                    cConn.Open();
                    SqlDataReader dr = cmd.ExecuteReader();

                    while (dr.Read())
                    {
                        providers.Add(new Proveedor()
                        {
                            Id = Convert.ToInt32(dr["IdProveedor"].ToString()),
                            Tipo = Convert.ToInt32(dr["Tipo"].ToString()),
#pragma warning disable CS8601 // Posible asignación de referencia nula
                            Descripcion = dr["Descripcion"].ToString(),
                            Dui = Convert.ToInt64(dr["Dui"].ToString()),
                            Nit = Convert.ToInt64(dr["Nit"].ToString()),
                            Registro = dr["FechaRegistro"].ToString()
#pragma warning restore CS8601 // Posible asignación de referencia nula


                        });
                    }
                    dr.Close();
                    return providers;
                }
                catch (Exception ex)
                {
                    return null;
                }
            }
        }
        public static List<Proveedor> BuscarProveedores(int Id)
        {
            List<Proveedor> providers = new List<Proveedor>();
            using (SqlConnection cConn = new SqlConnection(Conexion.cn))
            {
                SqlCommand cmd = new SqlCommand("search_Provider", cConn);
                cmd.Parameters.AddWithValue("IdProveedor", Id);
                cmd.CommandType = CommandType.StoredProcedure;

                try
                {
                    cConn.Open();
                    SqlDataReader dr = cmd.ExecuteReader();

                    while (dr.Read())
                    {
                        providers.Add(new Proveedor()
                        {
                            Id = Convert.ToInt32(dr["IdProveedor"].ToString()),
                            Tipo = Convert.ToInt32(dr["Tipo"].ToString()),
#pragma warning disable CS8601 // Posible asignación de referencia nula
                            Descripcion = dr["Descripcion"].ToString(),
                            Dui = Convert.ToInt64(dr["Dui"].ToString()),
                            Nit = Convert.ToInt64(dr["Nit"].ToString()),
                            Registro = dr["FechaRegistro"].ToString()
#pragma warning restore CS8601 // Posible asignación de referencia nula

                        });
                    }
                    dr.Close();
                    return providers;
                }
                catch (Exception ex)
                {
                    return null;
                }
            }
        }

        public static bool EliminarProveedores(int Id)
        {
            using (SqlConnection cConn = new SqlConnection(Conexion.cn))
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("del_Provider", cConn);
                    cmd.Parameters.AddWithValue("IdProveedor", Id);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("Resultado", SqlDbType.Bit).Direction = ParameterDirection.Output;



                    cConn.Open();
                    cmd.ExecuteNonQuery();
                    bool QRes = Convert.ToBoolean(cmd.Parameters["Resultado"].Value);
                    return QRes;
                }
                catch (Exception ex)
                {
                    return false;
                }
            }
        }

        public static bool GuardarProveedores(Proveedor datos)
        {
            bool QRes = false;
            using (SqlConnection cConn = new SqlConnection(Conexion.cn))
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("reg_Provider", cConn);
                    cmd.Parameters.AddWithValue("Tipo", datos.Tipo);
                    cmd.Parameters.AddWithValue("FechaRegistro", datos.Registro);
                    cmd.Parameters.AddWithValue("Dui", datos.Dui);
                    cmd.Parameters.AddWithValue("Nit", datos.Nit);
                    cmd.Parameters.AddWithValue("Descripcion", datos.Descripcion);
                    cmd.Parameters.Add("Resultado", SqlDbType.Bit).Direction = ParameterDirection.Output;
                    cmd.CommandType = CommandType.StoredProcedure;

                    cConn.Open();
                    cmd.ExecuteNonQuery();

                    QRes = Convert.ToBoolean(cmd.Parameters["Resultado"].Value);

                    return QRes;
                }
                catch (Exception ex)
                {
                    return QRes;
                }
            }
        }

        public static bool ModificarProveedores(Proveedor datos)
        {
            bool QRes = false;
            using (SqlConnection cConn = new SqlConnection(Conexion.cn))
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("upd_Provider", cConn);
                    cmd.Parameters.AddWithValue("IdProveedor", datos.Id);
                    cmd.Parameters.AddWithValue("Tipo", datos.Tipo);
                    cmd.Parameters.AddWithValue("Dui", datos.Dui);
                    cmd.Parameters.AddWithValue("Nit", datos.Nit);
                    cmd.Parameters.AddWithValue("Descripcion", datos.Descripcion);
                    cmd.Parameters.Add("Resultado", SqlDbType.Bit).Direction = ParameterDirection.Output;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cConn.Open();
                    cmd.ExecuteNonQuery();

                    QRes = Convert.ToBoolean(cmd.Parameters["Resultado"].Value);

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
