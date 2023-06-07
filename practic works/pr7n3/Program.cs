using System.Runtime.CompilerServices;

int m = Convert.ToInt32(Console.ReadLine());
int[,] mas = new int[m, m];

for (int i = 0; i < m; i++)
{
    for (int j = 0; j < m; j++)
    {
        mas[i, j] = Convert.ToInt32(Console.ReadLine());
    }
}

int temp = 0;
int max_z = 0;
int max_x = 0;

for (int z = 0; z < m; z++)
{
    for (int x = 0; x < m; x++)
    {
        if (mas[max_x, max_z] < mas[x, z])
        {
            max_z = z;
            max_x = x;
        }
    }

    temp = mas[max_z, max_x];
    mas[max_x, max_z] = mas[(m - z - 1), z];
    mas[(m - z - 1), z] = temp;
    max_z = 0;
    max_x = 0;
}
for (int i = 0; i < m; i++)
{
    Console.WriteLine();
    for (int j = 0; j < m; j++)
    {
        Console.Write(mas[i, j] + " ");
    }
}
Console.ReadKey();
