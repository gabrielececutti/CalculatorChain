using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorChainLibrary
{
    public class Response
    {
        public string Input { get; set; }
        public bool Valid { get; set; }
        public string Error { get; set; }
        public List<int> Numbers { get; set; }
        public int Sum { get; set; }
    }
}
