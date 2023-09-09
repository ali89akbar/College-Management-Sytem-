using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dp_project
{
    class c_prototype:a_proto
    {
        
        public c_prototype(string name, string fname,string cont,string age)
            : base(name,fname,cont,age)
        {
        }
        
        public override a_proto Clone()
        {
            return (a_proto)this.MemberwiseClone();
        }
    }
}
