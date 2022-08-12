using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace unittest {
    [TestClass]
    public class UnitTestCalculator : IDisposable {

        public TestContext TestContext { get; set; }

        public UnitTestCalculator () {
        }

        [AssemblyInitialize]
        public static void AssemblyInitialize (TestContext context) {
            context.WriteLine ("AssemblyInitialize");
        }

        [ClassInitialize]
        public static void ClassInitialize (TestContext context) {
            context.WriteLine ("ClassInitialize");
        }

        [TestInitialize]
        public void TestInitialize () {
            TestContext.WriteLine ("TestInitialize");
        }

        [TestCleanup]
        public void TestCleanup () {
            TestContext.WriteLine ("TestCleanup");
        }

        [ClassCleanup]
        public static void ClassCleanup () {
        }

        [AssemblyCleanup]
        public static void AssemblyCleanup () {
        }

        [TestMethod]
        public void TestAddMethod () {
            var result = ClassLib.Calculator.Add (10, 20);
            Assert.AreEqual (30, result, "Add Test Failed");
        }

        public void Dispose () {
            TestContext.WriteLine ("Dispose");
        }
    }
}