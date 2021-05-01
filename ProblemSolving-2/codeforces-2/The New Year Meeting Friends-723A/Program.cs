using System;

namespace The_New_Year_Meeting_Friends_723A
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(" ");

            int[] x = new int[input.Length];
            for (int i = 0; i < input.Length; i++)
            {
                x[i] = int.Parse(input[i]);
            }
            Array.Sort(x);

            int ans = (x[2] - x[0]);
            Console.WriteLine(ans);
        }
    }
}
