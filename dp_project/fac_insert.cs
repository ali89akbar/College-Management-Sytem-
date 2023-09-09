using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace dp_project
{
    class fac_insert
    {
        
        public void insert_t(string name, string gender, string contact,string sub,string clas, string age) 
        {
            string query = "insert into tdetails values('" + name + "' , '" + gender + "', '" + contact + "', '" + sub + "', '" + clas + "','" + age + "')";
            SqlCommand cmd = new SqlCommand(query, connection.GetConnection());
            cmd.ExecuteNonQuery();
        }

    }
}
