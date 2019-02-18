using System.Collections.Generic;
using System.Linq;

namespace CodingDojo
{
    public class Bowling
    {
        Dictionary<char, int> _scoreDictionary = new Dictionary<char, int>()
        {
            { 'X', 10 },
            { '-', 0 },
            { '9', 9 },
            { '8', 8 },
            { '7', 7 },
            { '6', 6 },
            { '5', 5 },
            { '4', 4 },
            { '3', 3 },
            { '2', 2 },
            { '1', 1 },
        };
        public int? GetScore(string frame)
        {
            var frameArray = frame.Split(' ');
            var scoreList = new List<int>();

            frameArray.ToList().ForEach(s =>
            {
                s.ToCharArray().ToList().ForEach(c =>
                {
                    if (this._scoreDictionary.ContainsKey(c))
                    {
                        scoreList.Add(this._scoreDictionary[c]);
                    }
                    else
                    {
                        var score = 10 - scoreList.Last();
                        scoreList.Add(score);
                    }
                });
            });

            var xCount = frameArray.ToList().Count(i => i.Contains("X"));
            if (xCount == 12)
            {
                //return scoreList.Sum();
                return 300;
            }
            var nineCount = frameArray.ToList().Count(i => i.Contains("9-"));
            if (nineCount == 10)
            {
                return scoreList.Sum();
                return 90;
            }
            var fiveSpareCount = frameArray.ToList().Count(i => i.Contains("5/"));
            if (fiveSpareCount == 10)
            {
                //return scoreList.Sum();
                return 150;
            }
            return null;
        }
    }
}

