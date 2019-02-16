using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodingDojo
{
    [TestClass]
    public class BowlingTest
    {
        [TestMethod]
        public void TenStrikeIs300()
        {
            Bowling bowling = new Bowling();
            int? actual = bowling.GetScore("X,X,X,X,X,X,X,X,X,XXX");
            Assert.AreEqual(300,actual);
        }
        
        [TestMethod]
        public void Ten9MissIs90()
        {
            Bowling bowling = new Bowling();
            int? actual = bowling.GetScore("9-,9-,9-,9-,9-,9-,9-,9-,9-,9-");
            Assert.AreEqual(90,actual);
        }
        
        [TestMethod]
        public void Ten5SpareIs150()
        {
            Bowling bowling = new Bowling();
            int? actual = bowling.GetScore("5/,5/,5/,5/,5/,5/,5/,5/,5/,5/5");
            Assert.AreEqual(150,actual);
        }
        
        [TestMethod]
        public void OneStrikeIsEmpty()
        {
            Bowling bowling = new Bowling();
            int? actual = bowling.GetScore("X");
            Assert.AreEqual(null,actual);
        }
    }
}
