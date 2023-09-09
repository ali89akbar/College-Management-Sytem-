using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dp_project
{
    public abstract class a_proto
    {
        string n;
        string f_n;
        string c;
        string age;
        
        public a_proto(string name, string f_name, string contact, string age)
        {
            this.n = name;
            this.f_n = f_name;
            this.c = contact;
            this.age = age;
        }
        
        public string name
        {
            get { return n; }
        }
        public string fname
        {
            get { return f_n; }
        }
        public string cont
        {
            get { return c; }
        }
        public string ag
        {
            get { return age; }
        }
        public abstract a_proto Clone();
    }
}
