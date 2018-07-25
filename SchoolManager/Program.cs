using System;

namespace SchoolManager
{
    class Program
    {
        static void Main(string[] args)
        {
            var studentGrades = new int[10] { 50, 20, 30, 65, 80, 95, 97, 87, 43, 67 };

            foreach (var studentGrade in studentGrades)
            {
                Console.WriteLine(studentGrade);
            }
        }
    }
}
