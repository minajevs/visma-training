using System;
using System.Collections.Generic;
using System.Text;

namespace exceptions6
{
    class NegativeSpeedException : ApplicationException
    {
        public NegativeSpeedException() 
            : base("Speed can't be negative!")
        { }
    }
}
