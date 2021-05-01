using System;

namespace Insomnia_cure_148A
{
    class Program
    {
        static void Main(string[] args)
        {
            int k = int.Parse(Console.ReadLine());
            int l = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());
            int d = int.Parse(Console.ReadLine());

            int count = 0;
            for (int i = 1; i <= d; i++)
            {
                if (i%k==0 || i % l == 0 || i % n == 0|| i % m == 0)
                {
                    count++;
                }

                
            }
            Console.WriteLine(count);
        }
    }
}
