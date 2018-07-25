using System;

namespace survey
{
    class Program
    {
        static void Main(string[] args)
        {
            // Print message greeting user and letting them know about surey.
            Console.WriteLine("Hello! Thank you for taking our short survey.");
            Console.WriteLine("\nYou will be asked a few questions about yourself");
            Console.WriteLine("and your answers will be shown for verification.");

            // Ask first question
            Console.WriteLine("\nWhat is your name?");

            // Store answer
            var name = TryAnswer();

            // Continue survey
            Console.WriteLine("\nHow old are you?");
            var age = TryAnswer();

            Console.WriteLine("\nWhat month were you born in?");
            string month = TryAnswer();

            // Verify answers
            Console.WriteLine("\nYour name is: {0}", name);
            Console.WriteLine("You are {0} years old.", age);
            Console.WriteLine("You were born in {0}.", month);

            Console.WriteLine("\nIs that correct?");

            string ans = Console.ReadLine();

            if (ans == "yes" | ans == "Yes")
            {
                Console.WriteLine("\nGreat! Thank you for participating.");
            }
            else
            {
                Console.WriteLine("\nOh no! Something went wrong.");
                Console.WriteLine("Please try again later!");
            }
        }

        static string TryAnswer()
        {
            var answer = Console.ReadLine();

            if (answer == "")
            {
                Console.WriteLine("You didn't write anything, please try again.");
                return Console.ReadLine();
            }
            return answer;
        }
    }
}
