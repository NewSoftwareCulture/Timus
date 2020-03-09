using System;

namespace Timus1525
{
    class Program
    {
        static void Main(string[] args)
        {
            long x=0, y=0, z=0;
            var str = Console.ReadLine().Split();
            long n = Convert.ToInt64(str[0]), m = Convert.ToInt64(str[1]), k = Convert.ToInt64(str[2]);              //Стороны параллелипипеда n x m x k
            string commands = Console.ReadLine();                                                                    //Инструкции
            if (commands == null) goto finish;
            long z_act = 0, y_act = 0, x_act = 0;
            long[] coords = new long[6];                                                                             // { x_max, x_min, z_max, z_min, y_max, y_min };
            for(var i = 0; i < commands.Length; i++)
            {
                switch(commands[i])
                {
                    case 'u': { ++z_act; break; }
                    case 'd': { --z_act; break; }
                    case 'l': { --x_act; break; }
                    case 'r': { ++x_act; break; }
                    case 'f': { ++y_act; break; }
                    case 'b': { --y_act; break; }
                }
                if (x_act > coords[0]) coords[0] = x_act;
                else if (x_act < coords[1]) coords[1] = x_act;

                if (z_act > coords[2]) coords[2] = z_act;
                else if (z_act < coords[3]) coords[3] = z_act;

                if (y_act > coords[4]) coords[4] = y_act;
                else if (y_act < coords[5]) coords[5] = y_act;
            }
            x = coords[0] - coords[1];
            z = coords[2] - coords[3];
            y = coords[4] - coords[5];
            if (x >= n) x = n-1;
            if (z >= m) z = m-1;
            if (y >= k) y = k-1;
            finish:
            Console.WriteLine((n - x) * (m - z) * (k - y));
        }
    }
}
