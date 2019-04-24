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

namespace PetcareTests
{
    [TestFixture]
    class Duckdns
    {


        [Test]
        public void SauceTest()
        {
            //Create the reference for our browser
            IWebDriver driver = new ChromeDriver();
            var testPhoneNumber = "000 - 000 - 0000";
            {

                driver.Navigate().GoToUrl("http://nitro.duckdns.org/Pets.QA/index.html");

                driver.FindElement(By.LinkText("Care Request")).Click();

                driver.FindElement(By.Id("firstName")).SendKeys("Tom");

                driver.FindElement(By.Name("lastName")).SendKeys("Tomovich");


                driver.FindElement(By.ClassName("phoneNumber")).SendKeys(testPhoneNumber);

                driver.FindElement(By.XPath("//div[@id='emailContainer']/input")).SendKeys("Tomovich@gmail.com");

                driver.FindElement(By.Id("cat")).Click();


                // DropDown
                SeleniumTestMethod.SelectDropDown(driver, "catQuantity", "2", "Id");

                driver.FindElement(By.Id("visitSeveralTimesPerDay")).Click();

                SeleniumTestMethod.SelectDropDown(driver, "visitsPerDay", "4", "Id");

                driver.FindElement(By.Id("requestButton")).Click();

                Thread.Sleep(10000);

                var modal = driver.FindElement(By.ClassName("modal-body"));

                var modalText = modal.Text;

                modalText.ShouldContain("Tomovich@gmail.com");
                modalText.ShouldContain(testPhoneNumber);
                Console.WriteLine(modalText);

                driver.Quit();

            }

        }


    }
}


