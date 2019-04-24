using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetCareTests.HomeWork
{

    public class Take2Parameters
    {
        public void Take2ParametersTest(string firstOne, string secondOne)
        {
            var firstOneParametr = firstOne.Substring(0, 1);
            int firstOneParametr1 = int.Parse(firstOneParametr);
            
            var secondOneParametr = secondOne.Substring(0, 1);
            int secondOneParametr1 = int.Parse(secondOneParametr);

            int twoPricesTotal = (firstOneParametr1 + secondOneParametr1);

        }

    }      }
