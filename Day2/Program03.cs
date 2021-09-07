using System;
namespace Day1Practice.Day2
{
    class Program03
    {
        static void Main(String[] args)
        {
            string[] names = new string[7];
            Console.WriteLine("Enter the Team members names");
            for(int i = 0;i<names.Length;i++)
            {
                names[i] = Console.ReadLine();
            }
            Console.WriteLine("Names of teams");
            foreach(string name in names)
            {
                Console.Write(name + "\n");
            }
            Console.ReadLine();

        }
    }
}
