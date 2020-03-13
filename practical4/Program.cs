using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace practical4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter infix String:");
            string infix = Console.ReadLine();

            string postfix;
            Class1.infixtopostfix(infix, out postfix);
            Console.WriteLine(postfix);
            Console.ReadLine();
        }
    }
}
