﻿using System;

namespace CodingDojo
{
    internal class FooBarQix
    {
        public FooBarQix()
        {
        }

        internal string What(int value)
        {
            if (value % 3 == 0 && value.ToString().Contains("3"))
            {
                return "FooFoo";
            }
            if (value % 5 == 0 && value.ToString().Contains("5"))
            {
                return "BarBar";
            }
            if (value % 7 == 0 && value.ToString().Contains("7"))
            {
                return "QixQix";
            }
            return value.ToString();
        }
    }
}