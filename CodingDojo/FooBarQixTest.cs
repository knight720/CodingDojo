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
            FooBarQixAssert(1, "1");
        }
        
        [TestMethod]
        public void Three_Is_FooFoo()
        {
            FooBarQixAssert(3, "FooFoo");
        }

        public void FooBarQixAssert(int value, string expected)
        {
            string result = fooBarQix.What(value);
            Assert.AreEqual(expected,result);
            
        }
        

        [TestMethod]
        public void five_Is_BarBar()
        {
            FooBarQixAssert(5, "BarBar");
        }
        [TestMethod]
        public void Seven_Is_QixQix()
        {
            FooBarQixAssert(7, "QixQix");
        }
        [TestMethod]
        public void Nine_Is_Foo()
        {
            FooBarQixAssert(9, "Foo");
        }
        [TestMethod]
        public void Ten_Is_Bar()
        {
            FooBarQixAssert(10, "Bar");
        }
        [TestMethod]
        public void Thirteen_Is_Foo()
        {
            FooBarQixAssert(13, "Foo");
        }
        [TestMethod]
        public void Fifteen_Is_FooBarBar()
        {
            FooBarQixAssert(15, "FooBarBar");
        }
        [TestMethod]
        public void TwentyOne_Is_FooBarBar()
        {
            FooBarQixAssert(21, "FooQix");
        }
    }
}
