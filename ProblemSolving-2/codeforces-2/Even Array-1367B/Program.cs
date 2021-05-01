using System;

namespace Even_Array_1367B
{
    class Program
    {
        static void Main(string[] args)
        {
            int t = int.Parse(Console.ReadLine());

            while (t!=0)
            {
               
                int n = int.Parse(Console.ReadLine());
                string[] input = Console.ReadLine().Split(" ");
                int[] a = new int[n];
                for (int i = 0; i < n; i++)
                {
                    a[i] = int.Parse(input[i]);
                }
                int odd = 0, even = 0, ok = 0; 
                for (int i = 0; i < n; i++)
                 {
                    if (i%2==0)
                    {
                        if (a[i] % 2 == 0)
                        {
                            ok++;
                        }
                        else
                        {
                            even++;
                        }
 
                    }
                    else 
                    {
                        if (a[i]%2==1)
                        {
                            ok++;
                        }
                        else
                        {
                            odd++;
                        }
                    }
                }
                if (even==odd)
                {
                    Console.WriteLine(even);
                }
                else if (ok==n)
                {
                    Console.WriteLine("0");
                }
                else
                {
                    Console.WriteLine("-1");
                }
               

                t--;

            }
        }
    }
}
