using System;
using System.Collections.Generic;
using System.Configuration;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Web.Mvc;

using NUnit.Framework;
using test_app_build;
using test_app_build.Controllers;

namespace test_app_build.Tests.Controllers
{
    [TestFixture]
    public class HomeControllerTest
    {
        [Test]
        public void Index()
        {
            var x = 0;
            // Arrange
            HomeController controller = new HomeController();

            // Act
            ViewResult result = controller.Index() as ViewResult;

            
          
            Assert.IsNotNull(result);
        }

        [Test]
        public void About()
        {
            // Arrange
            HomeController controller = new HomeController();

            // Act
            ViewResult result = controller.About() as ViewResult;
         
            // Assert
            Assert.AreEqual("Your application description page.", result.ViewBag.Message);
        }

        [Test]
        public void Contact()
        {
            // Arrange
            HomeController controller = new HomeController();

            // Act
            ViewResult result = controller.Contact() as ViewResult;

         
           Assert.IsNotNull(result);
        }


        //[Test]
        //public void TestSOPURLXML()
        //{
        //    string testSuiteName = "TestSuite 1";
        //    string testCaseName = "TestCase 2";
        //    string errorMessage = RunSoapUItest(testSuiteName, testCaseName);
        //    //fail the test if anything fails
        //    if (!string.IsNullOrEmpty(errorMessage))
        //    {
        //        Assert.Fail("Test with name '{0}' failed. {1} {2}", testCaseName, Environment.NewLine, errorMessage);
        //    }
        //}


        private string RunSoapUItest(string testSuiteName, string testCaseName)
        {
            var errorBuilder = new StringBuilder();

            string filepath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);

            var soapprojectxmlfile = filepath + @"\" + ConfigurationManager.AppSettings["SoapUIProjectXMLFileName"];
            var soapuitestRunnerbatchFile = ConfigurationManager.AppSettings["SoapUITestRunnerBatchFile"];

            Console.WriteLine(soapprojectxmlfile);
            Console.WriteLine(soapuitestRunnerbatchFile);
            //working cmd
            // var arguments1 = @"C:\progra~1\SmartBear\ReadyAPI-2.1.0\bin\testrunner.bat -s"TestSuite1" -c"TestCase 1" F:\AgenTFS\vinod-test-newcode\src\test-app-build.Tests\REST-Project-1-readyapi-project-grid.xml";
            // "F:\Program Files (x86)\SmartBear\SoapUI-5.3.0\bin\testrunner.bat" -s"TestSuite 1" -c"TestCase 2" F:\AAA-SOAPUI\SOAPUI\REST-Project-1-soapui-project-new.xml

            string strtestcase = "";
            if (!string.IsNullOrEmpty(testCaseName))
            {
                strtestcase= "-c\"" + testCaseName + "\" ";
            }

            string strtestsuite = "";
            if (!string.IsNullOrEmpty(testSuiteName))
            {
                strtestsuite = "-s\"" + testSuiteName + "\" ";
            }

            var arguments = "/C " + soapuitestRunnerbatchFile + " " + strtestsuite + " " + strtestcase + soapprojectxmlfile;
            Console.WriteLine(arguments);

            var errorMessage = "";
            bool errorfound = false;
            //start a process and hook up the in/output
            using (var process = new Process())
            {

                ProcessStartInfo startInfo = new ProcessStartInfo();
                startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
                startInfo.UseShellExecute = false;
                startInfo.FileName = "cmd.exe";
                // startInfo.WorkingDirectory = soapHome;
                startInfo.Arguments = arguments;
                startInfo.ErrorDialog = false;
                startInfo.RedirectStandardError = true;
                startInfo.RedirectStandardOutput = true;
                startInfo.CreateNoWindow = true;
                startInfo.ErrorDialog = true;

                process.StartInfo = startInfo;
                process.EnableRaisingEvents = true;

                //process.OutputDataReceived += (sender, args) =>
                //{
                //    Console.WriteLine(args.Data);

                //    if (args != null && args.Data != null)
                //    {
                //        errorBuilder.AppendLine(args.Data);
                //    }
                //};

                //store the errors in a stringbuilder

                process.ErrorDataReceived += (sender, args) =>
                {
                    if (args != null && args.Data != null && args.Data.Contains("java.lang.Exception"))
                    {
                        errorfound = true;
                    }

                    if (args != null && args.Data != null && errorfound)
                    {
                        errorBuilder.AppendLine(args.Data);
                    }
                    
                };
            
                process.Start();
                process.BeginOutputReadLine();
                process.BeginErrorReadLine();
                var procBuilder = new StringBuilder();
                //while (!process.HasExited)
                //{
                //    int count = 1;
                //    procBuilder.AppendLine("Processing: " + count);
                //}

                process.WaitForExit();

                process.Close();

            }
            errorfound = false;
            errorMessage = errorBuilder.ToString();
            return errorMessage;
        }


        public static string RunSoapUItestExternal(string testSuiteName, string testCaseName)
        {
            var errorBuilder = new StringBuilder();

            string filepath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);

            var soapprojectxmlfile = filepath + @"\" + ConfigurationManager.AppSettings["SoapUIProjectXMLFileName"];
            var soapuitestRunnerbatchFile = ConfigurationManager.AppSettings["SoapUITestRunnerBatchFile"];

            Console.WriteLine(soapprojectxmlfile);
            Console.WriteLine(soapuitestRunnerbatchFile);
            //working cmd
            // var arguments1 = @"C:\progra~1\SmartBear\ReadyAPI-2.1.0\bin\testrunner.bat -s"TestSuite1" -c"TestCase 1" F:\AgenTFS\vinod-test-newcode\src\test-app-build.Tests\REST-Project-1-readyapi-project-grid.xml";
            // "F:\Program Files (x86)\SmartBear\SoapUI-5.3.0\bin\testrunner.bat" -s"TestSuite 1" -c"TestCase 2" F:\AAA-SOAPUI\SOAPUI\REST-Project-1-soapui-project-new.xml

            string strtestcase = "";
            if (!string.IsNullOrEmpty(testCaseName))
            {
                strtestcase = "-c\"" + testCaseName + "\" ";
            }

            string strtestsuite = "";
            if (!string.IsNullOrEmpty(testSuiteName))
            {
                strtestsuite = "-s\"" + testSuiteName + "\" ";
            }

            var arguments = "/C " + soapuitestRunnerbatchFile + " " + strtestsuite + " " + strtestcase + soapprojectxmlfile;
            Console.WriteLine(arguments);

            var errorMessage = "";
            bool errorfound = false;
            //start a process and hook up the in/output
            using (var process = new Process())
            {

                ProcessStartInfo startInfo = new ProcessStartInfo();
                startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
                startInfo.UseShellExecute = false;
                startInfo.FileName = "cmd.exe";
                // startInfo.WorkingDirectory = soapHome;
                startInfo.Arguments = arguments;
                startInfo.ErrorDialog = false;
                startInfo.RedirectStandardError = true;
                startInfo.RedirectStandardOutput = true;
                startInfo.CreateNoWindow = true;
                startInfo.ErrorDialog = true;

                process.StartInfo = startInfo;
                process.EnableRaisingEvents = true;

                //process.OutputDataReceived += (sender, args) =>
                //{
                //    Console.WriteLine(args.Data);

                //    if (args != null && args.Data != null)
                //    {
                //        errorBuilder.AppendLine(args.Data);
                //    }
                //};

                //store the errors in a stringbuilder

                process.ErrorDataReceived += (sender, args) =>
                {
                    if (args != null && args.Data != null && args.Data.Contains("java.lang.Exception"))
                    {
                        errorfound = true;
                    }

                    if (args != null && args.Data != null && errorfound)
                    {
                        errorBuilder.AppendLine(args.Data);
                    }

                };

                process.Start();
                process.BeginOutputReadLine();
                process.BeginErrorReadLine();
                var procBuilder = new StringBuilder();
                //while (!process.HasExited)
                //{
                //    int count = 1;
                //    procBuilder.AppendLine("Processing: " + count);
                //}

                process.WaitForExit();

                process.Close();

            }
            errorfound = false;
            errorMessage = errorBuilder.ToString();
            return errorMessage;
        }

    }
    
}
