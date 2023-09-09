using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dp_project
{
    class facade
    {
        InFacadePattern insert;
        UpFacadePattern update;
       
        public facade()
        {
            insert = new InFacadePattern();
            update = new UpFacadePattern();
            
        }
        public void insertion(string name, string gender, string contact, string sub, string clas, string age)
        {
            
            insert.insert_t(name, gender, contact, sub, clas, age);
        }
        public void updation(string name, string gender, string contact, string sub, string clas, string age)
        {
            update.Update_t(name, gender, contact, sub, clas, age);
        }
       
    }
}
