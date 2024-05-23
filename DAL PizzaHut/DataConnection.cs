using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_PizzaHut
{
    public class DataConnection
    {
        string con;
        public DataConnection()
        {
            con = @"Data Source=LAPTOP-43O2RGQJ\TRUNGTRUNG;Initial Catalog=DB_PizzaHut;Integrated Security=True";
        }
        public SqlConnection GetConnect()
        {
            return new SqlConnection(con);
        }
    }
}
