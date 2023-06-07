using System;

public class Program
{
    public static void Main()
    {
        Console.Write("Введите размер массива: ");
        int m = int.Parse(Console.ReadLine());

        int[] A = new int[m];

        for (int i = 0; i < m; i++)
        {
            Console.Write($"Введите элемент массива A[{i}]: ");
            A[i] = int.Parse(Console.ReadLine());
        }

        for (int i = 0; i < m; i += 2)
        {
            int minIndex = i;

            for (int j = i + 2; j < m; j += 2)
            {
                if (A[j] < A[minIndex])
                {
                    minIndex = j;
                }
            }

            if (minIndex != i)
            {
                int temp = A[i];
                A[i] = A[minIndex];
                A[minIndex] = temp;
            }
        }

        Console.Write("Отсортированный массив: ");

        for (int i = 0; i < m; i++)
        {
            Console.Write($"{A[i]} ");
            Console.ReadKey();
        }
    }
}

