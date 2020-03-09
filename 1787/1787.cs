using System;

namespace Timus1787
{
    class Program
    {
        static void Main(string[] args)
        {
            var str = Console.ReadLine().Split();
            int k = Convert.ToInt32(str[0]), n = Convert.ToInt32(str[1]);                           //1 <= k; n <= 100
            if(k < 1 || n > 100)
            {
                Console.WriteLine("ERROR");
                Environment.Exit(0);
            }
            int[] all_cars = new int[n];
            var sum_input = Console.ReadLine().Split();
            int residue = 0;
            for (int i = 0; i < n; i++)
            {
                all_cars[i] = Convert.ToInt32(sum_input[i]);
                if (residue+all_cars[i] <= k)
                    residue = 0;
                if(all_cars[i] >= k || residue > 0)
                    residue = residue + all_cars[i] - k;
            }
            Console.WriteLine("" + residue);
        }
    }
}
