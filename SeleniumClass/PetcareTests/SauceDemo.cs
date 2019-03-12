using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetcareTests
{
    [TestFixture]
   public class SauceDemo
    {
        [Test]
        public void SauceTest()
        {
            //Create the reference for our browser
            IWebDriver driver = new ChromeDriver();
            {

                driver.Navigate().GoToUrl("https://www.saucedemo.com");

                driver.FindElement(By.Id("user-name")).SendKeys("standard_user");

                driver.FindElement(By.Id("password")).SendKeys("secret_sauce");

                driver.FindElement(By.ClassName("login-button")).Click();

                driver.FindElement(By.XPath("//*[@id='inventory_container']/div/div[2]/div[3]/button")).Click();

                driver.FindElement(By.XPath("//*[@id='shopping_cart_container']/a/span")).Click();


                driver.FindElement(By.ClassName("cart_checkout_link")).Click();

                driver.Close();

            }

        }


    }
}
