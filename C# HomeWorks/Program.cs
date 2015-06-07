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
            if (n%9 == 0 || n%11 == 0 || n% 13 == 0)
            {
                result = true;
            }

            Console.WriteLine(result);
            
        }
    }
}
