using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1Practice
{
    class Multiplicationtable
    {
        static void Main(string[] args)
        {
            int i = 1;
            Console.WriteLine(" Enter a number");
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine("Multiplication Table of " + num); ;
            while(i <= 10)
            {
                Console.WriteLine($"{num} * {i} = {num * i}");
                i++;
            }
        }
    }
}
