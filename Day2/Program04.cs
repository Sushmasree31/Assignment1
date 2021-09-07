using System;
namespace Day1Practice.Day2
{
    public class Program04
    {
        public static void Main(String[] args)
        {
            for (int row = 1; row <= 5; ++row)
            {
                for (int col = 1; col <= row; ++col)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}
