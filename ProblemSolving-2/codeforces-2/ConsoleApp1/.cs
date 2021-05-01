using System;

namespace _1516A.A_tit_for_tat
{
    class Program
    {
        static void Main(string[] args)
        {
            int t = int.Parse(Console.ReadLine());

            while (t != 0)
            {
                string[] input = Console.ReadLine().Split(" ");
                int n = int.Parse(input[0]);
                int k = int.Parse(input[1]);

                int[] arr = new int[n];

               string[] input2 = Console.ReadLine().Split(" ");
                for (int i = 0; i < n; i++)
                {
                    arr[i] = int.Parse(input2[i]);
                }
                
                int x = 0, y = n - 1;
                while (k!=0)
                {
                    if (arr[x]>0)
                    {
                        arr[x]--;
                        arr[y]++;
                        k--;
                    }
                    else
                    {
                        x++;
                    }
                    if (x==y)
                    {
                        break;
                    }
                }
                for (int i = 0; i < n; i++)
                {
                    Console.Write(arr[i] + " ");
                }
                Console.WriteLine();

                t--;
            }
        }
    }
}