using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace dp_project
{
    class LoginInfo
    {
        FactoryPattern f = new student();
        private string connectionString = "Data Source=DESKTOP-SM490GV;Initial Catalog=college;Integrated Security=True";

        public void t_s(string name, string password, bool rad1, bool rad2)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT COUNT(*) FROM users WHERE Username = @username AND Password = @password";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@username", name);
                    command.Parameters.AddWithValue("@password", password);

                    int count = (int)command.ExecuteScalar();

                    if (count > 0)
                    {
                        MessageBox.Show("Welcome " + name);

                        if (rad2) // Student
                        {
                            // Perform student-related actions (you can replace this with appropriate logic)
                            // For example, f.student_l(name, password);
                            MessageBox.Show("Welcome to Student Panel");
                            studpanel sp = new studpanel();
                            sp.Show();
                        }
                        else if (rad1) // Teacher
                        {
                            // Perform teacher-related actions (you can replace this with appropriate logic)
                            // For example, f.teacher_l(name, password);
                            MessageBox.Show("Welcome to Admin Panel");
                            Management tp = new Management();
                            tp.Show();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Wrong Username or password");
                    }
                }
            }
        }
    }
}
