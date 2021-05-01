using System;

namespace Array_and_Peaks_1513A
{
    class Program
    {
        static void Main(string[] args)
        {

            int t = int.Parse(Console.ReadLine());
            
            while (t!=0)
            {
                string[] input = Console.ReadLine().Split(" ");
                int n = int.Parse(input[0]);
                int k = int.Parse(input[1]);

                int  b = (n + 1) / 2;
                int d = n;
               
                int c = 1;
                int i = 1;
                if (k>=b)
                {
                    Console.WriteLine("-1");
                }
                else
                {
                    while (c<=d)
                    {
                        if (c % 2 == 0 && k > 0)
                        {
                            Console.Write(n-- + " ");
                            k--;
                        }
                        else
                        {
                            Console.Write($"{i++} ");

                        }
                            c++;
                        
                    }
                }
                Console.WriteLine();

                t--;

            }
        }
    }
}
