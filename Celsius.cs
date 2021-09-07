using System;
namespace Day1Practice
{
    class Celsius
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the amount of celsius:");
            int celsius = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("kelvin = {0}", celsius + 273);
            Console.WriteLine("Farenheit = {0}", celsius * 18 / 10 + 32);
        }
    }
}
