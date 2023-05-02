using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorChainLibrary
{
    public record Response
    {
        public bool Valid { get; set; }
        public string Error { get; set; }
    }
}
