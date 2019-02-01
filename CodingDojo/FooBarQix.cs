using System;
using System.Collections.Generic;

namespace CodingDojo
{
    internal class FooBarQix
    {
        Dictionary<int,string> _ruleDictionary = new Dictionary<int, string>()
        {
            {3,"FooFoo"},
            {5,"BarBar"},
            {7,"QixQix"},
        };
        public FooBarQix()
        {
        }

        internal string What(int value)
        {
            foreach (var ruleKey in _ruleDictionary.Keys)
            {
            if (value % ruleKey == 0 && value.ToString().Contains(ruleKey.ToString()))
            {
                return _ruleDictionary[ruleKey];
            }
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