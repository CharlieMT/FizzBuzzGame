using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    class CheckFizzBuzz
    {
        string fizzBuzz = "";
        internal string FizzBuzzCHeck(int number)
        {

            if (number % 3 == 0)
                fizzBuzz = "Fizz";
            if (number % 5 == 0)
                fizzBuzz = fizzBuzz + "Buzz";

            if (String.IsNullOrWhiteSpace(fizzBuzz))
                fizzBuzz = number.ToString();

            return fizzBuzz;

        }
    }
}
