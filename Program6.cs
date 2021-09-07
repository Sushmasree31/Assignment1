using System;

namespace Day1Practice
{
    class Program6
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the numbers");
            int num1 = Convert.ToInt32(Console.ReadLine());
            int num2 = Convert.ToInt32(Console.ReadLine());
            int num3 = Convert.ToInt32(Console.ReadLine());
            sortThreeNumbers(num1, num2, num3);
        }
        public static void sortThreeNumbers(int p, int q, int r)
        {
            int k = 0, l = 0, m = 0;
            if(p > q)
            {
                l = p;
                m = q;
            }
            else
            {
                l = q;
                m = p;
            }
            if(l > r)
            {
                k = l;
                if(m > r)
                {
                    l = m;
                    m = r;
                }
                else
                {
                    l = r;
                }
            }
            else
            {
                k = r;
            }
            Console.WriteLine(" " + k + " " + l + " " + m);
            Console.ReadLine();
        }
    }
}
