using System;
namespace Day1Practice.Day2
{
    class Program02
    {
        public static int fibonacci(int indexvalue)
        {
            if(indexvalue <= 1)
            {
                return indexvalue;
            }
            else
            {
                return fibonacci(indexvalue - 1) + fibonacci(indexvalue - 2);
            }
        }
        public static void Main(string[] args)
        {
            int indexvalue = 17;
            Console.Write(fibonacci(indexvalue));
        }
    }
}
