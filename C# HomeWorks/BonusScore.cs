using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Globalization;
using System.Threading.Tasks;

namespace ConsoleApplication2
{

    public class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            if (n >= 1 && n <= 3 )
            {
                n *= 10;
                Console.WriteLine(n);
            }
            if (n >= 4 && n <= 6)
            {
                n *= 100;
                Console.WriteLine(n);
            }
            if (n >= 7 && n <= 9)
            {
                n *= 1000;
                Console.WriteLine(n);
            }
            else if (n < 0 || n > 9)
            {
                Console.WriteLine("Invalid score");
            }
        }
    }
}