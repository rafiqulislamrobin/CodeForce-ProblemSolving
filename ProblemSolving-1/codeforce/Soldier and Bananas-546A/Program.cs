using System;

namespace Soldier_and_Bananas_546A
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(" ");
            long k = int.Parse( input[0]);
            long w = int.Parse(input[2]);
            long n = long.Parse(input[1]);
            long sum = 0;
            //int borrow = 0;
            for (int i = 1; i <= w; i++)
            {
                sum = sum + (i * k);

               
            }
            if (sum<=n )
            {
                Console.WriteLine("0");
            }
            else
            {
                Console.WriteLine(sum - n);
            }
            
            
        }
    }
}
