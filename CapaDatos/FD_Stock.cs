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
        public static List<Libro> obtenerLibros()
        {
            List<Libro> libros = new List<Libro>();
            using (SqlConnection cConn = new SqlConnection(Conexion.cn))
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("get_Stock", cConn);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cConn.Open();
                    SqlDataReader read = cmd.ExecuteReader();
                    while (read.Read())
                    {
                        libros.Add(new Libro()
                        {
                            IdLote = Convert.ToInt32(read["IdItem"]),
                            IdProducto = Convert.ToInt32(read["IdProducto"]),
                            Name = read["Descripcion"].ToString(),
                            Unidades = Convert.ToInt32(read["Unidades"]),
                            Paquetes = Convert.ToInt32(read["Paquetes"]),
                            UnidadPaquete = Convert.ToInt32(read["UnidadPaquete"]),
                            PrecioPaquete = Convert.ToDouble(read["PrecioPaquete"]),
                            fechaRegistro = read["FechaRegistro"].ToString()
                        });
                    }

                    return libros;
                }
                catch (Exception ex)
                {
                    return libros;
                }
            }

        }
        public static bool actualizarStock(Libro nuevo_)
        {
            bool QRes = false;
            using (SqlConnection cConn = new SqlConnection(Conexion.cn))
            {

                try
                {
                    SqlCommand cmd = new SqlCommand("upd_new_Stock", cConn);
                    cmd.Parameters.AddWithValue("IdProducto", nuevo_.IdProducto);
                    cmd.Parameters.AddWithValue("Paquetes", nuevo_.Paquetes);
                    cmd.Parameters.AddWithValue("Unidades", nuevo_.Unidades);
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
