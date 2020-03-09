using System;

namespace Timus1086
{
    class Program
    {
        static bool mass_check(int i, int[] mass_)      //Проверяет деление числа на элементы массива без остатка
        {
            int count = 0, count_mass=0;
            for(int j = 0; j < mass_.Length; j++)       //Подсчет ненулевых числе в массиве простых чисел
                if (mass_[j] != 0)
                    count_mass++;
            Console.WriteLine("Count mass = {0} // i = {1}", count_mass, i); //Коунт масс индекс, и значение
            for (int j = 0; j < i; j++)
            {
                if (mass_[j] == 0)                      //Если в ячейке пусто, то следующий шаг цикла
                    break;
                else if (i % mass_[j] == 0)
                    return false;
                else
                    count++;
            }
            if (count == count_mass)
                return true;
            return false;
        }

        static void user(int[] nat_numb)
        {
            int enter = Convert.ToInt32(Console.ReadLine());
            int[] enter_ = new int[enter];
            for (int i = 0; i < enter; i++)
                enter_[i] = Convert.ToInt16(Console.ReadLine()) - 1;
            for (int i = 0; i < enter; i++)
                Console.WriteLine("" + nat_numb[enter_[i]]);
        }

        static void Main(string[] args)
        {
            int[] nat_numb = new int[15000];                    //Хранилище простых чисел 
            int count = 0;
            for (int i = 2; count < 15000; i++)                 //Пробегаем по ряду
            {
                if (mass_check(i, nat_numb))                    //Если числа нет в массиве и не делится на числа в массиве без остатка, то...
                {
                    nat_numb[count] = i;
                    count++;
                }
            }
            user(nat_numb);
        }
    }
}
