using System;

namespace Nastia_and_nearly_Good_Numbers_1521A
{
    class Program
    {
        static void Main(string[] args)
        {
            int t = int.Parse(Console.ReadLine());
            while (t != 0)
            {
                string[] w = Console.ReadLine().Split(' ');
                ulong a= ulong.Parse(w[0]);
                ulong b = ulong.Parse(w[1]);

                ulong z = (a * b);
                if (b == 1)
                {
                    Console.WriteLine("NO");
                }
                else
                {

                    Console.WriteLine("YES");
                    Console.Write($"{z} {a} {z+a}");
                    Console.WriteLine();
                }
             
                t--;
            }
        }
    }
}
