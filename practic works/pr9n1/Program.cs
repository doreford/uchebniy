string str = Console.ReadLine();
string str_test = "";

for (int i = 1; i < str.Length; i += 2)
{
    str = str.Insert(i, " ");
}

Console.Write("\n" + str);
Console.ReadKey();




