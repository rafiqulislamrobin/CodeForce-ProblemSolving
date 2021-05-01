using System;

namespace The_cake_is_lie__1519B
{
    class Program
    {
        static void Main(string[] args)
        {
            int t = int.Parse(Console.ReadLine());
            while (t != 0)
            {
                string[] input = Console.ReadLine().Split(' ');


                int n = int.Parse(input[0]);
                int m = int.Parse(input[1]);
                int k = int.Parse(input[2]);


                if ((n * m) - 1 == k)
                {
                    Console.WriteLine("YES");
                }
                else
                {
                    Console.WriteLine("NO");
                }
                t--;
            }
        }
    }
}