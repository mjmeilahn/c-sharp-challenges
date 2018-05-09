using System;

namespace GuessAgain
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            // console app that generates a random number
            // user has limited attempts to guess the correct number

            var random = new Random();
            var randomOutput = random.Next(1, 5);
            var tries = 0;

            Console.WriteLine("random number is: " + randomOutput);

            while (tries < 4)
            {
                var input = Convert.ToInt32(Console.ReadLine());

                if (input != randomOutput) 
                {
                    tries++;
                    if (tries == 4) 
                    {
                        Console.WriteLine("You Lose!");
                    }
                    else 
                    {
                        Console.WriteLine("Guess Again!");
                    }
                }
                else
                {
                    Console.WriteLine("Correct!");
                    break;
                }
            }
        }
    }
}
