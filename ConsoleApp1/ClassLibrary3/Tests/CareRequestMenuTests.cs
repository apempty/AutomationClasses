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
using CareRequest;

namespace ClassLibrary3.Tests
{
    class CareRequestMenuTests
    
    {
        
        public void MenuTest()
        {
            using (var driver = new ChromeDriver())
            {
                driver.Navigate().GoToUrl("http://nitro.duckdns.org/Pets.QA/index.html");

                var navigationMenuPage = new NavigationMenuPage(driver);
                navigationMenuPage.OpenPicturePage();
                navigationMenuPage.OpenCareRequestPage();
            }




        }
    }
}
