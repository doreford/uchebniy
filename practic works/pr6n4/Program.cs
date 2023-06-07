
int n = 10;
int[] arr = new int[n];
int powerOfTwo = 1;
for (int i = 0; i < n; i++)
{
    arr[i] = powerOfTwo;
    powerOfTwo *= 2;
}
Console.WriteLine($"Массив степеней двойки: [{string.Join(", ", arr)}]");
Console.ReadKey();

