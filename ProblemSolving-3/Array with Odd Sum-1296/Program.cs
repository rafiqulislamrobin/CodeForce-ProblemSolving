using System;

namespace Array_with_Odd_Sum_1296
{
    class Program
    {
        static void Main(string[] args)
        {
            int t = int.Parse(Console.ReadLine());
            while (t != 0)
            {
                int n = int.Parse(Console.ReadLine());

                int[] arr = new int[n];
                string[] x = Console.ReadLine().Split(' ');
                int o = 0, e = 0;


                for (int i = 0; i < n; i++)
                {
                    arr[i] = int.Parse(x[i]);
                   


                    if (arr[i]%2!=0)
                    {
                        o++;
                    }
                    else
                    {
                        e++;
                    }
                }
                if (o == 0 || o == n && n % 2 == 0)
                {
                 
                    Console.WriteLine("NO");
                }
                else
                {
                    Console.WriteLine("YES");
                }

                t--;
            }
        }
    }
}
