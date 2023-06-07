using System;

public class Program
{
    public static void Main()
    {
        Console.Write("Введите количество товаров: ");
        int n = int.Parse(Console.ReadLine());

        int sum = 0;

        for (int i = 1; i <= n; i++)
        {
            Console.Write($"Введите стоимость товара {i}: ");
            int price = int.Parse(Console.ReadLine());

            if (price > 1000)
            {
                sum += price;
            }
        }

        Console.WriteLine($"Общая стоимость товаров, стоящих дороже 1000 рублей, равна {sum}");
        Console.ReadKey();
    }
}

