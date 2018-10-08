using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConvertorGramToOunces;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void OuncesToGramsEqual()
        {
            double result= Class1.OuncesToGrams(10);
            Assert.AreEqual(283.4952,result,0.1);
        }

        [TestMethod]
        public void GramsToOuncesEqual()
        {
            double result = Class1.GramsToOunces(10);
            Assert.AreEqual(0.3527396195, result, 0.1);
        }

    }
}
