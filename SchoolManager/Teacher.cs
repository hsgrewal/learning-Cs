using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolManager
{
    class Teacher : Member, IPayee
    {
                public string Subject;

        public void Pay()
        {
            Console.WriteLine("paying teacher");
        }
    }
}