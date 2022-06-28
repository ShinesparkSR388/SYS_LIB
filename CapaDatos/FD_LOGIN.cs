using CapaModelo;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class FD_LOGIN
    {
        public static bool ValidarUsuario(Usuario user)
        {
            using (SqlConnection cConn = new SqlConnection(Conexion.cn))
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("val_User", cConn);
                    cmd.Parameters.AddWithValue("Usuario", user.User);
                    cmd.Parameters.AddWithValue("Pass", user.Pass);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("Resultado", SqlDbType.Bit).Direction = ParameterDirection.Output;

                    cConn.Open();
                    cmd.ExecuteNonQuery();
                    bool QRes = System.Convert.ToBoolean(cmd.Parameters["Resultado"].Value);
                    return QRes;
                }
                catch (Exception ex)
                {
                    return false;
                }
            }
        }
    }
}
