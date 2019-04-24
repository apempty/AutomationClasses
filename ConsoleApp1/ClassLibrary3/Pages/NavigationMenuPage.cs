using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Shouldly;


namespace CareRequest
{
    public class NavigationMenuPage
    {
        private IWebDriver driver;

        public NavigationMenuPage(IWebDriver outsideDriver)
        {
            driver = outsideDriver;
        }

        private IWebElement CareRequestMenuItem => driver.FindElement(By.LinkText("Care Request"));

        private IWebElement PicturesMenuItem => driver.FindElement(By.LinkText("Pictures"));

        public void OpenCareRequestPage()
        {
            CareRequestMenuItem.Click();
        }
        public void OpenPicturePage()
        {
            PicturesMenuItem.Click();
        }

        private IWebElement ContactRequestMenuItem => driver.FindElement(By.LinkText("Contact"));

        public void OpenContactRequestPage()
        {
            ContactRequestMenuItem.Click();
        }
    }
}
        
