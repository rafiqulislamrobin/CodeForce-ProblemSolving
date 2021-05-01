using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(" ");
            decimal m =int.Parse (input[0]);
            decimal n = int.Parse(input[1]);
            decimal a = int.Parse(input[2]);

            decimal ans = Math.Ceiling(n / a) * Math.Ceiling(m / a);

            Console.WriteLine(ans);

        }
    }
}
