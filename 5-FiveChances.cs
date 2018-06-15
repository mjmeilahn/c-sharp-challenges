using System;
using System.Collections.Generic;

namespace FiveChances
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            // Console app that expects a series of unique integers
            // converts string to an integer, stores them in a list...
            // then displays the result


            var amount = 0;
            var numbers = new List<int>();

            while (amount < 5)
            {
                Console.WriteLine("Enter a unique number...");

                var input = Console.ReadLine();
                var converted = Convert.ToInt32(input);

                if (!numbers.Contains(converted))
                {
                    numbers.Add(converted);
                    amount++;   
                }
                else
                    Console.WriteLine("Try again!");
            }

            numbers.Sort();
            Console.WriteLine("Numbers:");

            foreach (var n in numbers)
                Console.WriteLine(n);
        }
    }
}
