string str = Console.ReadLine();
string str_test1 = "";
string str_test2 = "";

int min = str.Length;
int max = 0;

for (int i = 0; i < str.Length; i++)
{
    if ((min < i) && (str[i] == ' '))
    {
        min = i;
    }
    if ((max < i) && (str[i] == ' '))
    {
        max = i;
    }
}

for (int i = min + 1; i < max; i++)
{
    str_test1 += str[i];
}

Console.WriteLine(str_test1);
Console.ReadKey();