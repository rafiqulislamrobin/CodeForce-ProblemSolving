using System;

namespace _28
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            string[] splits = input.Split(" ");

            int n = int.Parse(splits[0]);
            int m = int.Parse(splits[1]);


            for(var i=0; i < m; i++)
            {
                if (n % 10 == 0)
                {
                    n = n / 10;
                }
                else
                {
                    n = n - 1;
                }
            }
            Console.WriteLine(n);
        }
    }
}
