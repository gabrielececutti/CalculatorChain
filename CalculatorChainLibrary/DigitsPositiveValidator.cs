using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorChainLibrary
{
    public class DigitsPositiveValidator : Validator
    {
        public override Response IsValid(List<string> list)
        {
            if (int.Parse(list[0]) > 0 && int.Parse(list[1]) > 0)
            {
                if (_successor != null) return _successor.IsValid(list);
                return new Response { Error = string.Empty, Valid = true };
            }
            return new Response { Error = "the string must contain only positive numbers", Valid = false };
        }
    }
}
