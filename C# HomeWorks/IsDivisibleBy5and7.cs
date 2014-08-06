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
            bool IsDivisibleBy5and7 = number % 35 == 0;
            Console.WriteLine(IsDivisibleBy5and7);
        }
    }
}
