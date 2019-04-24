using OpenQA.Selenium;

namespace ClassLibrary3
{
    internal interface IWebDriver
    {
        IWebElement FindElement(By by);
    }
}