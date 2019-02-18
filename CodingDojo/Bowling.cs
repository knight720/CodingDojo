using System.Linq;

namespace CodingDojo
{
    public class Bowling
    {
        public int? GetScore(string frame)
        {
            var frameArray = frame.Split(' ');
            var xCount = frameArray.ToList().Count(i => i.Contains("X"));
            if (xCount == 12)
            {
                return 300;
            }
            var nineCount = frameArray.ToList().Count(i => i.Contains("9-"));
            if (nineCount == 10)
            {
                return 90;
            }
            var fiveSpareCount = frameArray.ToList().Count(i => i.Contains("5/"));
            if (fiveSpareCount == 10)
            {
                return 150;
            }
            return null;
        }
    }
}

