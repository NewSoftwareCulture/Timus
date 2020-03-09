using System;

namespace Timus1348
{
    class Program
    {
        static double distance_between_two_points(int Bx, int By, int Cx, int Cy, int L)
        {
            double delta_BC;
            double CB = Math.Abs(Math.Sqrt((Cx - Bx) * (Cx - Bx) + (Cy - By) * (Cy - By)));
            if (CB <= L) delta_BC = 0;
            else delta_BC = CB - L;

            return delta_BC;
        }
        static void var_4(int Ax, int Ay, int Bx, int By, int Cx, int Cy, int L)
        {
            double CC1, CA, CB, ask, delta_BC, delta_AC;
            CA = Math.Abs(Math.Sqrt((Cx - Ax) * (Cx - Ax) + (Cy - Ay) * (Cy - Ay)));
            CB = Math.Abs(Math.Sqrt((Cx - Bx) * (Cx - Bx) + (Cy - By) * (Cy - By)));
            if (CA <= L) delta_AC = 0;
            else delta_AC = CA - L;

            if (CB <= L) delta_BC = 0;
            else delta_BC = CB - L;
            //__________________________________________________________________________________________
            if ((Ax == Bx && Ax == Cx) || (Ay == By && Ay == Cy) && (Cx >= Math.Max(Ax, Bx) || Cx < Math.Min(Ax, Bx)) && (Cy >= Math.Max(Ay, By) || Cy < Math.Min(Ay, By)))
            {
                Console.WriteLine("{0:F2}", Math.Min(delta_AC, delta_BC));
                Console.WriteLine("{0:F2}", Math.Max(delta_AC, delta_BC));
                return;
            }
            //__________________________________________________________________________________________
            else if ((Cx <= Math.Max(Ax, Bx) && Cx >= Math.Min(Ax, Bx)) || (Cy <= Math.Max(Ay, By) && Cy >= Math.Min(Ay, By)))
            {
                CC1 = Math.Abs(((Ay - By) * Cx + (Bx - Ax) * Cy + (Ax * By - Bx * Ay))) / Math.Sqrt((Ay - By) * (Ay - By) + (Bx - Ax) * (Bx - Ax));

                if (CC1 <= L) ask = 0;
                else ask = CC1 - L;

                Console.WriteLine("{0:F2}", ask);

                if (CA <= L) delta_AC = 0;
                else delta_AC = CA - L;

                if (CB <= L) delta_BC = 0;
                else delta_BC = CB - L;

                Console.WriteLine("{0:F2}", Math.Max(delta_AC, delta_BC));
            }
            else
            {
                Console.WriteLine("{0:F2}", Math.Min(delta_AC, delta_BC));
                Console.WriteLine("{0:F2}", Math.Max(delta_AC, delta_BC));
                return;
            }

        }
        static void Main(string[] args)
        {
            var s1 = Console.ReadLine().Split();
            var s2 = Console.ReadLine().Split();
            int Ax = Convert.ToInt32(s1[0]);
            int Ay = Convert.ToInt32(s1[1]);
            int Bx = Convert.ToInt32(s1[2]);
            int By = Convert.ToInt32(s1[3]);
            int Cx = Convert.ToInt32(s2[0]);
            int Cy = Convert.ToInt32(s2[1]);
            int L = Convert.ToInt32(s2[2]);
            double result = 0;
            //Ввод и распределение по переменным завершено.
            //__________________________________________________________________________________________
            if (Ax == Bx && Ax == Cx && Ay == By && Ay == Cy)                                            // Случай №1. Всё в одной точке
            {
                Console.WriteLine("{0:F2}", 0);
                Console.WriteLine("{0:F2}", 0);
            }
            //__________________________________________________________________________________________
            else if (Ax == Bx && Ay == By && (Ax != Cx || Ay != Cy))                                   // Случай №2. A и B в одной точке, С в стороне
            {
                result = distance_between_two_points(Bx, By, Cx, Cy, L);
                Console.WriteLine("{0:F2}", result);
                Console.WriteLine("{0:F2}", result);
            }
            //__________________________________________________________________________________________
            else if ((Ax != Bx || Ay != By) && ((Ax == Cx && Ay == Cy) || (Bx == Cx && By == Cy)))    // Случай №3. А и В в разных точках, С совпадает с одной из них
            {
                Console.WriteLine("{0:F2}", 0);
                if (Ax == Cx && Ay == Cy)
                    result = distance_between_two_points(Bx, By, Cx, Cy, L);
                else if (Bx == Cx && By == Cy)
                    result = distance_between_two_points(Ax, Ay, Cx, Cy, L);
                Console.WriteLine("{0:F2}", result);
            }
            //__________________________________________________________________________________________
            else                                                                                        // Случай №4. А, В и С в разных точках
                var_4(Ax, Ay, Bx, By, Cx, Cy, L);
        }
    }
}
