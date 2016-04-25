using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildTestApp1
{
    public class Calculator
    {
        private int _total;
        public Calculator() { _total = 0; }

        public void Add(int number)
        {
            _total += number;
        }

        public int Total { get { return _total; } }
    }
}
