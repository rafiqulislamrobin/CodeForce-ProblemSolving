using System;
using System.Collections;
using System.Linq;
namespace Alarm_Clock_1354A

{
    class Program
    {
        static void Main(string[] args)
        {
            int t = int.Parse(Console.ReadLine());

            while (t != 0)
            {


                string[] x = Console.ReadLine().Split(' ');
                long a = long.Parse(x[0]);
                long b = long.Parse(x[1]);
                long c = long.Parse(x[2]);
                long d = long.Parse(x[3]);
                long ans = 0;
                if (b >= a)
                {
                    Console.WriteLine(b);

                }
                else if (c <= d)
                {
                    Console.WriteLine("-1");

                }
                else
                {
                    ans = (a - b + c - d - 1) / (c - d) * c + b;
                    Console.WriteLine(ans);
                }


                t--;
            }
        }
    }
}