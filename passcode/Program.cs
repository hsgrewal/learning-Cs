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
                Console.Write("Enter the passcode: ");
                passcode = Console.ReadLine();

                if(passcode != "secret")
                {
                    Console.WriteLine("\nNot Authenticated\n");
                }
            }
            Console.WriteLine("\nAuthenticated\n");
        }
    }
}
