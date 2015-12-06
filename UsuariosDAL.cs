using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Inventario
{
    class UsuariosDAL
    {
        public static int CrearCuentas(string pUser, string pPass)
        {
            int res = 0;
            SqlConnection Conn = new SqlConnection(ConexionBD.ObtenerString());
            Conn.Open();
            SqlCommand Comm = new SqlCommand(string.Format("Insert into Users Values('{0}', PwdEncrypt('{1}'))", pUser, pPass), Conn);

            res = Comm.ExecuteNonQuery();
            Conn.Close();

            return res;
        }

        public static int Autentificar(String pUser, String pPass)
        {
            int res = -1;

            SqlConnection Conn = new SqlConnection(ConexionBD.ObtenerString());
            Conn.Open();
            SqlCommand Comm = new SqlCommand(string.Format("Select * From Users where Name = '{0}' and PwdCompare('{1}', Pass) = 1", pUser, pPass), Conn);
            SqlDataReader reader = Comm.ExecuteReader();

            while (reader.Read())
            {
                res = 50;
            }

            return res;
        }
    }
}
