using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int D = Convert.ToInt16(Console.ReadLine());
            int M = Convert.ToInt16(Console.ReadLine());

            switch (M)
            {
                case 1:
                    if (D == 31)
                    {
                        D = 1;
                        M += 1;
                        break;
                    }
                    else { D += 1; break; }
                case 2:
                    if (D == 28)
                    {
                        D = 1;
                        M += 1;
                        break;
                    }
                    else { D += 1; break; }
                case 3:
                    if (D == 31)
                    {
                        D = 1;
                        M += 1;
                        break;
                    }
                    else { D += 1; break; }
                case 4:
                    if (D == 30)
                    {
                        D = 1;
                        M += 1;
                        break;
                    }
                    else { D += 1; break; }
                case 5:
                    if (D == 31)
                    {
                        D = 1;
                        M += 1;
                        break;
                    }
                    else { D += 1; break; }
                case 6:
                    if (D == 30)
                    {
                        D = 1;
                        M += 1;
                        break;
                    }
                    else { D += 1; break; }
                case 7:
                    if (D == 31)
                    {
                        D = 1;
                        M += 1;
                        break;
                    }
                    else { D += 1; break; }
                case 8:
                    if (D == 29)
                    {
                        D = 1;
                        M += 1;
                        break;
                    }
                    else { D += 1; break; }
                case 9:
                    if (D == 30)
                    {
                        D = 1;
                        M += 1;
                        break;
                    }
                    else { D += 1; break; }
                case 10:
                    if (D == 31)
                    {
                        D = 1;
                        M += 1;
                        break;
                    }
                    else { D += 1; break; }
                case 11:
                    if (D == 30)
                    {
                        D = 1;
                        M += 1;
                        break;
                    }
                    else { D += 1; break; }
                case 12:
                    if (D == 31)
                    {
                        D = 1;
                        M += 1;
                        break;
                    }
                    else { D += 1; break; }

            }
            Console.WriteLine("Следующий день: {0}\nМесяц: {1}", D, M);

            Console.ReadKey();
        }





    }
}

