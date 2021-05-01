using System;

namespace Divisibility_Problem_1328A
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int i = 0;
            for ( i = 0; i < n; i++)
            {
                int count = 0; ;
                string[] input = Console.ReadLine().Split(" ");
                int a = int.Parse(input[0]);
                int b = int.Parse(input[1]);

                if (a % b == 0)
                {
                    Console.WriteLine(count);
                }
                else
                {
                    Console.WriteLine(b-a%b);
                }
            }
        }
    }
}
