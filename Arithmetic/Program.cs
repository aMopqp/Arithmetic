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

            Console.Write("Please, enter first number: "); //Выводит в консоль  "Please, enter first number: "

            string firstNumber = Console.ReadLine();  // Записывает введённое значенеие в переменную firstNumber

            while (!int.TryParse(Console.ReadLine(), out one)) // Ожидает ввод пользователя, если введено не число заходит в цикл . до этого не выведен запрос, пользователю не понятно что делать.
            {
                Console.Write("No! \nPlease, enter first number: ");  //Выводит в консоль  "No! \nPlease, enter first number: "
            }

            if (int.TryParse(Console.ReadLine(), out one))   // Ожидает ввод пользователя. Если введено число записывает его в переменную one и заходит в блок кода if . до этого не выведен запрос, пользователю не понятно что делать.
            {
                Console.Write("Please, enter first number: ");  //Выводит в консоль  "Please, enter first number: "

                string secondNumber = Console.ReadLine();  // Записывает введённое значенеие в переменную secondNumber

                while (!int.TryParse(Console.ReadLine(), out two))  // Ожидает ввод пользователя, если введено не число заходит в цикл . до этого не выведен запрос, пользователю не понятно что делать.
                {
                    Console.WriteLine("No! \nPlease, enter second number: "); //Выводит в консоль  "No! \nPlease, enter second number: "
                }

                if (int.TryParse(Console.ReadLine(), out two))   // Ожидает ввод пользователя. Если введено число записывает его в переменную two и заходит в блок кода за if . до этого не выведен запрос, пользователю не понятно что делать.
                {
                    {
                        Console.WriteLine(one + two); // Выводит сумму

                        Console.WriteLine(one - two); //Выводит разность

                        Console.WriteLine(one * two); // Выводит произведение

                        Console.WriteLine(one / two); //Выводит частное
                        Console.ReadKey();
                    }
                }
            }
        }
    }
}
