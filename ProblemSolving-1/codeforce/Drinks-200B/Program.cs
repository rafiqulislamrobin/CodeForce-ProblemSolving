using System;

namespace Drinks_200B
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            string[] z = Console.ReadLine().Split(" ");
            double ans = 0;
            
            for (int i = 0; i < n; i++)
            {
                ans += int.Parse(z[i]);
            }
            Console.WriteLine(ans/n);
        }
    }
}
