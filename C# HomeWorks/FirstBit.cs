using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Average
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int bitAtPosition = n >> 1 & 1;

            Console.WriteLine(bitAtPosition);
            
        }
    }
}
