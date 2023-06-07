int z = Convert.ToInt32(Console.ReadLine());
int x = Convert.ToInt32(Console.ReadLine());
int[,] mas = new int[z, x];

for (int i = 0; i < z; i++)
{
    for (int j = 0; j < x; j++)
    {
        mas[i, j] = 10 * (j + 1);
    }
}

for (int i = 0; i < z; i++)
{
    Console.WriteLine("\n");
    for (int j = 0; j < x; j++)
    {
        Console.Write(mas[i, j] + " ");
    }
}
Console.ReadKey();
