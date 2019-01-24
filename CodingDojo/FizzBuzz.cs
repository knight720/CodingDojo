using System;

namespace CodingDojo
{
    internal class FizzBuzz
    {
        public FizzBuzz()
        {
        }

        internal string GetResult(int value)
        {
            if (value % 3 == 0 && value % 5 == 0)
            {
                return "FizzBuzz";
            }
            if (value % 5 == 0)
            {
                return "Buzz";

            }
            if (value % 3 == 0)
            {

                return "Fizz";
            }

            return value.ToString();
        }
    }
}