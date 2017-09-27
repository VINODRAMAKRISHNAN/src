using System;
using System.Text;
using System.Collections.Generic;
using NUnit.Framework;
using test_app_build.Utility;
namespace test_app_build.Tests.Utility
{
    /// <summary>
    /// Summary description for TestUtilTest
    /// </summary>
    [TestFixture]
    public class TestUtilTest
    {
        public TestUtilTest()
        {
            //
            // TODO: Add constructor logic here
            //
        }

        private TestContext testContextInstance;

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        #region Additional test attributes
        //
        // You can use the following additional attributes as you write your tests:
        //
        // Use ClassInitialize to run code before running the first test in the class
        // [ClassInitialize()]
        // public static void MyClassInitialize(TestContext testContext) { }
        //
        // Use ClassCleanup to run code after all tests in a class have run
        // [ClassCleanup()]
        // public static void MyClassCleanup() { }
        //
        // Use TestInitialize to run code before running each test 
        // [TestInitialize()]
        // public void MyTestInitialize() { }
        //
        // Use TestCleanup to run code after each test has run
        // [TestCleanup()]
        // public void MyTestCleanup() { }
        //
        #endregion

        //[TestMethod]
        //public void Calculate()
        //{
        //    // Arrange
        //    TestUtil testutil = new TestUtil();

        //    // Act
        //    int result = testutil.Calcualte(10,20);

        //    // Assert
        //    Assert.AreEqual(40, result);
        //}
    }
}
