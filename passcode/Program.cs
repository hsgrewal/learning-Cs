using System;

namespace passcode
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the passcode: ");
            var passcode = Console.ReadLine();

            if(passcode == "secret")
            {
                Console.WriteLine("Welcome!");
            }
            else
            {
                Console.WriteLine("The entered passcode is incorrect.");
            }
        }
    }
}
