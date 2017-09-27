using System;
using NUnit.Framework;
using TechTalk.SpecFlow;
using ReadyAPI.TestServer.Client;
using ReadyAPI.TestServer.Client.TestSteps;
using ReadyAPI.TestServer.Client.TestSteps.RestRequest;
using IO.Swagger.Model;
using ReadyAPI.TestServer.Client.Execution;
using ReadyAPI.TestServer.Client.Assertions;
using RestSharp;

namespace test_app_build.readyapi.tests.Steps
{
    [Binding]
    public class Test1Steps
    {
      
        DataFormat x = RestSharp.DataFormat.Json;

        Table tblinputreq = null;
        TestRecipe recipe = null;

        [Given(@"I have provided REST API request input student entity as in the below table:")]
        public void GivenIHaveProvidedRESTAPIRequestInputStudentEntityAsInTheBelowTable(Table inputtable)
        {
            tblinputreq = inputtable;
        }

        [Then(@"I execute POST API and the response result should be validated against the following table:")]
        public void ThenIExecutePOSTAPIAndTheResponseResultShouldBeValidatedAgainstTheFollowingTable(Table outputvalidationtable)
        {
            int maxrowcount = 0;
            string reportresult = "FINISHED";
            string msg = "";
            if (tblinputreq.RowCount > 0 && outputvalidationtable.RowCount > 0)
            {
                if (tblinputreq.RowCount == outputvalidationtable.RowCount)
                {
                    maxrowcount = tblinputreq.RowCount;
                }
                else if (tblinputreq.RowCount < outputvalidationtable.RowCount)
                {
                    maxrowcount = tblinputreq.RowCount;
                }
                if (outputvalidationtable.RowCount < tblinputreq.RowCount)
                {
                    maxrowcount = tblinputreq.RowCount;
                }
            }


            for (int i = 0; i < maxrowcount; i++)
            {
                TableRow r0 = outputvalidationtable.Rows[i];
                recipe = TestRecipeBuilder.NewTestRecipe()/* Create a new test recipe. */
               .AddStep(TestSteps.RestRequest() /* Create a new test step (REST Request). */
                     .Post("http://testapivinod.azurewebsites.net/api/values") /* Specify the GET method type and a request endpoint. */
                                                                               /* Parameter string. */
                                                                               /* Parameter string. */
                     .WithMediaType("application/json")
                     .WithRequestBody(tblinputreq.Rows[i]["inputentity"])
                     .AddAssertion(Assertions.JsonPathContent("$['id']", r0["St-id"])) /* Create a JsonPath Content assertion. The required assertion parameters are specified in the assertion constructor.*/
                     .AddAssertion(Assertions.JsonPathContent("$['name']", r0["St-name"]).AllowWildcards())
                     .AddAssertion(Assertions.JsonPathContent("$['age']", r0["St-age"]))
                     .AddAssertion(Assertions.JsonPathContent("$['status']", r0["St-status"]))
                     .AddAssertion(Assertions.JsonPathContent("$['stAddress']['street']", r0["Ad-street"]))
                     .AddAssertion(Assertions.JsonPathContent(" $['stAddress']['zip']", r0["Ad-zip"]))
               )
               .BuildTestRecipe(); /* Important: build a test recipe for execution. */
                RecipeExecutor recipeExecutor = new RecipeExecutor(Scheme.HTTP, "testserver.readyapi.io", 8080); /* Create the runner object and specifies the TestServer address for it. */
                recipeExecutor.AddExecutionListener(new MyExecutionListener());                                                                          //RecipeExecutor recipeExecutor = new RecipeExecutor("MyTestServer", 8443); /* Create the runner object and specifies the TestServer address for it. */
                recipeExecutor.SetCredentials("demoUser", "demoPassword"); /* Add basic authentication for requests to the TestServer. */
                Execution execution = recipeExecutor.ExecuteRecipe(recipe);
               
               
                if (execution != null)
                {
                    if (execution.CurrentReport != null && execution.CurrentReport.Status == "FAILED")
                    {
                        reportresult = "FAILED";
                        msg = msg + " \n INPUT TABLE ROW: " + (i+1).ToString() + ";" + String.Join(" || ", execution.CurrentReport.TestSuiteResultReports[0].TestCaseResultReports[0].TestStepResultReports[0].Messages.ToArray());

                    }
                }
                else
                {
                    reportresult = "FAILED";
                    msg = msg = msg + " \n INPUT TABLE ROW: " + (i + 1).ToString() +  "System problem, execution failed";
                   
                }
            }
            Assert.AreEqual("FINISHED", reportresult, msg, null);
        }
    }

    public class MyExecutionListener : IExecutionListener
    {
        public void ErrorOccurred(Exception exception)
        {
            System.Console.WriteLine("Request sent: " + exception.ToString());
            System.Diagnostics.Debug.WriteLine("Request sent: " + exception.ToString());
        }

        public void ExecutionFinished(ProjectResultReport projectResultReport)
        {
            System.Console.WriteLine("Request sent: " + projectResultReport.ToString());
            System.Diagnostics.Debug.WriteLine("Request sent: " + projectResultReport.ToString());
        }

        public void RequestSent(ProjectResultReport projectResultReport)
        {
            System.Console.WriteLine("Request sent: " + projectResultReport.ToString());
            System.Diagnostics.Debug.WriteLine("Request sent: " + projectResultReport.ToString());
        }
    }
}
