using System;
using System.Collections.Generic;

namespace Timus1078
{
    class Program
    {
        static void gener_lines(ref List<int[]> line)
        {
            int N = Convert.ToInt32(Console.ReadLine());
            var buffer_1 = Console.ReadLine().Split();

            int count = 0;
            int[][] number_and_length = new int[N][];
            int[] buffer_s = { Convert.ToInt32(buffer_1[0]), Convert.ToInt32(buffer_1[1]), 1 };
            line.Add(buffer_s);
            number_and_length[0] = ;
            count++;
            for (int i = 1; i < N; i++)
            {
                var buffer = Console.ReadLine().Split();
                int[] buffer_ll = { Convert.ToInt32(buffer[0]), Convert.ToInt32(buffer[1]), 1 };
                bool flag = true;
                for (int j = 0; j < line.Count; j++)
                {
                    if (buffer_ll[0] >= line[j][0] && line[j][1] >= buffer_ll[1])                                                                           //Если новый полностью перекрывается существующим
                    {
                        count++;
                        line[j][2] = count;
                        flag = false;
                        break;
                    }
                    else if (buffer_ll[0] <= line[j][0] && line[j][1] <= buffer_ll[1]
                          && buffer_ll[0] <= line[j][1] && line[j][0] <= buffer_ll[1])                                                                      //Если новый полностью перекрывает существующий
                    {
                        line[j][0] = buffer_ll[0];
                        line[j][1] = buffer_ll[1];
                        count++;
                        line[j][2] = count;
                        flag = false;
                        break;
                    }
                    else if (buffer_ll[0] <= line[j][0] && line[j][1] >= buffer_ll[1] && line[j][0] <= buffer_ll[1])                                        //Смена левой границы
                    {
                        line[j][0] = buffer_ll[0];
                        count++;
                        line[j][2] = count;
                        flag = false;
                        break;
                    }
                    else if (buffer_ll[0] >= line[j][0] && buffer_ll[0] <= line[j][1] && line[j][1] <= buffer_ll[1])                                        //Смена правой границы
                    {
                        line[j][1] = buffer_ll[1];
                        count++;
                        line[j][2] = count;
                        flag = false;
                        break;
                    }
                }
                if (flag)
                {
                    line.Add(buffer_ll);
                }
            }
            
        }

        static void Main(string[] args)
        {
            List<int[]> line = new List<int[]>();
            gener_lines(ref line);
            for (int k = 0; k < line.Count; k++)
                Console.Write("[{0} {1}]({2}) ", line[k][0], line[k][1], line[k][2]);
            Console.WriteLine();
        }
    }
}
