using System;

namespace Honest_Coach_1360B
{
    class Program
    {
        static void Main(string[] args)
        {
            int t = int.Parse(Console.ReadLine());

            while (t != 0)
            {
                int n = int.Parse(Console.ReadLine());
                string[] arr = Console.ReadLine().Split(" ");
                int[] x = new int[n];

                for (int i = 0; i < n; i++)
                {
                    x[i] = int.Parse(arr[i]);

                }
                
                Array.Sort(x);

                int mini = 20000000;
                for (int i = 1; i < n; i++)
                {
                    mini = Math.Min(mini, (x[i] - x[i - 1]));
                }
                Console.WriteLine(mini);
                t--;

            }
        }
    }
}
