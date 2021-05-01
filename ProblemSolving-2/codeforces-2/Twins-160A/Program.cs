using System;

namespace Twins_160A
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[] arr = new int[n];
            int sum = 0, sum2 = 0, count = 0;
            string[] input = Console.ReadLine().Split(' ');
            for (int i = 0; i < n; i++)
            {
                arr[i] = int.Parse(input[i]);
                sum += arr[i];
            }
            sum = sum / 2;

            Array.Sort(arr);


            for (int i = n-1; i >= 0; i--)
            {
                sum2 += arr[i];
                count++;
                if (sum<sum2)
                {
                    break;
                }
            }
            Console.WriteLine(count);
        }
    }
}
