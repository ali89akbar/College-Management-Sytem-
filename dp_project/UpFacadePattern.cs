using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace dp_project
{
    class UpFacadePattern
    {
        public void Update_t(string name, string gender, string contact, string sub, string clas, string age)
        {
            string query = "Update teacher set name= '" + name + "' , gender = '" + gender + "'," +
                "contact = '" + contact + "',subject= '" + sub + "',class = '" + clas + "' where age = '" + age + "'";
            SqlCommand sc1 = new SqlCommand(query, connection.GetConnection());
            sc1.ExecuteNonQuery();
        }
    }
}
