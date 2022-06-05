using System;

namespace Deliverable2
{
    class Program
    {
        static void Main(string[] args)
        {

            //  Greeting guest as they arrive to the Restaurant 
            Console.WriteLine("Hello, Welcome! How many people in your party? We can only accommodate party sizes of 6 and under at this time. The cost per guest is $9.99 today.");

            int partySize = int.Parse(Console.ReadLine());

            if (partySize > 6)
            {
                Console.WriteLine("Sorry, We can only accomadate parties of 6 or less  ");
            }

            Console.WriteLine("ok, table for " + partySize + ", Please follow me to your table");
            Console.WriteLine(" ");
            Console.WriteLine("What would you all like to drink? We have coffee and water. Coffee is $3.00, and water is on the house.");


            string drink;
            int waters = 0;
            int coffee = 0;

            for (int i = 1; i <= partySize; i++)
            {
                Console.WriteLine("Ok, guest #" + i + ", coffee or water?");
                drink = Console.ReadLine();

                if (drink == "water")
                {
                    waters = waters + 1;
                    Console.WriteLine("Water, sounds greats");
                }
                else if (drink == "coffee")
                {
                    coffee = coffee + 1;
                    Console.WriteLine("Water, sounds greats");

                }
                else
                {
                    Console.WriteLine("unfountantely, Are drinks options are only water or coffee."); 

                }

            }

            Console.WriteLine("okay, so that's " + waters + "waters and " + coffee + "coffees. I will be right back, you may go your food at any time. ");

            Console.WriteLine("");


            double coffeCost = coffee * 3.00;
            double buffetCost = partySize * 9.99;
            double totalCost = buffetCost + coffeCost;

            Console.WriteLine("Here is your bill:");

            Console.WriteLine("okay, you ordered" + waters + "waters, are no charge ");

            Console.WriteLine("okay, you ordered" + coffee + "coffees, this costs $" + coffeCost + "total.");


            Console.WriteLine("The total cost is $" + totalCost + ", please do not forgot the tip: ");



        }
    }
}