using System;

namespace Timus1014
{
    class Program
    {
        static void Main(string[] args)
        {
            long N = Convert.ToInt64(Console.ReadLine());       //Вводимое число N
            long Q = -1;                                        //Выводимое число Q
            if (N == 0)
                Q = 10;
            if (N == 1)
                Q = 1;
            if (N < 0 || N > Convert.ToInt64(Math.Pow(10, 9)))
            {
                Console.WriteLine("ERROR");
                Environment.Exit(0);
            }
            uint[] mass = new uint[100];                   //Массив с допускаемым количеством множителей
            int count = 0;
            for (uint i = 9; i > 1; i--)
            {
                for (int j = 0; j < 15; j++)
                {
                    if (N % i == 0 && N != 0)
                    {
                        mass[count] = i;
                        N = N / i;
                        count++;
                    }
                    else
                        break;
                }
            }
            if (count != 0 && N == 1)
            {
                string str = " ";
                for (int i = 15; i >= 0; i--)
                    if (mass[i] != 0)
                        str = str + mass[i].ToString();
                Q = Convert.ToInt64(str);
            }
            Console.WriteLine("" + Q);
        }
    }
}
