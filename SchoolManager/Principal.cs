using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolManager
{
    class Principal : Member, IPayee
    {
        public void Pay()
        {
            Console.WriteLine("paying principal");            
        }
    }
}