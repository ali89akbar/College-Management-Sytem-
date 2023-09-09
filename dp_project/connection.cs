using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace dp_project
{
    class connection
    {
        static SqlConnection con;
        // First : Data server name, second : database name,
        static string constr = "Data Source=DESKTOP-SM490GV;Initial Catalog=college;Integrated Security=True";

        public static SqlConnection GetConnection()
        {
            con = new SqlConnection(constr);
            if (con.State == ConnectionState.Closed)
            {

                con.Open();
            }
            return con;

        }
    }
}
