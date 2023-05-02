using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorChainLibrary
{
    public class TwoItemValidator : Validator
    {
        public override Response IsValid(List<string> list)
        {
           if (list.Count == 2)
           {
                if (_successor != null) return _successor.IsValid(list);
                return new Response { Error = string.Empty, Valid= true };
           }
           return new Response { Error = "there must be two items", Valid = false };
        }
    }
}
