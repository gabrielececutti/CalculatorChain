using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorChainLibrary
{
    public abstract class Validator
    {
        protected Validator _successor;

        public void SetSuccessor (Validator successor)
        {
            _successor = successor;
        }

        public abstract Response IsValid (Response value);
    }
}
