using System;

namespace Day1Practice
{
    class Program4
    {
        const int max_valid_year = 9999;
        const int min_valid_year = 1100;
        static bool isLeap(int year)
        {
            return (((year % 4 == 0) && (year % 100 != 0)) || (year % 400 == 0));
        }
        static bool isValidDate(int day, int month, int year)
        {
            if (year > max_valid_year || year < min_valid_year)
                return false;
            if (month < 1 || month > 12)
                return false;
            if (day < 1 || day > 31)
                return false;
            if (month == 2)
            {
                if (isLeap(year))
                    return (day <= 29);
                else
                    return (day <= 28);
            }
            if (month == 4 || month == 6 || month == 9 || month == 11)
                return (day <= 30);
            return true;
        }
        public static void Main(string[] args)
        {
            int date = Convert.ToInt32(Console.ReadLine());
            int month = Convert.ToInt32(Console.ReadLine());
            int year = Convert.ToInt32(Console.ReadLine());
            if (isValidDate(date, month, year))
            {
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("False");
            }
            Console.ReadLine();
        }
    }
}
   