using System;
using System.Collections.Generic;

namespace Restore_the_Permutation_by_Merger_1385B
{
    class Program
    {
        static void Main(string[] args)
        {
            int t = int.Parse(Console.ReadLine());
            while (t!=0)
            {
                int  n = int.Parse(Console.ReadLine());
                string[] x = Console.ReadLine().Split(' ');

                int[] arr = new int[n*2];
                bool[] b = new bool[n * 2];

                for (int i = 0; i < x.Length; i++)
                {
                    arr[i] = int.Parse(x[i]);
                    b[arr[i]] = false;
                }
                

            
                for (int i = 0; i < x.Length; i++)
                {
                    if (b[arr[i]]!=true)
                    {
                        Console.Write($"{arr[i]} ");
                        b[arr[i]] = true;
                    }
                        
                                
 
                }
                Console.WriteLine();
                t--;
            }
        }
    }
}
