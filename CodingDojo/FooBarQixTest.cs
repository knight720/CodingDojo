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
            string result = fooBarQix.What(1);
            Assert.AreEqual("1",result);
        }
        
        [TestMethod]
        public void Three_Is_FooFoo()
        {
            string result = fooBarQix.What(3);
            Assert.AreEqual("FooFoo",result);
        }

        public void FooBarQixAssert(string expect, int value)
        {
            
        }
    }
}
