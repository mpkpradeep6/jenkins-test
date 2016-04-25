using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildTestApp1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var calc = new Calculator();
            calc.Add(2);
            calc.Add(3);
            Console.WriteLine("Calculator Total: {0}", calc.Total);
        }
    }
}
