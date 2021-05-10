using System;

namespace Sereja_and_Dim_381A
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            string[] xText = Console.ReadLine().Split(' ');
            int[] x = new int[n];

            for (int i = 0; i < n; i++)
            {
                x[i] = int.Parse(xText[i]);
            }

            int Sereja = 0, Dima = 0;

            int j = 0;
            int k = n - 1;
          
            for (int i = 0; i < n; i++)
            {
                if (i % 2 == 0)
                {
                    if (x[j] >= x[k])
                    {
                        Sereja += x[j];
                        j++;
                    }
                    else
                    {
                        Sereja += x[k];
                        k--;
                    }
                }
                else
                {
                    if (x[j] >= x[k])
                    {
                        Dima += x[j];
                        j++;
                    }
                    else
                    {
                        Dima += x[k];
                        k--;
                    }
                }
            }
            Console.Write($"{Sereja} {Dima}");
           
        }
    }
}
