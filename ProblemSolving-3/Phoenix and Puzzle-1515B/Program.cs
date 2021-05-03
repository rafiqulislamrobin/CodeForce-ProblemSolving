using System;

namespace Phoenix_and_Puzzle_1515B
{
    class Program
    {
        static void Main(string[] args)
        {
            int t = int.Parse(Console.ReadLine());

            while (t != 0)
            {
                
                long n = long.Parse(Console.ReadLine());
                double s = Math.Sqrt(n);
                double  s1 = Math.Sqrt(2*n);

                if (n == 1)
                {
                    Console.WriteLine("NO");
                }
                else if (s%2==0 && s*s==n || s1%2==0 && s1*s1==2*n)
                {
                    Console.WriteLine("YES");
                }
                else
                {
                    Console.WriteLine("NO");
                }
               
               
                t--;

            }
        }
    }
}
