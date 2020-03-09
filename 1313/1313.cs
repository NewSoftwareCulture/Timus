using System;

namespace Timus1313
{
    class Program
    {
        static void def(int N)
        {
            if(N < 1 || N > 100)
            {
                Console.WriteLine("ERROR");
                Environment.Exit(0);
            }
        }
        static void Main(string[] args)
        {
            int N = Convert.ToInt32(Console.ReadLine());        //Сторона квадрата
            def(N);
            int[ , ] matr = new int[N , N];
            for (int i = 0; i < N; i++)                         //Заполнение матрицы
            {
                var str = Console.ReadLine().Split();
                for (int j = 0; j < N; j++)
                    matr[i, j] = Convert.ToInt32(str[j]);
            }
            int o = 0;
            for(int i = 0; i < N; i++)
            {
                int j = 0;
                int i_ = i;
                while (o == 0)
                {
                    Console.Write("{0} ", matr[i_, j]);
                    if (i_ == 0)
                        break;
                    j++;
                    i_--;
                }
            }
            for(int i = 1; i < N; i++)
            {
                int y = i;
                int x = N-1;
                while (o == 0)
                {
                    Console.Write("{0} ", matr[x, y]);             
                    y++;                                          
                    x--;                                          
                    if (y == N)                                   
                        break;
                }
            }
        }
    }
}
