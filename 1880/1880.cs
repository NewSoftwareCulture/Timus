using System;

namespace Timus1880
{
    class Program
    {
        static void Main(string[] args)
        {
            int ent_1 = Convert.ToInt32(Console.ReadLine());
            var answ_1 = Console.ReadLine().Split();
            int ent_2 = Convert.ToInt32(Console.ReadLine());
            var answ_2 = Console.ReadLine().Split();
            int ent_3 = Convert.ToInt32(Console.ReadLine());
            var answ_3 = Console.ReadLine().Split();
            //-------------------------------------------------------------------------------------
            int[] mass1 = new int[ent_1];
            int[] mass2 = new int[ent_2];
            int[] mass3 = new int[ent_3];
            for (int i = 0; i < ent_1; i++)
                mass1[i] = Convert.ToInt32(answ_1[i]);
            for (int i = 0; i < ent_2; i++)
                mass2[i] = Convert.ToInt32(answ_2[i]);
            for (int i = 0; i < ent_3; i++)
                mass3[i] = Convert.ToInt32(answ_3[i]);
            //-------------------------------------------------------------------------------------
            int[] mass_1_and_2 = new int[4000];
            int[] mass_2_and_3 = new int[4000];
            int counter = 0;
            for (int i = 0; i < ent_1; i++)
                for (int j = 0; j < ent_2; j++)
                    if (mass1[i] == mass2[j])
                    {
                        mass_1_and_2[counter] = mass2[j];
                        counter++;
                    }
            counter = 0;
            for (int i = 0; i < ent_2; i++)
                for (int j = 0; j < ent_3; j++)
                    if (mass2[i] == mass3[j])
                    {
                        mass_2_and_3[counter] = mass2[i];
                        counter++;
                    }
            counter = 0;
            for (int i = 0; i < 4000; i++)
                for (int j = 0; j < 4000; j++)
                {
                    if (mass_1_and_2[i] == 0)
                        goto tap1;
                    else if (mass_1_and_2[i] == mass_2_and_3[j])
                        counter++;
                    else
                        continue;
                }
            tap1:
            Console.WriteLine("" + counter);
        }
    }
}
