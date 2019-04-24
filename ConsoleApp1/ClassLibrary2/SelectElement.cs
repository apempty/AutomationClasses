using OpenQA.Selenium;

namespace PetcareTests
{
    internal class SelectElement
    {
        private IWebElement webElement;

        public SelectElement(IWebElement webElement)
        {
            this.webElement = webElement;
        }
    }
}