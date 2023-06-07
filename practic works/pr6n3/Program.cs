
int[] arr = { 1, 3, 5, 7, 9 };
int minIndex = 0, maxIndex = 0;
int minValue = arr[0], maxValue = arr[0];
for (int i = 1; i < arr.Length; i++)
{
    if (arr[i] < minValue)
    {
        minValue = arr[i];
        minIndex = i;
    }
    else if (arr[i] > maxValue)
    {
        maxValue = arr[i];
        maxIndex = i;
    }
}
int temp = arr[minIndex];
arr[minIndex] = arr[maxIndex];
arr[maxIndex] = temp;
Console.WriteLine($"Измененный массив: [{string.Join(", ", arr)}]");
Console.ReadKey();

