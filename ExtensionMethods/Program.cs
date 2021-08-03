using System;

namespace ExtensionMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            // методы extension должны находиться в статическом классе и сами быть статическими
            DateTime currentDateTime = DateTime.Now;
            currentDateTime.Print();
            
            // DateTime.Now.Print();
            Console.WriteLine(currentDateTime.IsDayOfWeek(DayOfWeek.Monday));

            Student student = new Student() {FirstName = "Vasya", LastName = "Pupkin"};

            string fullName = student.GetFullName();

            Console.WriteLine(fullName);

        }
    }
}