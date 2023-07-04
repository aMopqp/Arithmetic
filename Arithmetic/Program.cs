using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Arithmetic
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int one;
            int two;
            Console.Write("Please, enter first number: ");
            string firstNumber = Console.ReadLine();
            while (!int.TryParse(Console.ReadLine(), out one))
            {
                Console.Write("No! \nPlease, enter first number: ");
            }
            if (int.TryParse(Console.ReadLine(), out one))
            {
                Console.Write("Please, enter first number: ");
                string secondNumber = Console.ReadLine();
                while (!int.TryParse(Console.ReadLine(), out two))
                {
                    Console.WriteLine("No! \nPlease, enter second number: ");
                }
                if (int.TryParse(Console.ReadLine(), out two))
                {
                    {
                        Console.WriteLine(one + two);
                        Console.WriteLine(one - two);
                        Console.WriteLine(one * two);
                        Console.WriteLine(one / two);
                        Console.ReadKey();
                    }
                }
            }
        }
    }
}
