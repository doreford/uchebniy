

using System;

public class Program
{
    public static void Main()
    {
        Console.Write("Введите количество элементов: ");
        int n = int.Parse(Console.ReadLine());

        int countNonZero = 0;
        int sumLessThanTwo = 0;

        for (int i = 0; i < n; i++)
        {
            Console.Write($"Введите {i + 1}-й элемент: ");
            int element = int.Parse(Console.ReadLine());

            if (element != 0)
            {
                countNonZero++;
            }

            if (element < 2)
            {
                sumLessThanTwo += element;
            }
        }

        if (countNonZero == 0)
        {
            Console.WriteLine("Ненулевых элементов нет");
        }
        else
        {
            Console.WriteLine($"Количество ненулевых элементов: {countNonZero}");
        }

        if (sumLessThanTwo == 0)
        {
            Console.WriteLine("Элементов, значение которых меньше двух, нет");
        }
        else
        {
            Console.WriteLine($"Сумма элементов, значение которых меньше двух: {sumLessThanTwo}");
            Console.ReadKey();
        }
    }
}

