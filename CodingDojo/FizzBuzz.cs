using System;
using System.Text;

namespace CodingDojo
{
    internal class FizzBuzz
    {
        public FizzBuzz()
        {
        }

        internal string Print(int value)
        {
            StringBuilder stringBuilder = new StringBuilder();
            if (IsFizz(value)) stringBuilder.Append("Fizz");
            if (IsBuzz(value)) stringBuilder.Append("Buzz");
            if (stringBuilder.Length == 0) stringBuilder.Append(value.ToString());
            return stringBuilder.ToString();
        }

        private static bool IsFizz(int value)
        {
                return (value % 3 == 0);
        }

        private static bool IsBuzz(int value)
        {
                return (value % 5 == 0);
        }

    }   
}