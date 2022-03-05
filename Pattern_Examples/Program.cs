using System;

namespace STAR_Pattern_Examples
{
    class Program
    {
        static void Main(string[] args)
        {
            //1 Understood the difference between Write() & WriteLine()
            for (int i = 1; i <= 6; i++)
            {
                Console.Write("*");
            }

            Console.WriteLine("\n");

            for (int i = 1; i <= 6; i++)
            {
                Console.WriteLine("*");
            }

            Console.WriteLine("\n");

            //2
            for (int i = 1; i <= 6; i++)
            {
                for (int j = 1; j <= 6; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine("*");
            }

            Console.WriteLine("\n");

            //3
            for (int i = 1; i <= 6; i++)
            {
                for (int j = 1; j < i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine("*");
            }

            Console.WriteLine("\n");

            //4
            for (int i = 1; i <= 6; i++)
            {
                for (int j = 6; j > i; j--)
                {
                    Console.Write("*");
                }
                Console.WriteLine("*");
            }

            Console.WriteLine("\n");

            //5
            for (int i = 1; i <= 6; i++)
            {
                for (int j = 6; j > i; j--)
                {
                    Console.Write(" ");
                }
                for (int k = 1; k <= i; k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            Console.WriteLine("\n");

            //6
            for (int i = 1; i <= 6; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(" ");
                }
                for (int l = 6; l > i; l--)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            Console.WriteLine("\n");

            //7
            for (int i = 1; i <= 6; i++)
            {
                for (int j = 6; j > i; j--)
                {
                    Console.Write(" ");
                }
                for (int k = 1; k < i; k++)
                {
                    Console.Write("*");
                }
                for (int l = 0; l < i; l++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            Console.WriteLine("\n");

            //8
            for (int i = 1; i <= 6; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write(" ");
                }
                for (int k = 6; k > i; k--)
                {
                    Console.Write("*");
                }
                for (int l = 6; l >= i; l--)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}
