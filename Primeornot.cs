
using System;

namespace Day1Practice
{
    public class Primeornot
    {
        static bool isPrime(int n)
        {
            int count = 0;
            for (int i=1;i<=n;i++)
            {
                if(n%i==0)
                {
                    count++;
                }
            }
            if (count == 2)
            {
                return true;
            }
            else
                return false;
        }
        static void Main(String[] args)
        {
            Console.WriteLine("Enter a number to check prime number or not");
            int count = Convert.ToInt32(Console.ReadLine());
            for(int i=0;i<count;i++)
            {
                Console.WriteLine("Enter a number");
                int n = Convert.ToInt32(Console.ReadLine());

                if(isPrime(n))
                {
                    Console.WriteLine("Is a Prime number");
                }
                else if((isPrime(n))== false)
                {
                    Console.WriteLine("Not a prime number");
                }
            }
            Console.ReadLine();
        }
    }
}


    
