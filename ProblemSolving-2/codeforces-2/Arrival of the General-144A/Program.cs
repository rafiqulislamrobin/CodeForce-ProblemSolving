using System;

namespace Arrival_of_the_General_144A
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int raw_max = 0, raw_min = 0;
            string[] x = Console.ReadLine().Split(" ");

            int max = 0;
            int min = 101;
            for (int i = 0; i < n; i++)
            {
                if (max < int.Parse(x[i]))
                {
                    max = int.Parse(x[i]);
                    raw_max = i;
                }
                if (min >= int.Parse(x[i]))
                {
                    min = int.Parse(x[i]);
                    raw_min = i;
                }
            }
            n = n - 1;

            if (raw_max > raw_min)
            {
                raw_min += 1;


            }
            Console.WriteLine(raw_max + n - raw_min);
        }

    }
}
