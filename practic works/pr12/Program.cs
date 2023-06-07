using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = new int[10];
            int[,] mula = new int[5, 5];

            for (int i = 0; i < 10; i++)
            {
                Console.Write($"Введите значение a{i + 1}: ");
                a[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Console.Write($"введите значение элемента [{i}, {j}]: ");
                    mula[i, j] = int.Parse(Console.ReadLine());
                }
            }

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    for (int k = 0; k < 10; k++)
                    {
                        if (mula[i, j] == a[k])
                        {
                            mula[i, j] = 0;
                            break;
                        }
                    }
                }
            }

            Console.WriteLine("Полученная матрица: ");
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Console.Write(mula[i, j] + " ");
                }
                Console.WriteLine();
                Console.ReadKey();
            }
        }
    }
}

