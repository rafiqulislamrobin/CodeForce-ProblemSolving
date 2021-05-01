using System;

namespace Restoring_Three_Numbers_1154A
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(" ");
            int[] w = new int[input.Length];
            for (int i = 0; i < input.Length; i++)
            {
                w[i]=int.Parse(input[i]);
            }
            Array.Sort(w);

            int a = 0, b = 0, c = 0;

            b = w[3] - w[2];

           
            a = w[0] - b;
            c = w[2] - a;
            Console.WriteLine($"{a} {b} {c}");
        }
    }
}
