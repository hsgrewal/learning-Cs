using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolManager
{
    class Logger
    {
        public static void Log(string msg, string system, int priority = 1)
        {
            Console.WriteLine("System: {0}, Priority: {1}, Msg: {2}", system, priority, msg);
        }
    }
}