using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arithmetic
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please, enter first number: ");
            string firstNumber = Console.ReadLine();
            Console.Write("Please, enter second number: ");
            string secondNumber = Console.ReadLine();
            if (int.TryParse(firstNumber, out int one))
            {
                while (!int.TryParse(Console.ReadLine(), out one))
                {
                    Console.Write("No! \nPlease, enter first number: ");
                }
                if (int.TryParse(secondNumber, out int two)) 
                {
                    while (!int.TryParse(Console.ReadLine(), out two))
                    {
                        Console.Write("No! \nPlease, enter second number: ");
                    }
                    Console.WriteLine(one + two);
                    Console.WriteLine(one - two);
                    Console.WriteLine(one * two);
                    Console.ReadKey();
                }
                else
                {
                    Console.WriteLine("No, you wrong!");
                }
            }
            else
            {
                Console.WriteLine("No, you wrong!");
            }
        }
    }
}
