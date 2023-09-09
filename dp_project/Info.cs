using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dp_project
{
    public abstract class Info
    {
        string names;
        string father_n;
        string contacts;
        string age;
        
        public Info(string name, string f_name, string contact, string age)
        {
            this.names = name;
            this.father_n = f_name;
            this.contacts = contact;
            this.age = age;
        }
        
        public string name
        {
            get { return names; }
        }
        public string fname
        {
            get { return father_n; }
        }
        public string cont
        {
            get { return contacts; }
        }
        public string ages
        {
            get { return age; }
        }
        public abstract Info Clone();
    }
}
