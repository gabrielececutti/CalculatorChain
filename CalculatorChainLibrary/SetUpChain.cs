using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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
            var twoItemValidator = new TwoItemValidator();
            var digitsValidator = new DigistsValidator();
            var digitsPostiveValidator = new DigitsPositiveValidator();

            twoItemValidator.SetSuccessor(digitsValidator);
            digitsValidator.SetSuccessor(digitsPostiveValidator);
            _chain = twoItemValidator;
        }

        public Validator GetChain => _chain;
    }
}
