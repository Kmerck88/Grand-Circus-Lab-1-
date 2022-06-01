using System;

namespace Deliverable2
{
    class Program
    {
        static void Main(string[] args)
        {


    Console.WriteLine("Hello, Welcome! How many people in your party? We can only accommodate party sizes of 6 and under at this time. The cost per guest is $9.99 today.");

            int partySize = int.Parse(Console.ReadLine());

            if(partySize >  6)
            {
                Console.WriteLine("Sorry, We can only accomadate parties of 6 or less  "); 
            }

            Console.WriteLine("ok, table for " + partySize + ", Please follow me to your table");
            Console.WriteLine(" ");
            Console.WriteLine("What would you all like to drink? We have coffee and water. Coffee is $3.00, and water is on the house.");






        }
    }
}
