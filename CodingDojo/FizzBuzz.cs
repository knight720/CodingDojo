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
            if (value % 5 == 0)
            {
                return "Buzz";

            }
            return "Fizz";
        }
    }
}