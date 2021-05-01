using System;

namespace Two_Arrays_And_Swaps_1353B
{
    class Program
    {
        static void Main(string[] args)
        {
            int t= int.Parse(Console.ReadLine());
            while (t!=0)
            {
                string[] input = Console.ReadLine().Split(" ");

                int n = int.Parse(input[0]);
                int k = int.Parse(input[1]);

                string[] aString = Console.ReadLine().Split(" ");
                string[] bString = Console.ReadLine().Split(" ");

                int[] a = new int[n];
                int[] b = new int[n];

                for (int i = 0; i < n; i++)
                {
                    a[i] = int.Parse(aString[i]);
                }
                for (int i = 0; i < n; i++)
                {
                    b[i] = int.Parse(bString[i]);
                }
                Array.Sort(a);
                Array.Sort(b);
                int j = n - 1;
                for (int i = 0; i < k; i++)
                {
                        if (a[i]<b[j])
                        {
                            var temp = b[j];
                            b[j] = a[i];
                            a[i] = temp;
                            j--;
                        }                    
                }
                int ans = 0;
                for (int i = 0; i < n; i++)
                {
                    ans += a[i];
                }
                Console.WriteLine(ans);
                t--;
            }
        }
    }
}
