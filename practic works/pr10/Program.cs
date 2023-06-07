using System;

namespace ConsoleApp4
{
    class Program
    {

        public static void Method()
        {
            Console.Write("Введите слова: ");
            string s = Console.ReadLine();
            string[] mass = s.Split();
            int max = -1;
            for (int i = 0; i < mass.Length; i++)
            {
                if (mass[i].Length > max)
                {
                    max = mass[i].Length;
                }
            }
            Console.WriteLine($"Количество слов: {mass.Length}");
            Console.Write("Самое длинное слово: ");
            for (int i = 0; i < mass.Length; i++)
            {
                if (mass[i].Length == max)
                {
                    Console.Write(mass[i] + " ");
                }
            }
        }

        public static void NoMethod()
        {

        }
        static void Main(string[] args)
        {
            string s = "";
            while (s != "0" || s != "1")
            {
                Console.WriteLine("Выберите 1 чтобы запустить метод , Нажмите 2 чтобы закрыть программу.");
                s = Console.ReadLine();
                if (s == "1")
                {
                    Method();
                }
                else if (s == "2")
                {
                    return;
                }
                else
                    Console.WriteLine("Введите 1 или 2.");
                Console.ReadKey();
            }
        }
    }
}

