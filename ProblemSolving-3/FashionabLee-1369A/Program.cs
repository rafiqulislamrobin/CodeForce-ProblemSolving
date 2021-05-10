using System;

namespace FashionabLee_1369A
{
    class Program
    {
        static void Main(string[] args)
        {
            int t = int.Parse(Console.ReadLine());
            while (t != 0)
            {
                int n = int.Parse(Console.ReadLine());

                if (n%4==0)
                {
                    Console.WriteLine("YES");
                }
                else
                {
                    Console.WriteLine("NO");
                }
                t --;
            }
        }
    }
}
