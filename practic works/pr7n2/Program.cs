int z = Convert.ToInt32(Console.ReadLine());
int x = Convert.ToInt32(Console.ReadLine());
int[,] mas = new int[z, x];

for (int i = 0; i < z; i++)
{
    for (int j = 0; j < x; j++)
    {
        mas[i, j] = Convert.ToInt32(Console.ReadLine());
    }
}

bool f = true;
int sum = 0;
int sum1 = 0;

for (int c = 0; c < x; c++)
{
    for (int v = 0; v < z; v++)
    {
        if (mas[v, c] < 0)
        {
            f = false;

        }
        sum1 += mas[v, c];
    }
    if (f)
    {
        sum += sum1;
    }

    sum1 = 0;
    f = true;
}

Console.WriteLine("\n" + sum);
Console.ReadKey();
