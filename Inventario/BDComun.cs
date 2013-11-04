using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;


namespace Inventario
{
    public class BDComun
    {
        public static SqlConnection ObtenerConexion()
        {
            SqlConnection Conn = new SqlConnection("Data Source= USER\\SQLEXPRESS; Initial Catalog= Cafeteria; Integrated Security= True");
            Conn.Open();
            return Conn;
        }
    }
}
