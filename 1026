using System;

namespace Timus1026
{
    class Program
    {
        public static void qsort(int[] items)
        {
            qs(items, 0, items.Length - 1);
        }
        static void qs(int[] items, int left, int right)
        {
            int i, j;
            int x, y;
            i = left; j = right;
            x = items[(left + right) / 2];
            do
            {
                while ((items[i] < x) && (i < right)) i++;
                while ((x < items[j]) && (j > left)) j--;
                if (i <= j)
                {
                    y = items[i];
                    items[i] = items[j];
                    items[j] = y;
                    i++; j--;
                }
            } while (i <= j);
            if (left < j) qs(items, left, j);
            if (i < right) qs(items, i, right);
        }
        static void Main(string[] args)
        {
            int N = Convert.ToInt32(Console.ReadLine());
            int[] data = new int[N];
            for(int i = 0; i < N; i++)
                data[i] = Convert.ToInt32(Console.ReadLine());
            Console.ReadLine();
            int K = Convert.ToInt32(Console.ReadLine());
            int[] answer = new int[K];
            for (int i = 0; i < K; i++)
                answer[i] = Convert.ToInt32(Console.ReadLine());
            qsort(data);
            for(int i = 0; i < K; i++)
                Console.WriteLine(data[answer[i]-1]);
        }
    }
}
