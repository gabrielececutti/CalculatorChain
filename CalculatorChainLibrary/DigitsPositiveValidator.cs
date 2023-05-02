using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorChainLibrary
{
    public class DigitsPositiveValidator : Validator
    {
        public override Response IsValid(Response value)
        {
            var response = value;
            foreach (var n in response.Numbers)
            {
                if (n < 0) 
                {
                    response.Valid = false;
                    response.Error = "the the string must contain only positive digits.";
                    return response;
                }
            }
            response.Valid = true;
            response.Sum = response.Numbers.Sum (x => x);
            return response;
        }
    }
}
