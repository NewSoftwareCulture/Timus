using System;

namespace Timus1000
{
    class Program
    {
        static void Main(string[] args)
        {
            var str = Console.ReadLine().Split();
            int a = int.Parse(str[0]), b = int.Parse(str[1]);
            Console.WriteLine(a+b);
        }
    }
}
