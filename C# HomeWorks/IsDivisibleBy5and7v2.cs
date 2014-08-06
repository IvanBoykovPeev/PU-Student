using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsDivisibleBy5and7
{
    class IsDivisibleBy5and7
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            bool isDiveded = (number % 5 == 0) && (number % 7 == 0);
            Console.WriteLine(isDiveded);
        }
    }
}
