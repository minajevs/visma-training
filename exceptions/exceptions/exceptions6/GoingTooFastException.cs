using System;
using System.Collections.Generic;
using System.Text;

namespace exceptions6
{
    class GoingTooFastException : ApplicationException
    {
        public GoingTooFastException(int attemptedSpeed, int maxSpeed) 
            : base($"{attemptedSpeed} is too fast! Car can only go {maxSpeed}")
        { }
    }
}
