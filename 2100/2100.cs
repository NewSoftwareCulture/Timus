using System;

namespace Timus2100
{
    class Program
    {
        static void def(int n)
        {
            if (n < 1 || n > 20)
            {
                Console.WriteLine("ERROR");
                Environment.Exit(0);
            }
        }
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine()), res = 2;
            def(n);
            string[] str = new string[n];
            for (int i = 0; i < n; i++)
                str[i] = Convert.ToString(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                if (str[i].Length > 4 && str[i].Substring(str[i].Length - 4) == "+one")
                    res++;
                res++;
            }
            if (res == 13)
                res++;
            Console.WriteLine(res * 100);
        }
    }
}
