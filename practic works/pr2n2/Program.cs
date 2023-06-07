using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Введите объем бака: ");
        double volume = double.Parse(Console.ReadLine());

        double fuelNeeded = volume * (1 - 0.6) * (1 - 0.7);

        Console.WriteLine($"Горючего потребуется: {fuelNeeded}");
        Console.ReadKey();
    }
}
