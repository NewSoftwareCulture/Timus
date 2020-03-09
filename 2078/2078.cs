using System;

namespace Timus2078
{
    class Program
    {
        static void Main(string[] args)
        {
            var obj = Console.ReadLine().Split();
            int min = 0, max = 0;
            int[] mass = new int[10];
            for(int i = 0; i < 10; i++)
                mass[i] = Convert.ToInt32(obj[i]);          //Массив с фреймами
            //______________________________________________________________________________________________________
            for (int i = 0; i < 10; i++)
                min += mass[i];                          //Подсчет минимальных очков
            //______________________________________________________________________________________________________
            for (int i = 0; i < 10; i++)                 //Подсчет максимальных очков
            {
                if (mass[i] == 10 && mass[i + 1] != 10)             //Спэр
                    max += mass[i + 1];
                else if (mass[i] == 10 && mass[i + 1] == 10)        //Страйк
                    max += 10 + mass[i + 2];
            }
            max += min;
            //______________________________________________________________________________________________________
            if (mass[8] == 10 && mass[9] > 10 && mass[9] <= 20)
            {                                                             
                min += mass[9];
                max += 2 * mass[9] - 10;
            }
            if (mass[8] == 10 && mass[9] > 20)
            {                                            
                min += 2 * mass[9] - 20;      
                max += 2 * mass[9] - 10;      
            }
            if(mass[8] != 10 && mass[9] > 10 && mass[9] <= 20)                   
            {
                min += mass[9] - 10;                                      
                max += mass[9] - 10;                                      
            }
            if (mass[8] != 10 && mass[9] > 20)
            {
                min += 10;
                max += 2 * mass[9] - 30;
            }
            Console.WriteLine("{0} {1}", min, max);
        }
    }
}
