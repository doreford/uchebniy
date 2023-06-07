using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите слова: ");
            string words = Console.ReadLine();
            string[] mula = words.Split(' ');
            int a = mula.GetLength(0);
            string temp;
            string[] array = System.IO.File.ReadAllLines(@"C:\Users\user\Desktop\2.2\1\pr11n1\bin\Debug\net6.0\pz11.txt");
            for (int i = 0; i < a; i++)
                for (int o = 0; o < a - 1; o++)
                {
                    if (mula[o].Length > mula[o + 1].Length)
                    {
                        temp = mula[o];
                        mula[o] = mula[o + 1];
                        mula[o + 1] = temp;
                    }
                }
            int count;
            for (int w = 0; w < 1000; w++)
            {
                count = 0;
                for (int j = 0; j < a; j++)
                {
                    if (w == mula[j].Length)
                        count++;
                }
                if (count != 0)
                    Console.WriteLine(count + " слово длины " + w);
            }
            foreach (string s in mula)
                Console.WriteLine(s + " - " + s.Length);
            Console.ReadKey();
        }
    }
}

