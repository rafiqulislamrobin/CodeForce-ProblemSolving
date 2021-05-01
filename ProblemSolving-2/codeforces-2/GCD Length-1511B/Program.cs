using System;

namespace GCD_Length_1511B
{
    class Program
    {
        static void Main(string[] args)
        {

            int t = int.Parse(Console.ReadLine());

            for (int i = 0; i < t; i++)
            {
                string[] input = Console.ReadLine().Split(" ");

                double x = double.Parse(input[0]);
                double y = double.Parse(input[1]);
                double n = double.Parse(input[2]);

                x = Math.Pow(10, (x - 1)) +Math.Pow(10,(n-1));
                y = Math.Pow(10, (y - 1));

                Console.WriteLine($"{(int)x} {(int)y}");
            }

        }
    }
}
