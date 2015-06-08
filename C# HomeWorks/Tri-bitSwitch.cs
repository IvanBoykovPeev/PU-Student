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
            long n = long.Parse(Console.ReadLine());
            int p = int.Parse(Console.ReadLine());
            long mask = (long)7 << p;
            Console.WriteLine();
            Console.WriteLine("mask:   " + Convert.ToString(mask, 2).PadLeft(65, '0'));
            long result = n ^ mask;
            Console.WriteLine("n:      " + Convert.ToString(n, 2).PadLeft(65, '0'));
            Console.WriteLine("result: " + Convert.ToString(result, 2).PadLeft(65, '0'));
            Console.WriteLine();
            Console.WriteLine(result);
            
        }
    }
}
