using System;

namespace Timus1506
{
    class Program
    {
        static void def(int N, int K)
        {
            if (N < 0 || N > 100 || K < 1 || K > N)
            {
                Console.WriteLine("ERROR");
                Environment.Exit(0);
            }
        }
        static void spaces(int number)                              //Форматирование
        {
            if (number > 99)                                        //Для трехзначных
                Console.Write(" " + number);
            if (number > 9 && number < 100)                         //Для двузначных
                Console.Write("  " + number);
            if (number < 10)                                        //Для однозначных
                Console.Write("   " + number);
        }
        static void Main(string[] args)
        {
            var str = Console.ReadLine().Split();
            int N = Convert.ToInt32(str[0]), K = Convert.ToInt32(str[1]);
            var s = Console.ReadLine().Split();
            int[] numb = new int[N];
            for(int i = 0; i < N; i++)
            {
                numb[i] = Convert.ToInt32(s[i]);
                if(numb[i] < 0 || numb[i] > 999)
                {
                    Console.WriteLine("ERROR");
                    Environment.Exit(0);
                }
            }
            int n = N/K;
            if (N % K != 0)
                n++;
            int[][] mass_mass = new int[n][];
            int counter = 0, counter_ = 0;
            for(int i = 0; i < n; i++)
                mass_mass[i] = new int[K];
            for(int i = 0; i < N; i++)
            {
                if (counter == n)
                {
                    counter = 0;
                    counter_++;
                }
                mass_mass[counter][counter_] = numb[i];
                counter++;
            }
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < mass_mass[i].Length; j++)
                {
                    if (mass_mass[i].Length - 1 == j && mass_mass[i][mass_mass[i].Length - 1] == 0)
                        continue;
                    else
                        spaces(mass_mass[i][j]);
                }
                Console.WriteLine("");
            }
        }
    }
}
