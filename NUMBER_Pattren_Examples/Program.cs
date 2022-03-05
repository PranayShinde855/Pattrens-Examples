using System;

namespace NUMBER_Pattren_Examples
{
    class Program
    {
        static void Main(string[] args)
        {
            //1 Print 1 to 5 Num bers
            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("\n");

            //2 Print 5 to 1 numbers
            for (int i = 5; i >= 1; i--)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("\n");

            //3 Add numbers to line by line from 1 to 5
            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(i);
                }
                Console.WriteLine();
            }

            Console.WriteLine("\n");

            //4 Add Numbers in line by line from 1 to 5
            for (int i = 1; i <= 5; i++)
            {
                for (int J = 5; J >= i; J--)
                {
                    Console.Write(i);
                }
                Console.WriteLine();
            }
        }
    }
}
