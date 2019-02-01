using System;
using System.Collections.Generic;

namespace CodingDojo
{
    internal class FooBarQix
    {
        Dictionary<int, string> _ruleDictionary = new Dictionary<int, string>()
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
            return value.ToString();
        }
    }
}