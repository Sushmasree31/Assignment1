using System;
namespace Day1Practice.Day2
{
    class Program01
    {
        static bool checkPrime(int numberToCheck)
        {
            if(numberToCheck == 1)
            {
                return false;
            }
            for(int i = 2; i * i <= numberToCheck; i++)
            {
                if(numberToCheck % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
        static int SumOfPrimes(int from, int to)
        {
            int sum = 0;
            for(int i = to; i >= from ;i--)
            {
                bool isPrime = checkPrime(i);
                if(isPrime)
                {
                    sum = sum + i;
                }

            }
            return sum;
        }
        public static void Main()
        {
            int l = 1, r = 20;
            Console.Write(SumOfPrimes(l, r));
        }
    }
}
