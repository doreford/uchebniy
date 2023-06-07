using System;
class Program
{
    static void Main(string[] args)
    {
        int x, y;
        Console.WriteLine("x: ");
        x = int.Parse(Console.ReadLine());
        Console.WriteLine("y: ");
        y = int.Parse(Console.ReadLine());
        if ((y <= -2 * 6) & (y >= -0.1 * -3) & (y <= (7 / 6) * (17 / 6)))
        {
            Console.WriteLine("Принадлежит");
        }
        else
        {
            Console.WriteLine("Не принадлежит");
        }
    }
}


