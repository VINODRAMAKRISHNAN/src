using System;
using NUnit.Framework;
using TechTalk.SpecFlow;
using test_app_build.Tests.Controllers;

namespace test_app_build.Tests.Steps
{
   
    [Binding]
    public class AsAUserIEnterTestsuiteAndTestcaseAndWillTestTheRESTAPISteps
    {
        private string strTestSuite = "";
        private string strTestCase = "";
        private string strError = "";
        [Given(@"I am using testsuite as ""(.*)""")]
        public void GivenIAmUsingTestsuiteAs(string p0)
        {
            strTestSuite = "";
            strTestCase = "";
            strError = "";

            strTestSuite = p0;
        }
        
        [Given(@"I am using testcase as  ""(.*)""")]
        public void GivenIAmUsingTestcaseAs(string p0)
        {
            strTestCase = p0;
        }
        
        [When(@"I submit the request")]
        public void WhenISubmitTheRequest()
        {
            strError = HomeControllerTest.RunSoapUItestExternal(strTestSuite, strTestCase);
        }
        
        [Then(@"the result would capture any error messages")]
        public void ThenTheResultWouldCaptureAnyErrorMessages()
        {
            //fail the test if anything fails
            if (!string.IsNullOrEmpty(strError))
            {
                Assert.Fail("Test with name '{0}' failed. {1} {2}", strTestCase, Environment.NewLine, strError);
            }
        }
    }
}
