using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitInPositionValue
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int p = int.Parse(Console.ReadLine());

            byte bitValue = (byte)(n >> p & 1);

            Console.WriteLine(bitValue);

            Console.ReadKey();
        }
    }
}
