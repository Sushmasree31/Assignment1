using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1Practice
{
    class Average
    {
        public static void Main(String[] args)
        {

            int n, i, totalNegitive = 0, totalPositive = 0, countNegative = 0, countPositive = 0;
            double avgPositive = 0, avgNegative = 0;
            Console.WriteLine("enter 10 real numbers");
            for (i = 1; i <= 10; i++)
            {
                Console.WriteLine("Number -{0}", i);
                n = Convert.ToInt32(Console.ReadLine());

                if (n > 0)
                {
                    totalPositive += n;
                    countPositive = countPositive + 1;
                }
                else
                {
                    totalNegitive += n;
                    countNegative = countNegative + 1;
                }
            }
            avgPositive = totalPositive / countPositive;
            Console.Write("The avg of the positive numbers is : {0}\n", totalPositive);

            avgNegative = totalNegitive / countNegative;
            Console.Write("The Avg of the Negative numbers is : {0}\n", totalNegitive);
        }
    }
}