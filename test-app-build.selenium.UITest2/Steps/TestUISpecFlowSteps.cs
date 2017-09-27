using System;
using NUnit.Framework;
using TechTalk.SpecFlow;

namespace test_app_build.selenium.UITest2.Steps
{
    [Binding]
    public class TestUISpecFlowSteps
    {
        int i = 0;
        [Given(@"I have entered (.*) into the calculator")]
        public void GivenIHaveEnteredIntoTheCalculator(int p0)
        {
            i = i + p0;
        }
        
        [When(@"I press add")]
        public void WhenIPressAdd()
        {
            i = i + 10;
        }
        
        [Then(@"the result should be (.*) on the screen")]
        public void ThenTheResultShouldBeOnTheScreen(int p0)
        {
            Assert.AreEqual(p0 + 10, i, "Not an expected result");
        }
    }
}
