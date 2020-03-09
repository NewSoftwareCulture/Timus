using System;

namespace kursach
{
    class Program
    {
        static int PrefixFunction(string s, bool reverse = false)
        {
            int[] pi = new int[s.Length];
            //____________________________________________________________
            if (reverse)                                                  // Reverse
            {
                string str = "";
                for (int k = s.Length - 1; k >= 0; k--)
                    str += s[k];
                s = str;
            }
            //____________________________________________________________
            pi[0] = 0;                                                    // Generate massive pi
            int j, max = 0;
            for (int i = 1; i < s.Length; i++)
            {
                j = pi[i - 1];
                while (j > 0 && s[j] != s[i])
                    j = pi[j - 1];
                if (s[i] == s[j])
                    j++;
                pi[i] = j;
                if (j > max)                                              // Find pi.max
                    max = j;
            }
            Console.Write("s(" + s +  ") pi = [");
            for(int i = 0; i < pi.Length; i++)
                Console.Write(pi[i] + " ");
            Console.WriteLine("],   max = " + max);
            return s.Length - max;
        }
        static void Main(string[] args)
        {

            int k = Convert.ToInt32(Console.ReadLine());                  // INPUT k
            string s = Console.ReadLine();                                // INPUT s
            int data_count = 0, s_length = s.Length;
            s += s;
            for (int i = 1; i <= k; i++)                                  // БЛОК (1)
                data_count += PrefixFunction(s.Substring(0, i), true);    // Нахождение количества уникальных подстрок для i[1]
            Console.Write(data_count + " ");                              // Вывод i[1]
            Console.WriteLine();
            for (int i = 1; i < s_length; i++)
            {
                data_count -= PrefixFunction(s.Substring(i - 1, k));      // БЛОК (2)
                data_count += PrefixFunction(s.Substring(i, k), true);    // БЛОК (3)
                Console.Write(data_count + " ");
                Console.WriteLine();
            }
        }
    }
}
