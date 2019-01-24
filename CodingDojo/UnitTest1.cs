using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodingDojo
{
    [TestClass]
    public class FizzBuzzTest
    {
        FizzBuzz fizzBuzz = new FizzBuzz();
        [TestMethod]
        public void three_is_fizz()
        {
            AssertResut("Fizz", 3);
        }

        private void AssertResut(string exptct, int value)
        {
            var result = fizzBuzz.GetResult(value);
            Assert.AreEqual(exptct, result);
        }

        [TestMethod]
        public void five_is_buzz()
        {
            AssertResut("Buzz", 5);
        }
        
        [TestMethod]
        public void nothing_is_value()
        {
            AssertResut("4", 4);
        }
    }
}
