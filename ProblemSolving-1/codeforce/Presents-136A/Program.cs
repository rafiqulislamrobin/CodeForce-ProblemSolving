using System;

namespace Presents_136A
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string[] input = Console.ReadLine().Split(" ");

            for (int j = 1; j <=n; j++)
            {
                for (int i = 0; i < n; i++)
                {
                    if (int.Parse(input[i])==j)
                    {
                        Console.Write($"{i + 1} ");
                    }
                }
            }
        }
    }
}
