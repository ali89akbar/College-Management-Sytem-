using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace dp_project
{
    class fac_upd
    {
        public void Update_t(string name, string gender, string contact, string sub, string clas, string age)
        {
            string query = "Update tdetails set tname= '" + name + "' , tgender = '" + gender + "',tcontact = '" + contact + "',tsubject= '" + sub + "',tclass = '" + clas + "' where tage = '" + age + "'";
            SqlCommand sc1 = new SqlCommand(query, connection.GetConnection());
            sc1.ExecuteNonQuery();
        }
    }
}
