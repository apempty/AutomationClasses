﻿using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetcareTests
{
    class SeleniunGetMethod
    {

        public static string GetText(IWebDriver driver, string element, string elementtype)
        {

            if (elementtype == "Id")
                return driver.FindElement(By.Id(element)).Text;
            if (elementtype == "Id")
                return driver.FindElement(By.Name(element)).Text;
            else return String.Empty;

        }



    }
}
