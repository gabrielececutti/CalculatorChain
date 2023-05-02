using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorChainLibrary
{
    public class SetUpChain
    {
        private readonly Validator _chain;

        public SetUpChain()
        {
            var digitsValidator = new DigistsValidator();
            var digitsPostiveValidator = new DigitsPositiveValidator();

            digitsValidator.SetSuccessor(digitsPostiveValidator);
            _chain = digitsValidator;
        }

        public Validator GetChain => _chain;
    }
}
