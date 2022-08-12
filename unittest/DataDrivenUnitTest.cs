using System;
using System.Data;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace unittest {
    [TestClass]
    public class DataDrivenUnitTest {

        [DataTestMethod]
        [DataRow (1, 2, 3)]
        [DataRow (2, 2, 4)]
        [DataRow (3, 2, 5)]
        [DataRow (5, 2, 7)]
        public void DataRowDrivenTestAddMethod (double operand1, double operand2, double expectedResult) {
            var result = ClassLib.Calculator.Add (operand1, operand2);
            Assert.AreEqual (expectedResult, result, "Add Test Failed");
        }

    }
}