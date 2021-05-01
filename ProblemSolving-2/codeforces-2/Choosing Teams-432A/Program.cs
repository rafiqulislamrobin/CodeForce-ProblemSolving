using System;

namespace Choosing_Teams_432A
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(" ");
            int n = int.Parse(input[0]);
            int k = int.Parse(input[1]);

            string[] arrInput = Console.ReadLine().Split(" ");

            int[] arr = new int[n];
            for (int i = 0; i < n; i++)
            {
                arr[i] = int.Parse(arrInput[i]);
            }
            int count = 0;
            for (int i = 0; i < n; i++)
            {
                if (5 - arr[i] >= k)
                {
                    count++;
                }
            }
            Console.WriteLine(count/3);
        }
    }
}
