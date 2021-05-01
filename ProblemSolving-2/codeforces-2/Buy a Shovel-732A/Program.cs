using System;

namespace Buy_a_Shovel_732A
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(" ");
            int k = int.Parse(input[0]);
            int r = int.Parse(input[1]);
            int ans = 0;

            for (int i = 1; i < 1000; i++)
            {
                ans = i * k;
                int rem = ans % 10;
                if (rem==r || rem==0)
                {
                    Console.WriteLine(i);
                    break;
                }
            }
        }
    }
}
