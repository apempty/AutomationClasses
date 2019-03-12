using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using Shouldly;
using System;

namespace PetCareTests
{
    [TestFixture]
    public class Tutorial
    {
        [Test]
        public void Google
            ()
        {
            using (var driver = new ChromeDriver())
            {

                //Navigate to Google page
                driver.Navigate().GoToUrl("https://www.saucedemo.com");



                //Find the element UserName


                //Perform Ops
                var searchInput = driver.FindElement(By.Id("Username"));

                searchInput.SendKeys("standard_user");


                //Find the element Password


                driver.FindElements(By.Id("password"));

                searchInput.SendKeys("standard_user");




                driver.Title.ShouldBe("ASFKNF - Google Search");

            }
            
            






        }
    }
}
