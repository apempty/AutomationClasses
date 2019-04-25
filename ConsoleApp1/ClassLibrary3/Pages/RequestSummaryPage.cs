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
   public class RequestSummaryPage
    {

        private IWebDriver _driver;
      

        public RequestSummaryPage(IWebDriver driver)
        {
            _driver = driver;
        }

     
        private  IWebElement ContactPageHeaderH1 => _driver.FindElement(By.XPath("//h1"));
        private  IWebElement SubmintCareButton => _driver.FindElement(By.LinkText("care request"));
        


        


        public string  ContactPageHeader()
        {
           return ContactPageHeaderH1.Text;
           


        }

        public void SubmitCareReuestForm()
        {
            SubmintCareButton.Click();

        }



    }
}
