﻿using System;
using System.Collections.Generic;

namespace CodingDojo
{
    internal class FooBarQix
    {
        Dictionary<int, string> _ruleDictionary = new Dictionary<int, string>()
        {
            {3,"Foo"},
            {5,"Bar"},
            {7,"Qix"},
        };
        public FooBarQix()
        {
        }

        internal string What(int value)
        {
            string result = string.Empty;
            foreach (var ruleKey in _ruleDictionary.Keys)
            {
                if (value % ruleKey == 0)
                {
                    result += _ruleDictionary[ruleKey];
                }

                foreach (var c in value.ToString())
                {
                    if (c.ToString().Equals(ruleKey.ToString()))
                    {
                        result += _ruleDictionary[ruleKey];
                    }

                }
            }

            if (string.IsNullOrWhiteSpace(result))
            {
                result += value.ToString();

            }

            return result;
        }
    }
}