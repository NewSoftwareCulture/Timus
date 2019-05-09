using System;

namespace Timus1820
{
    class Program
    {
        static void def(int n, int k)                       //n - заказ, k - выполняемость
        {
            if (n < 0 || k > 1000)
            {
                Console.WriteLine("ERROR");
                Environment.Exit(0);
            }
        }
        static void Main(string[] args)
        {
            var str = Console.ReadLine().Split();
            int n = 2*Convert.ToInt32(str[0]), k = Convert.ToInt32(str[1]);         
            def(n, k);
            int res1 = n/k, res2 = n % k;                                                       
            if (res2 > 0) res2 = 1;
            int res = res1 + res2;                                                                                          
            if (n <= k)                                                             
                res++;
            Console.WriteLine(res);
        }
    }
}
