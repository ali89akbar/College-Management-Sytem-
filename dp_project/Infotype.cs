using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dp_project
{
    class Infotype:Info
    {
        
        public Infotype(string name, string fname,string cont,string age)
            : base(name,fname,cont,age)
        {
        }
        
        public override Info Clone()
        {
            return (Info)this.MemberwiseClone();
        }
    }
}
