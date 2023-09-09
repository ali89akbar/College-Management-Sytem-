using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dp_project
{
    class Discount40State : FeeState
    {
        public override void CalculateFee(Context context)
        {
            MessageBox.Show("Your Fees is Submitted with discount of 40%");
        }
    }
}
