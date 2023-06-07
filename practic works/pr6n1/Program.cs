int[] arr = { 1, 2, 3, 4, 5, 6 };
int prev = arr[0] % 2;
for (int i = 1; i < arr.Length; i++)
{
    int current = arr[i] % 2;
    if (current == prev)
    {
        Console.WriteLine(i);
        return;
    }
    prev = current;
}
Console.WriteLine(0);
Console.ReadKey();


