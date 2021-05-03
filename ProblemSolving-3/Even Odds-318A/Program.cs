using System;
using System.Collections.Generic;
namespace Even_Odds_318A
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');
            ulong n = ulong.Parse(input[0]);
            ulong k = Convert.ToUInt64(input[1]);

            ulong c;

            if (n%2==0)
            {
                c = n / 2;
            }
            else
            {
                c = (n + 1) / 2;
            }
            if (k<=c)
            {
                Console.WriteLine((k*2)-1);
            }
            else
            {
                Console.WriteLine((k-c)*2);
            }

           
            
        }
    }
}
