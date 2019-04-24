using OpenQA.Selenium.Chrome;

namespace PetCareTests
{
    internal class RequestCatCare
    {
        private ChromeDriver driver;

        public RequestCatCare(ChromeDriver driver)
        {
            this.driver = driver;
        }
    }
}