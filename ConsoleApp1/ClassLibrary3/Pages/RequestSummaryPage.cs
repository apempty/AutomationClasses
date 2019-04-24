using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using Shouldly;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary3.Pages
{
    class RequestSummaryPage
    {

        private IWebDriver _driver;
        private ChromeDriver driver;

        public RequestSummaryPage(IWebDriver driver)
        {
            _driver = driver;
        }

        public RequestSummaryPage(ChromeDriver driver)
        {
            this.driver = driver;
        }

        private  IWebElement ContactPageHeaderH1 => _driver.FindElement(By.XPath($"//h1"));
        private  IWebElement SubmintCareButton => _driver.FindElement(By.LinkText("care request"));
        


        


        public void  ContactPageHeader(string headerContact)
        {
            var contacHeader = ContactPageHeaderH1.Text;
            contacHeader.ShouldContainWithoutWhitespace(headerContact);


        }

        public void SubmitCareReuestForm()
        {
            SubmintCareButton.Click();

        }



    }
}
