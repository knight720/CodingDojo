using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodingDojo
{
    [TestClass]
    public class FizzBuzzTest
    {
        [TestMethod]
        public void three_is_fizz()
        {
            FizzBuzz fizzBuzz = new FizzBuzz();
            var result = fizzBuzz.GetResult(3);
            Assert.AreEqual("Fizz", result);
        }
    }
}
