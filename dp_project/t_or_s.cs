using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dp_project
{
    class t_or_s
    {
        factory_class f = new student();
        public void t_s(string name , string password)
        {
            if (name == "Abdullah" && password == "123")
            {
                f.student_l(name,password);
                //MessageBox.Show("Welcome " + name);
               // Student_Fees ss = new Student_Fees();
               // ss.Show();
            }
            else if(name == "Fahad" && password =="fahad123")
            {
                f.teacher_l(name,password);
                teacher_panel tp = new teacher_panel();
                tp.Show();
                MessageBox.Show("Welcome " + name);
            }
        }
    }
}
