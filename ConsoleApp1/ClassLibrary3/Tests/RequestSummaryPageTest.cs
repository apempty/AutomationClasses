using CareRequest;
using ClassLibrary3.Pages;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetCareTests
{
    [TestFixture]
    class RequestSummaryPageTest
    {
        [Test]
        public void RequestSummaryPage()
        {
            var headerContact = "Contact Me";

            using (var driver = new ChromeDriver())
            {
                driver.Navigate().GoToUrl("http://nitro.duckdns.org/Pets.QA/index.html");

                var navigationMenuPage = new NavigationMenuPage(driver);
                navigationMenuPage.OpenContactRequestPage();

                



                var requestSummaryPage = new RequestSummaryPage(driver);

                requestSummaryPage.ContactPageHeader(headerContact);


                requestSummaryPage.SubmitCareReuestForm();





            }

        }

    }
}
