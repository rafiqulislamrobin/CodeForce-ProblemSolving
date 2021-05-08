using System;

namespace Ichihime_and_Triangle_1337A
{
    class Program
    {
        static void Main(string[] args)
        {
            int t = int.Parse(Console.ReadLine());
            while (t!=0)
            {

                string[] w = Console.ReadLine().Split(' ');

                ulong a = ulong.Parse(w[0]);
                ulong b = ulong.Parse(w[1]);
                ulong c = ulong.Parse(w[2]);
                ulong d = ulong.Parse(w[3]);

                Console.WriteLine($"{b} {c} {c}");

                t--;
            }
        }
    }
}
