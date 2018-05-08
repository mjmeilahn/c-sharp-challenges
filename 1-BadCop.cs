using System;

namespace BadCop
{
    class Program
    {
        static void Main(string[] args)
        {
            // write a console app that watches the speed limit
            // and takes single digits as an input
            // assume for now the input can be converted to an integer

            // fine the user 5 demerits per digit above the speed limit
            
            var limit = 50;

            Console.WriteLine("The speed limit is " + limit + "mph");
            Console.WriteLine("Type how fast you're going, single numbers only...");

            var speed = Convert.ToInt32(Console.ReadLine());

            if (speed < limit)
            {
                Console.WriteLine("OK");   
            }
            else 
            {
                var aboveLimit = speed - limit;
                var demeritRate = 5;
                var demerits = aboveLimit / demeritRate;
                Console.WriteLine("You a fined " + demerits + " demerits!");
            }
        }
    }
}
