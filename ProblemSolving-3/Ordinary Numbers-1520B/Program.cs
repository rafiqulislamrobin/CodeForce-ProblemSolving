using System;

namespace Ordinary_Numbers_1520B
{
    class Program
    {
        static void Main(string[] args)
        {
            ulong t = ulong.Parse(Console.ReadLine());
            while (t != 0)
            {
                string x = Console.ReadLine();
                ulong n = ulong.Parse(x);

                ulong ans = 0;
                for (ulong i = 1; i <=9 ; i++)
                {
                    ulong now = i;
                    while (now<=n)
                    {
                        ans++;
                        now = now * 10 + i;
                    }
                    
                }
                Console.WriteLine(ans);

                t--;
            }
        }
    }
}
