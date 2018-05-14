using System;
using System.Collections.Generic;

namespace SocialLikes
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            // console app that adds each name supplied with Enter/Return
            // exit infinite loop when there is nothing entered on Submit
            
            var names = new List<string>();

            while (true) 
            {
                Console.WriteLine("Enter a name...");
                var input = Console.ReadLine().Trim();

                if (String.IsNullOrEmpty(input)) break;
                names.Add(input);
            }

            // just some whitespace in console
            Console.WriteLine();

            if (names.Count > 2)
                Console.WriteLine("{0}, {1} and {2} others like your post.", names[0], names[1], names.Count - 2);
            else if (names.Count == 2)
                Console.WriteLine("{0} and {1} like your post.", names[0], names[1]);
            else if (names.Count == 1)
                Console.WriteLine("{0} likes your post.", names[0]);
            else 
                Console.WriteLine();
        }
    }
}
