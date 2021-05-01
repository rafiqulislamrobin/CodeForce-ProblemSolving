using System;

namespace Candies_and_Two_Sisters_1335A
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                double z = int.Parse(Console.ReadLine());
                double x = Math.Ceiling(z / 2);
                if (x>0 && z > 2)
                {
                    Console.WriteLine(x-1);
                }
                else
                {
                    Console.WriteLine("0");
                }
                
            }
        }
    }
}
