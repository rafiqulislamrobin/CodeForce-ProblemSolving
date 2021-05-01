using System;

namespace Minimal_Square_1360A
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(" ");

                int x = int.Parse(input[0]);
               int y = int.Parse(input[1]);

                if (x<y)
                {
                    var temp = x;
                    x = y;
                    y = temp;
                }

                int a = Math.Max(x, 2 * y);

                Console.WriteLine(a*a);
            }
        }
    }
}
