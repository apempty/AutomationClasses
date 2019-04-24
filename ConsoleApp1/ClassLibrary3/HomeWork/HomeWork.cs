using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetCareTests.HomeWork
{
    [TestFixture]
    public class HomeWork
    {

        [Test]

        public void firstOneBody()
        {
            string firstOne = "$73.54";
            string secondOne = "$26.46";


            using (var driver = new ChromeDriver())

            {
                var take2Parameters = new Take2Parameters();

                take2Parameters.Take2ParametersTest(firstOne, secondOne);


            }
        }



        


        


    
    }
}
