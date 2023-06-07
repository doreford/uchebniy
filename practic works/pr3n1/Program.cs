using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());

            if (a < b)
            {
                Console.WriteLine(a * 3 - 5);
            }
            else if (a == b)
            {
                Console.WriteLine(-4);
            }
            else if (a > b)
            {
                Console.WriteLine((a ^ 3 + b) / a);
                Console.ReadKey();
            }



        }
    }
}

