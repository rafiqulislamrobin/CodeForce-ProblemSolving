using System;

namespace Maximum_in_Table_509A
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[,] a = new int[20, 20];
            for (int i = 1; i <= n; i++)
            {
                a[i, 1] = a[1,i] = 1;
            }
            for (int i = 2; i <= n; i++)
            {
                for (int j = 2; j <= n; j++)
                {
                    a[i, j] = a[i - 1, j] + a[i, j - 1];
                }
            }
            Console.WriteLine(a[n,n]);
         }
    }
}
