using System;

namespace Timus1025
{
    class Program
    {
        static void Main(string[] args)
        {
            int numb = Convert.ToInt32(Console.ReadLine());
            int[] group = new int[numb];
            var str = Console.ReadLine().Split();
            for (int i = 0; i < numb; i++)
                group[i] = Convert.ToInt32(str[i]);
            Array.Sort(group);
            int sum = 0;
            for(int i = 0; i < numb-numb/2; i++)
                sum += group[i] - group[i] / 2;
            Console.WriteLine("" + sum);
        }
    }
}
