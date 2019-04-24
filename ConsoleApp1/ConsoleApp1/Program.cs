using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)

        {
           
            Other();
            
        }
            static void Hello()
            {

                string hello = "hello world";
                string world = "world ho";
                var result = hello + world;
                Console.WriteLine(hello + " " + world);

                var result1 = result.Length;
                Console.WriteLine(result1);

                Console.ReadLine();

                string sentence1 = "The quick brown fox jumps over the lazy dog";
                Console.WriteLine(sentence1);

                var result2 = sentence1.Replace("fox", "cat").Replace("dog", "frog");

                Console.WriteLine(result2);

                Console.ReadLine();

                string sentence2 = "  The Quick BroWn FoX!";

                Console.WriteLine(sentence2.ToLower());

                Console.ReadLine();

                Console.WriteLine(sentence2.Trim());

                Console.ReadLine();
            }

        //Coffeeee
        static void Coffeeee()
        {
            string priceCoffe = "$3";
            int month = 30;


            var priceNew = priceCoffe.Remove(0, 1);
            Console.ReadLine();

            int x = int.Parse(priceNew) * month;
            Console.WriteLine(x);
            Console.ReadLine();


            // COFFEEE MOVIE   
            string name = "Artem";
            string coffe = "Latte";
            string movie = "Movie";


            string time = DateTime.Now.ToString().Remove(0, 17);
            Console.WriteLine(time);

            string result = time == "AM" ? $"Good morning {name}! Have you had a cup of {coffe} yet?" : $"Good Afternoon, {name} Let’s watch {movie} tonight!";
            Console.WriteLine(result);
            Console.ReadLine();

        }


        //var s1 = "somelongstring";
        //Console.WriteLine(s1.Substring(2, 4));
        //Console.WriteLine(s1.Substring(2));
        //Console.ReadLine();





        static void Numbers1()
        {

            string oneNumber = Console.ReadLine();

            int result = int.Parse(oneNumber);

            if (result >= 0)
            {

                Console.WriteLine("This is a positive number");
            }
            else if (result < 0)
            {
                Console.WriteLine("This is a negative number");
            }

            else
            {
                Console.WriteLine("Wrong!!!!");
            }


            Console.ReadLine();

            Console.Write("How old are you?:  ");
            string ageVoting = Console.ReadLine();
            int ageVoitingResult = int.Parse(ageVoting);

            if (ageVoitingResult >= 18)
            {
                Console.WriteLine("Yes, You can voting");
            }

            else if (ageVoitingResult < 18)
            {
                int howMuch = (18 - ageVoitingResult);
                Console.WriteLine($"You need wait {howMuch} years!");
            }
            else
            {
                Console.WriteLine("Wrong!");
            }

            Console.ReadLine();

            Console.Write("Day of week:  ");

            string dayWeek = Console.ReadLine();
            int dayWeekResult = int.Parse(dayWeek);
            if (dayWeekResult == 1)
            {
                Console.WriteLine("Sunday");
            }
            else if (dayWeekResult == 2)
            {
                Console.WriteLine("Monday");
            }
            else if (dayWeekResult == 3)
            {
                Console.WriteLine("Tuesday");
            }
            else if (dayWeekResult == 4)
            {
                Console.WriteLine("Wednesday");
            }
            else if (dayWeekResult == 5)
            {
                Console.WriteLine("Thursday");
            }
            else if (dayWeekResult == 6)
            {
                Console.WriteLine("Friday");
            }
            else if (dayWeekResult == 7)
            {
                Console.WriteLine("Suterday");
            }

            else
            {
                Console.WriteLine("Wrong!");
            }
            Console.ReadLine();
        }









        static void Other()
        {

            Console.Write("Enter number: ");
            string number1 = Console.ReadLine();
            int mnumber1Result = int.Parse(number1);
            if (mnumber1Result >= 0)
            {
                Console.WriteLine(mnumber1Result);
            }
            else
            {
                Console.WriteLine(mnumber1Result - (2 * mnumber1Result));
            }

            Console.ReadLine();




            Console.Write("Enter value: ");
            string value = Console.ReadLine();
            Console.Write("Enter value: ");
            string value2 = Console.ReadLine();
            Console.Write("Enter value: ");
            string value3 = Console.ReadLine();
            int value1Result = int.Parse(value);
            int value2Result = int.Parse(value2);
            int value3Result = int.Parse(value3);
            if (value1Result == value2Result && value1Result == value3Result)
            {
                Console.WriteLine("All numbers are equal");

            }
            else if (value1Result == value2Result | value1Result == value3Result | value2Result == value3Result)
            {
                Console.WriteLine("Neither all are equal or different");

            }

            else if (value1Result != value2Result && value1Result != value3Result && value2Result != value3Result)
            {
                Console.WriteLine("All numbers are different");




            }
            Console.ReadLine();






            Console.Write("Enter 10 digit phone number: ");
            string testString = Console.ReadLine();
            Console.WriteLine("You entered '{0}'", testString);
            Console.WriteLine("Now we will convert to (xxx)-xxx-xxxx");

            string phone1 = String.Format("{0:(###) ###-####}", Convert.ToInt64(testString));
            Console.WriteLine(phone1);
            //testString = "(" + testString.Substring(0, 3) + ")-" + testString.Substring(3, 3) + "-" + testString.Substring(6);
            // Console.WriteLine("Convert number:" + testString);
            Console.ReadLine();

            //string phone1 = String.Format("{0:(###) ###-####}", testString);

        }
        

        

        }

        }
    

    