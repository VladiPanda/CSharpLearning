using System;

namespace ExtensionMethods
{
    static class MyExtensions
    {
        public static void Print(this DateTime dateTime)
        {
            Console.WriteLine(dateTime);
        }

        public static bool IsDayOfWeek(this DateTime dateTime, DayOfWeek dayOfWeek)
        {
            return dateTime.DayOfWeek == dayOfWeek;
        }

        public static string GetFullName(this Student student)
        {
            return student.LastName + " " + student.FirstName;
        }
    }
}