using System;
using NUnit.Framework;
using TechTalk.SpecFlow;

namespace SpecFlowNUT.Steps
{
    [Binding]
    public class NF1Steps
    {
        int input = 0;
        [Given(@"I have entered (.*) into the calculator")]
        public void GivenIHaveEnteredIntoTheCalculator(int p0)
        {
            input = input + p0;
        }

        [Given(@"You have entered (.*) into the calculator")]
        public void GivenYouHaveEnteredIntoTheCalculator(int p0)
        {
            input = input + p0;
        }


        [When(@"I press add")]
        public void WhenIPressAdd()
        {
            input = input + 100;
        }
        
        [Then(@"the result should be (.*) on the screen")]
        public void ThenTheResultShouldBeOnTheScreen(int p0)
        {
           
            Assert.AreEqual((p0).ToString(), input.ToString(), "Result Not matching expected value");
        }
    }
}
