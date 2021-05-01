using System;

namespace Gifts_Fixing_1399B
{
    class Program
    {
        static void Main(string[] args)
        {
            int t = int.Parse(Console.ReadLine());
            
           


            for (int i = 0; i < t; i++)
            {
                long miniA = int.MaxValue;
                long miniB = int.MaxValue;
                long count = 0;
                int n = int.Parse(Console.ReadLine());

                string[] input = Console.ReadLine().Split(" ");
                long[] a = new long[n];

                for (int j = 0; j < n; j++)
                {
                    a[j] = long.Parse(input[j]);
                    miniA = Math.Min(miniA, a[j]);
                }
                string[] input2 = Console.ReadLine().Split(" ");
                long[] b = new long[n];

                for (int j = 0; j < n; j++)
                {
                    b[j] = long.Parse(input2[j]);
                    miniB = Math.Min(miniB, b[j]);
                }
                for (int j = 0; j < n; j++)
                {
                    count += Math.Max((a[j] - miniA), (b[j] - miniB));
                }
                Console.WriteLine(count);
              
            }

        }
    }
}
