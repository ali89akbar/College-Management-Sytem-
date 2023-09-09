using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms ;

namespace dp_project
{
    class student:FactoryPattern
    {
        
        public override void student_l(string name,string password)
        {
            
            string query = string.Format("select * from abc where name='{0}' and password='{1}'",name, password);
            string constr = "Data Source=DESKTOP-SM490GV;Initial Catalog=college;Integrated Security=True";
            SqlConnection con = new SqlConnection(constr);
            con.Open();
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader dr = cmd.ExecuteReader();    
        }
        public override void teacher_l(string name, string password)
        {
            string query = string.Format("select * from abc where name='{0}' and password='{1}'", name, password);
            string constr = "data source=DESKTOP-5I1I8LR; initial catalog=ABC; integrated security=true";
            SqlConnection con = new SqlConnection(constr);
            con.Open();
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader dr = cmd.ExecuteReader();
            
        }
    }
}
