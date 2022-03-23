using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SeleniumTest
{
    class Program
    {
        static void Main(string[] args)
        {

         // ***************** Test Case # 1 *****************

         // create a reference for the browser
         IWebDriver driver = new ChromeDriver("C:/Users/****/Downloads/chromedriver_win32");

            driver.Navigate().GoToUrl("https://www.google.com/");
            Thread.Sleep(2000);

            // identify the Google search text box  
            IWebElement ele = driver.FindElement(By.Name("q"));

            // enter the value in the google search box  
            ele.SendKeys("javatpoint tutorials");
            Thread.Sleep(2000);

            //identify the google search button  
            IWebElement ele1 = driver.FindElement(By.Name("btnK"));

            // click on the Google search button  
            ele1.Click();
            Thread.Sleep(2000);

            driver.Close();
            Console.Write("test case ended ");
        }
    }
}
