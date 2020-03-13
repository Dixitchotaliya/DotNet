using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace practical1
{
    class Program
    {
        static void Main(string[] args)
        {
            Pattern_1();
            Pattern_2();
            Pattern_3();
            Console.Read();

            
        }

        private static void Pattern_3()
        {
            Console.WriteLine("Right Aligned Triangle...");
            for (int i = 1; i <6; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }   
        }

        private static void Pattern_2()
        {
            Console.WriteLine("Right Aligned Inverse Triangle...");
            for (int i = 6; i >1; i--)
            {
                for (int j = 1; j <i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }


        private static void Pattern_1()
        {
            Console.WriteLine("Rectangle...");

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Console.Write("*");

                }
                Console.WriteLine();

            }
        
        }
    }
}
