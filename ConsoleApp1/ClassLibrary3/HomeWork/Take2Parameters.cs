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
            var firstOneParametr = firstOne.Substring(1, 4);
            double  firstOneParametr1 = double.Parse(firstOneParametr);
            
            var secondOneParametr = secondOne.Substring(1, 4);
            double secondOneParametr1 = double.Parse(secondOneParametr);

            double twoPricesTotal = (firstOneParametr1 + secondOneParametr1);

        }

    }      }
