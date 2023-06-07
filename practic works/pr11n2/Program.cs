using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApp168
{
    class Program
    {
        static void Main(string[] args)
        {
            string fileName = "input.txt";
            string[] lines = File.ReadAllLines(fileName);
            int n = int.Parse(lines[0]);
            int[] P = new int[n];
            int[] D = new int[n - 2];
            int max = int.MinValue;
            int min = int.MaxValue;

            for (int i = 0; i < n; i++)
            {
                P[i] = int.Parse(lines[i + 1]);
            }

            for (int i = 0; i < n; i++)
            {
                if (P[i] > max)
                {
                    max = P[i];
                }

                if (P[i] < min)
                {
                    min = P[i];
                }
            }
            int j = 0;
            for (int i = 0; i < n; i++)
            {
                if (P[i] != max && P[i] != min)
                {
                    D[j] = P[i];
                    j++;
                }
            }
            Console.WriteLine("Исходный массив: " + string.Join(", ", P));
            Console.WriteLine("Максимальный элемент: " + max);
            Console.WriteLine("Минимальный элемент: " + min);
            Console.WriteLine("Результирующий массив: " + string.Join(", ", D));
            Console.ReadKey();

        }
    }
}

