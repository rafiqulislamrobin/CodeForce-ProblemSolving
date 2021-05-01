using System;

namespace Required_Remainder_1374A
{
    class Program
    {
        static void Main(string[] args)
        {
            int t= int.Parse(Console.ReadLine());
            while (t!=0)
            {
                string[] input = Console.ReadLine().Split(" ");

                int x = int.Parse(input[0]);
                int y = int.Parse(input[1]);
                int n = int.Parse(input[2]);

                int a = n % x;
                if (a-y>=0)
                {
                    n = n - a + y;
                }
                else
                {
                    n = n - a + y - x;
                }
                Console.WriteLine(n);

                t--;
            }
          
        }
    }
}
