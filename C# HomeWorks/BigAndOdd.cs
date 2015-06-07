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
            bool result =false;
            if (n > 20 && (n%2 == 1))
            {
                result = true;
            }

            Console.WriteLine(result);
            
        }
    }
}
