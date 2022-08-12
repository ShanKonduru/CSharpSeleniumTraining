using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace unittest
{
    [TestClass]
    public class UnitTestCalculator
    {
        [TestMethod]
        public void TestAddMethod()
        {
            var result = ClassLib.Calculator.Add(10, 20);
            Assert.AreEqual(30, result, "Add Test Failed");
        }
    }
}
