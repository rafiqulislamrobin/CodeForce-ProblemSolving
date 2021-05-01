using System;

namespace Buying_Shovels_1360D
{
    class Program
    {
        static void Main(string[] args)
        {
             int t= int.Parse(Console.ReadLine());

            while (t!=0)
            {

                string[] input = Console.ReadLine().Split(' ');
                long n = long.Parse(input[0]);
                long k = long.Parse(input[1]);

                long ans = n;

                for (long i = 1; i*i <= n; i++)
                {
                    if (n%i==0)
                    {


                        if (i<=k)
                        {
                            ans = Math.Min(ans, n / i);
                        } 
                        if (n/i<=k)
                        {
                            ans = Math.Min(ans, i);
                        }
                    }
                }
                Console.WriteLine(ans);
                t--;
            }
        }
    }
}
