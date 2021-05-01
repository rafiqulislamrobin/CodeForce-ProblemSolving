using System;

namespace _38
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (var i =0;i < n; i++)
            {
                string x = Console.ReadLine();
                string[] splits = x.Split(" ");

                int l1 = int.Parse(splits[0]);
                int r1 = int.Parse(splits[1]);
                int l2 = int.Parse(splits[2]);
                int r2 = int.Parse(splits[3]);

                if (l1 != l2)
                {
                    Console.WriteLine($"{l1} {l2}");
                }
                else if ( l1 != r2)
                {
                    Console.WriteLine($"{l1} {r2}");
                }
                else if (r1 != r2)
                {
                    Console.WriteLine($"{r1} {r2}");
                }
                else if (r1 != l2)
                {
                    Console.WriteLine($"{r1} {l2}");
                }
            }
        }
    }
}
