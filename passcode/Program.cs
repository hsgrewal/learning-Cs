using System;

namespace passcode
{
    class Program
    {
        static void Main(string[] args)
        {
            var passcode = "";

            while(passcode != "secret")
            {
                Console.WriteLine("Enter the passcode: ");
                passcode = Console.ReadLine();

                if(passcode != "secret")
                {
                    Console.WriteLine("The entered passcode is incorrect.");
                }
            }
            Console.WriteLine("Welcome!");
        }
    }
}
