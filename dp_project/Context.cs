using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dp_project
{
    class Context
    {
        private FeeState currentState;

        public Context()
        {
            // Set an initial state, for example:
            currentState = new NoDiscountState();
        }

        public void SetState(FeeState state)
        {
            currentState = state;
        }

        public void CalculateFee()
        {
            currentState.CalculateFee(this);
        }
    }

}
