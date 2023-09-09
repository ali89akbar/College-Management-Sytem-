using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dp_project
{
    class NoDiscountState : FeeState
    {
        public override void CalculateFee(Context context)
        {
            MessageBox.Show("Fees is Submitted with no Discount Added Thank you !!");
        }
    }
}
