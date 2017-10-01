using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
namespace test_app_build.selenium.UITest2
{

    class AppTestManager:IDisposable
    {
        IWebDriver driver = null;
        string strtrace = "";
        string output = "";
        public string Ouput
        {
            get
            {
                return output;
            }
        }
        public string Trace
        {
            get
            {
                return strtrace;
            }
        }
        public AppTestManager()
        {
            driver = new ChromeDriver();
            //driver = new InternetExplorerDriver();
            strtrace = "";
            output = "";
        }

        public void NavigateToTargetPage(string url)
        {
            driver.Navigate().GoToUrl(url);
            System.Threading.Thread.Sleep(1000);
        }

        public void EnterFirstTextBox(int ip1)
        {
            IWebElement ele1 = driver.FindElement(By.Id("a"));
            ele1.SendKeys(ip1.ToString());
        }
        public void EnterSecondTextBox(int ip2)
        {
            IWebElement ele1 = driver.FindElement(By.Id("b"));
            ele1.SendKeys(ip2.ToString());
        }
        public void ClickAddButton()
        {
            IWebElement ele3 = driver.FindElement(By.Id("c"));
            ele3.Click();
        }
        public void ClickAboutLink()
        {
            IWebElement eleLink = driver.FindElement(By.LinkText("About"));
            eleLink.Click();
        }
      
        public void ValidateThirdTextBox(int ip3)
        {
            try
            {
                IWebElement ele4 = driver.FindElement(By.Id("d"));
                output = ele4.GetAttribute("value");
                if (string.IsNullOrEmpty(output))
                {
                    output = "No value found";
                }
            }
            catch (Exception ex)
            {
                output = "Unexpected Error: " + ex.Message;
            }

            strtrace = "Expected output=" + ip3.ToString() + "; Generated output=" + output;
          
        }

        //222222222222222222222222222222222222222222222


        public void EnterFirstTextBoxAbout(int ip1)
        {
            IWebElement ele1 = driver.FindElement(By.Id("a2"));
            ele1.SendKeys(ip1.ToString());
        }
        public void EnterSecondTextBoxAbout(int ip2)
        {
            IWebElement ele1 = driver.FindElement(By.Id("b2"));
            ele1.SendKeys(ip2.ToString());
        }
        public void ClickAddButtonAbout()
        {
            IWebElement ele3 = driver.FindElement(By.Id("c2"));
            ele3.Click();
        }
        public void ClickContactLink()
        {
            IWebElement eleLink = driver.FindElement(By.LinkText("Contact"));
            eleLink.Click();
        }
        public void ValidateThirdTextBoxAbout(int ip3)
        {
            try
            {
                IWebElement ele4 = driver.FindElement(By.Id("d2"));
                output = ele4.GetAttribute("value");
                if (string.IsNullOrEmpty(output))
                {
                    output = "No value found";
                }
            }
            catch (Exception ex)
            {
                output = " Uexpected Error: " + ex.Message;
            }

            strtrace = "Expected output=" + ip3.ToString() + "; Generated output=" + output;

        }



        //333333333333333333333333333333333


        public void EnterFirstTextBoxContact(int ip1)
        {
            IWebElement ele1 = driver.FindElement(By.Id("a1"));
            ele1.SendKeys(ip1.ToString());
        }
        public void EnterSecondTextBoxContact(int ip2)
        {
            IWebElement ele1 = driver.FindElement(By.Id("b1"));
            ele1.SendKeys(ip2.ToString());
        }
        public void ClickAddButtonContact()
        {
            IWebElement ele3 = driver.FindElement(By.Id("c1"));
            ele3.Click();
        }
      
        public void ValidateThirdTextBoxContact(int ip3)
        {
            try
            {
                IWebElement ele4 = driver.FindElement(By.Id("d1"));
                output = ele4.GetAttribute("value");
                if (string.IsNullOrEmpty(output))
                {
                    output = "No value found";
                }
            }
            catch (Exception ex)
            {
                output = " Uexpected Error: " + ex.Message;
            }

            strtrace = "Expected output=" + ip3.ToString() + "; Generated output=" + output;

        }


        public void CloseTest()
        {
            Console.WriteLine(this.Trace);
            Console.WriteLine("Driver destroying");
            CloseDriver();
            Console.WriteLine("Driver destroyed");
            strtrace = "";
            output = "";
        }

        private void CloseDriver()
        {
            try
            {
                if (driver != null)
                {
                    driver.Close();
                    driver.Quit();
                }
            }
            catch (Exception ee)
            {
                //
            }
            finally
            {
                if (driver != null)
                {
                    driver.Dispose();
                    driver = null;
                }
            }
        }

        public void Dispose()
        {
            strtrace = "";
            output = "";
            this.CloseDriver();
        }
    }
}
