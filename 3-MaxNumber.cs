using System;

namespace Mosh8
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            // console app that sorts a list of numbers
            // that are separated by commas.


            Console.WriteLine("Enter a list of numbers separated by a comma");
            var numbers = Console.ReadLine().Trim().Split(',');

            // assign the first number as max
            var max = Convert.ToInt32(numbers[0]);

            // re-arrange the max number through iteration
            foreach (var str in numbers)
            {
                var number = Convert.ToInt32(str);
                if (number > max)
                {
                    max = number;
                }
            }

            Console.WriteLine("The Max number is: " + max);
        }
    }
}
