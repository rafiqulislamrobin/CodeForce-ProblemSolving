using System;

namespace Domino_piling_50A
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(" ");
            int m = int.Parse(input[0]);
            int n =Convert.ToInt32( input[1]);

            Console.WriteLine((m*n)/2);

        }
    }
}
