using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodingDojo
{
    [TestClass]
    public class FooBarQixTest
    {
            FooBarQix fooBarQix = new FooBarQix();
        [TestMethod]
        public void One_Is_One()
        {
            FooBarQixAssert("1",1);
        }
        
        [TestMethod]
        public void Three_Is_FooFoo()
        {
            FooBarQixAssert("FooFoo",3);
        }

        public void FooBarQixAssert(string expected, int value)
        {
            string result = fooBarQix.What(value);
            Assert.AreEqual(expected,result);
            
        }
        

        [TestMethod]
        public void five_Is_BarBar()
        {
            FooBarQixAssert("BarBar",5);
        }
    }
}
