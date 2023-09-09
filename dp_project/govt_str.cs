using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms; 

namespace dp_project
{
    class govt_str:fees_str
    {
        public override void fee_algo()
        {
            MessageBox.Show("Your Fees is submitted with discount of 10% Thank you !!");
        }
    }
}
