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
            int number = int.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());
            int nDigit = (int)(number / (Math.Pow(10.0, n - 1))) % 10;
            if (nDigit == 0)
            {
                Console.WriteLine("-");
            }
            else
            {
                Console.WriteLine(nDigit);
            }
            
        }
    }
}
