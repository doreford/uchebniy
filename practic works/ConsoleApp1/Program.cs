using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Введите сторону a: ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("Введите сторону b: ");
        double b = double.Parse(Console.ReadLine());
        Console.Write("Введите сторону c: ");
        double c = double.Parse(Console.ReadLine());

        double p = (a + b + c) / 2;
        double s = Math.Sqrt(p * (p - a) * (p - b) * (p - c));

        Console.WriteLine($"Площадь треугольника: {s}");
        Console.ReadKey();
    }
}

