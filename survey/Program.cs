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

            var data = new Data();

            // Ask first question
            Console.WriteLine("\nWhat is your name?");

            // Store answer
            data.Name = TryAnswer();

            // Continue survey
            Console.WriteLine("\nHow old are you?");
            data.Age = int.Parse(TryAnswer());

            Console.WriteLine("\nWhat month were you born in?");
            data.Month = TryAnswer();

            // Verify answers
            data.Display();

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

    class Data
    {
        public string Name;
        public int Age;
        public string Month;

        public void Display()
        {
            Console.WriteLine("\nYour name is: {0}", Name);
            Console.WriteLine("You are {0} years old.", Age);
            Console.WriteLine("You were born in {0}.", Month);

        }
    }
}
