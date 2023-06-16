using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace kasir
{
    internal class Koneksi
    {
        public SqlConnection getConn()
        {
            SqlConnection Conn = new SqlConnection();
            Conn.ConnectionString = "Data Source=Hafizen; initial catalog=DB_APPKASIR; integrated security=true";
            return Conn;
        }

        internal void Open()
        {
            throw new NotImplementedException();
        }
    }
}
