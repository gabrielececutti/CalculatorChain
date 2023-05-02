using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorChainConsoleApp
{
    public  class Splitter
    {
        private readonly string _split;
        public Splitter(string split) 
        {
            _split = split;
        }
        public List<string> Split (string myString)
        {
            return myString.Split(_split).ToList();
        }

    }
}
