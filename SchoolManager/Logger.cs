using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolManager
{
    class Logger
    {
        public static void Log(string msg, int priority, string system)
        {
            Console.WriteLine("System: {0}, Priority: {1}, Msg: {2}", system, priority, msg);
        }
    }
}