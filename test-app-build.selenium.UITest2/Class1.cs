﻿//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using NUnit.Framework;
//using OpenQA.Selenium;
//using OpenQA.Selenium.Chrome;
////using NUnit.VisualStudio.TestAdapter;

//namespace test_app_build.selenium.UITest2
//{
//    public class Class1
//    {
//        public Class1()
//        {

//            //
//            // TODO: Add constructor logic here
//            //
//        }

     
//        IWebDriver driver = null;
//        string strtrace = "";
        
//        [SetUp]
//        public void InitalizeTest1()
//        {
//            Console.WriteLine("Driver created");
//            driver = new ChromeDriver();
//            //driver = new InternetExplorerDriver();
//            strtrace = "";

//        }

//        [Test]
//        public void STExecuteTest11()
//        {
//            string output = "";
//            try
//            {
//                driver.Navigate().GoToUrl("http://localhost:98/");
//                System.Threading.Thread.Sleep(1000);
//                IWebElement ele1 = driver.FindElement(By.Id("a"));
//                ele1.SendKeys("11");
//                IWebElement ele2 = driver.FindElement(By.Id("b"));
//                ele2.SendKeys("22");
//                IWebElement ele3 = driver.FindElement(By.Id("c"));
//                ele3.Click();
//                IWebElement ele4 = driver.FindElement(By.Id("d"));

//                output = ele4.GetAttribute("value");
//                if (string.IsNullOrEmpty(output))
//                {
//                    output = "No value found";
//                }

//                //Console.WriteLine("Expected output=1122");
//                //Console.WriteLine("Generated output=" + output);
               
//            }
//            catch (Exception ex)
//            {
//                output = "STExecuteTest1 Uexpected Error: " + ex.Message;
//            }
//            strtrace = "Expected output=1122; Generated output=" + output;
//            Assert.That("1122", Is.EqualTo(output), output);
           
        


//        }

//        [Test]
//        public void STExecuteTest22()
//        {
//            string output = "";
//            try
//            {
//                driver.Navigate().GoToUrl("http://localhost:98/Home/About");
//                System.Threading.Thread.Sleep(1000);
//                IWebElement ele1 = driver.FindElement(By.Id("a2"));
//                ele1.SendKeys("44");
//                IWebElement ele2 = driver.FindElement(By.Id("b2"));
//                ele2.SendKeys("55");
//                IWebElement ele3 = driver.FindElement(By.Id("c2"));
//                ele3.Click();
//                IWebElement ele4 = driver.FindElement(By.Id("d2"));

//                output = ele4.GetAttribute("value");
//                if (string.IsNullOrEmpty(output))
//                {
//                    output = "No value found";
//                }
//                //Console.WriteLine("Expected output=4455");
//                //Console.WriteLine("Generated output=" + output);


//            }
//            catch (Exception ex)
//            {
//                output = "STExecuteTest2 Uexpected Error: " + ex.Message;
//            }
//            strtrace = "Expected output=4455; Generated output=" + output;
//            Assert.That("4455", Is.EqualTo(output), output);
          
//        }


//        [Test]
//        public void STExecuteTest33()
//        {
//            string output = "";
//            try
//            {
//                driver.Navigate().GoToUrl("http://localhost:98/Home/Contact");
//                System.Threading.Thread.Sleep(1000);

//                IWebElement ele1 = driver.FindElement(By.Id("a1"));
//                ele1.SendKeys("77");
//                IWebElement ele2 = driver.FindElement(By.Id("b1"));
//                ele2.SendKeys("88");
//                IWebElement ele3 = driver.FindElement(By.Id("c1"));
//                ele3.Click();
//                IWebElement ele4 = driver.FindElement(By.Id("d1"));

//                output = ele4.GetAttribute("value");
//                if (string.IsNullOrEmpty(output))
//                {
//                    output = "No value found";
//                }
               
//                //Console.WriteLine("Expected output=7788");
//                //Console.WriteLine("Generated output=" + output);
//                strtrace = "Expected output=7788; Generated output=" + output;
//                Assert.That("7788", Is.EqualTo(output));
//            }
//            catch (Exception ex)
//            {
//                output = "STExecuteTest3 Uexpected Error: " + ex.Message;
//            }

//            Assert.That("7788", Is.EqualTo(output), output);
           
//        }


//        [TearDown]
//        public void CloseTest1()
//        {
//            Console.WriteLine(strtrace);
//            Console.WriteLine("Driver destroying");
//            CloseDriver();
//            Console.WriteLine("Driver destroyed");
//        }

//        private void CloseDriver()
//        {
//            try
//            {
//                if (driver != null)
//                {
//                    driver.Close();
//                    driver.Quit();
//                }
//            }
//            catch (Exception ee)
//            {
//                //
//            }
//            finally
//            {
//                if (driver != null)
//                {
//                    driver.Dispose();
//                }
//            }
//        }
//    }

    
//}
