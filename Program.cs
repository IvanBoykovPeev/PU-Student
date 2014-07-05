using System;

class PrintSequence
    {
        //Write a program that prints the first 100 members
        //of the sequence 2, -3, 4, -5, 6, -7, 8.

        static void Main(string[] args)
        {
            for (int i = 2; i < 102; i++)
            {
                if (i % 2 == 0)
                {
                    Console.Write("{0,4} ", i);
                }
                else
                {
                    Console.Write("{0,4} ", i * -1);
                }

            }

            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }
    }


