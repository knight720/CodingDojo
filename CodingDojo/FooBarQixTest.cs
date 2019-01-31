using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodingDojo
{
    [TestClass]
    public class FooBarQixTest
    {
        [TestMethod]
        public void One_Is_One()
        {
            FooBarQix fooBarQix = new FooBarQix();
            string result = fooBarQix.What(1);
            Assert.AreEqual("1",result);
        }
        
        [TestMethod]
        public void Three_Is_FooFoo()
        {
            FooBarQix fooBarQix = new FooBarQix();
            string result = fooBarQix.What(3);
            Assert.AreEqual("FooFoo",result);
        }
    }
}
