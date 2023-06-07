using System;

public class Program
{
    public static void Main()
    {
        Console.Write("Введите число A: ");
        int a = int.Parse(Console.ReadLine());

        Console.Write("Введите число B: ");
        int b = int.Parse(Console.ReadLine());

        int sum = 0;

        for (int i = a; i <= b; i++)
        {
            if (i % 3 == 0)
            {
                sum += i;
            }
        }

        Console.WriteLine($"Сумма всех целых чисел, кратных трем, в диапазоне от {a} до {b} равна {sum}");
        Console.ReadKey();
    }
}
