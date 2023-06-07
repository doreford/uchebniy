int[] arr = { 1, 3, 5, 7, 9 };
int minDiff = int.MaxValue;
int index1 = 0, index2 = 0;
for (int i = 0; i < arr.Length - 1; i++)
{
    for (int j = i + 1; j < arr.Length; j++)
    {
        int diff = Math.Abs(arr[i] - arr[j]);
        if (diff < minDiff)
        {
            minDiff = diff;
            index1 = i;
            index2 = j;
        }
    }
}
Console.WriteLine($"Номера ближайших элементов: {index1} и {index2}");
Console.ReadKey();