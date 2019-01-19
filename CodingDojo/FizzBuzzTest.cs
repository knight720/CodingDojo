using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodingDojo
{
    [TestClass]
    public class FizzBuzzTest 
    {
        [TestMethod]
        public void three_is_fizz()
        {
            var fizzBuzz = new FizzBuzz();
            var result = fizzBuzz.Print(3);
            Assert.AreEqual("Fizz",result);

        }

        [TestMethod]
        public void five_is_buzz()
        {
            var fizzBuzz = new FizzBuzz();
            var result = fizzBuzz.Print(5);
            Assert.AreEqual("Buzz", result);
        }

        [TestMethod]
        public void other_is_return_value()
        {
            var fizzBuzz = new FizzBuzz();
            var result = fizzBuzz.Print(1);
            Assert.AreEqual("1", result);
        }

        [TestMethod]
        public void fifteen_is_fizzbuzz()
        {
            var fizzBuzz = new FizzBuzz();
            var result = fizzBuzz.Print(15);
            Assert.AreEqual("FizzBuzz", result);
        }

        [TestMethod]
        public void v195_is_fizzbuzz()
        {
            var fizzBuzz = new FizzBuzz();
            var result = fizzBuzz.Print(195);
            Assert.AreEqual("FizzBuzz", result);
        }


        [TestMethod]
        public void v196_is_196()
        {
            var fizzBuzz = new FizzBuzz();
            var result = fizzBuzz.Print(196);
            Assert.AreEqual("196", result);
        }
    }
}
