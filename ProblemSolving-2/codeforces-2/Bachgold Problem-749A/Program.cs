using System;

namespace Bachgold_Problem_749A
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            if (n % 2 == 0)
            {
                Console.WriteLine(n/2);
                for (int i = 0; i < n/2; i++)
                {
                    Console.Write("2 ");
                }
            }
            else
            {
                Console.WriteLine(n/2);
                for (int i = 0; i < (n/2)-1; i++)
                {
                    Console.Write("2 ");
                }
                Console.Write("3 ");
            }
        }
    }
}
