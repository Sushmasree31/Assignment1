using System;
namespace Day1Practice
{
    class Multiplication

    {
        public static void Main(String[] args)
        {
            Console.WriteLine("Enter a Number");
            string p = Console.ReadLine();
            int num = int.Parse(p);
            Object data = 1;
            int i = (int)data;
            while(i<10)
            {
                Console.WriteLine(num + " * " + i + " = " + num * i);
                i++;
            }

        }
    }
}
