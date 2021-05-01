using System;

namespace Holiday_Of_Equality_758A
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            string[] x = Console.ReadLine().Split(" ");

            int[] arr = new int[n];

            for (int i = 0; i < n; i++)
            {
                arr[i] = int.Parse(x[i]);
            }
            int count = 0;
            Array.Sort(arr);
            for (int i = 0; i < n-1; i++)
            {
                while( arr[i] != arr[n - 1])
                {
                    if (arr[i] != arr[n - 1])
                    {
                        arr[i] += 1;
                        count++;
                    }
                   

                } 
            }
            Console.WriteLine(count);
        }
    }
}
