using System;

namespace Timus2056
{
    class Program
    {
        static void Main(string[] args)
        {
            int numb = Convert.ToInt32(Console.ReadLine());         
            double sum = 0;
            bool check_3 = false;
            int[] rating = new int[numb];
            for (int i = 0; i < numb; i++)                          
            {
                rating[i] = Convert.ToInt32(Console.ReadLine());
                sum = rating[i] + sum;
                if (rating[i] == 3)
                    check_3 = true;
            }
            sum = sum / numb;                                       
            if(check_3 == true)
                Console.WriteLine("None");
            else if(sum == 5)
                Console.WriteLine("Named");
            else if(sum >= 4.5)
                Console.WriteLine("High");
            else
                Console.WriteLine("Common");
        }
    }
}
