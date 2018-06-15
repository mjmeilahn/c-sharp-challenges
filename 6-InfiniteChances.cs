using System;
using System.Collections.Generic;
using System.Linq;

namespace InfiniteChances
{
    class MainClass
    {
        public static void Main(string[] args)
        {

            // Console app that takes an infinite amount of
            // strings as input and converts to integers.
            //
            // Type "quit" to exit the infinite loop.
            // 
            // Integers are store in a List and
            // unique integers are displayed back to user.
            var numbers = new List<int>();

            while (true)
            {
                Console.WriteLine("Enter numbers or type QUIT to close.");
                var input = Console.ReadLine().ToLower().Trim();

                // exit while loop if user types quit
                if (input.Equals("quit")) break;

                var number = Convert.ToInt32(input);
                numbers.Add(number);
            }

            var output = numbers.Distinct().ToList();

            Console.WriteLine("All unique numbers:");
            foreach (var n in output)
            {
                Console.WriteLine(n);
            }
        }
    }
}
