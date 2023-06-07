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
            sum += i * i;
        }

        Console.WriteLine($"Сумма квадратов чисел от {a} до {b} равна {sum}");
        Console.ReadKey();
    }
}
