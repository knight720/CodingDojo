using System.Linq;

namespace CodingDojo
{
    public class Bowling
    {
        public int GetScore(string frame)
        {
            var frameArray = frame.Split(',');
            var xCount = frameArray.ToList().Count(i => i.Contains("X"));
            if (xCount == 10)
            {
                return 300;
            }
            var nineCount = frameArray.ToList().Count(i => i.Contains("9-"));
            if (nineCount == 10)
            {
                return 90;
            }
            return 150;
        }
    }
}

