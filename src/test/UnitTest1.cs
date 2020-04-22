using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ct.spike.src.test
{
    [TestClass]
    public class Sampletest
    {
        
        private static int _value = 0;

        [TestMethod]
        [Priority(0)]
        [Owner("anand")]
        [TestCategory("unit")]
        public void TestMethod1()
        {
            Assert.IsTrue(_value % 2 == 0);
            _value++;
        }

        [TestMethod]
        [Priority(0)]
        [Owner("anand")]
        [TestCategory("unit")]
        public void TestMethod2()
        {
            Assert.IsTrue(_value % 2 == 0);
            _value++;
        }

        [TestMethod]
        [Priority(0)]
        [Owner("navin")]
        [TestCategory("unit")]
        public void TestMethod3()
        {
            Assert.IsTrue(_value % 2 == 0);
            _value++;
        }

        [TestMethod]
        [Priority(0)]
        [Owner("navin")]
        [TestCategory("Integration")]
        public void TestMethod4()
        {
            Assert.IsTrue(_value % 2 == 0);
            _value++;
        }

        [TestMethod]
        [Priority(0)]
        [Owner("navin")]
        [TestCategory("Integration")]
        public void TestMethod5()
        {
            //Always pass
        }

        [TestMethod]
        [Priority(0)]
        [Owner("navin")]
        [TestCategory("Integration")]
        public void TestMethod6()
        {
            //Always pass
        }

        [TestMethod]
        [Priority(0)]
        [Owner("navin")]
        [TestCategory("Integration")]
        public void TestMethod7()
        {
            Assert.IsTrue(false, "It will always fail");
        }

        [TestMethod]
        [Priority(0)]
        [Owner("faizan")]
        [TestCategory("Integration")]
        public void TestMethod8()
        {
            Assert.IsTrue(false, "It will always fail");
        }
        
    }
}
