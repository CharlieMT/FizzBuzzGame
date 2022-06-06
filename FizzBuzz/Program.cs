using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello in FizzBuzz app \nWe will check if your number is divided by 3 or 5 and return Fizz, Buzz or FizzBuzz message ;)");

            while (true)
            {

                CheckFizzBuzz checkFizzBuzz = new CheckFizzBuzz();

                var numberCheck = Program.InputCheck();

                Console.WriteLine(checkFizzBuzz.FizzBuzzCHeck(numberCheck));

                if (ExitMenu())
                    break;
            }
        }

        private static int InputCheck()
        {
            while (true)
            {
                Console.WriteLine("Please provide your number");
                if (!int.TryParse(Console.ReadLine(), out int number))
                {
                    Console.WriteLine("Wrong value provided :( ");
                    continue;
                }

                return number;
            }
        }

        private static bool ExitMenu()
        {
            while (true)
            {
                Console.WriteLine("Type X to Exit or C to Continue");
                var answer = Console.ReadLine().ToUpper();

                if (answer.Equals("X"))
                    return true;

                if (answer.Equals("C"))
                    return false;
            }
        }
    }
}
