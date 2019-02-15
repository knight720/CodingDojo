using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodingDojo
{
    [TestClass]
    public class BowlingTest
    {
        [TestMethod]
        public void TenXIs300()
        {
            Bowling bowling = new Bowling();
            int actual = bowling.GetScore("X,X,X,X,X,X,X,X,X,XXX");
            Assert.AreEqual(300,actual);
        }
    }
}
