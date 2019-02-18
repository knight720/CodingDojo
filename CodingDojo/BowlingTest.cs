using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodingDojo
{
    [TestClass]
    public class BowlingTest
    {
            Bowling bowling = new Bowling();
        [TestMethod]
        public void TenStrikeIs300()
        {
            this.AssertResult("X X X X X X X X X X X X", 300);
        }
        
        [TestMethod]
        public void Ten9MissIs90()
        {
            this.AssertResult("9- 9- 9- 9- 9- 9- 9- 9- 9- 9-", 90);
        }
        
        [TestMethod]
        public void Ten5SpareIs150()
        {
            this.AssertResult("5/ 5/ 5/ 5/ 5/ 5/ 5/ 5/ 5/ 5/5", 150);
        }
        
        [TestMethod]
        public void OneStrikeIsEmpty()
        {
            this.AssertResult("X", null);
        }
        private void AssertResult(string frame, int? expected)
        {
            int? actual = bowling.GetScore(frame);
            Assert.AreEqual(expected,actual);
        }
    }
}
