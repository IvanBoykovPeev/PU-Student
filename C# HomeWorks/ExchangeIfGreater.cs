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
            Thread.CurrentThread.CurrentCulture = CultureInfo.GetCultureInfo("en-US");
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double swap;
            if (a > b)
            {
                swap = a;
                a = b;
                b = swap;
            }
            Console.WriteLine(a + " " + b);
        }
    }
}