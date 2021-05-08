using System;

namespace EhAb_AnD_gCd_1325A
{
    class Program
    {
        static void Main(string[] args)
        {
            int t = int.Parse(Console.ReadLine());
            while (t!=0)
            {
                int n = int.Parse(Console.ReadLine());

                Console.WriteLine($"{1} {n-1}");

                t--;
            }
        }
    }
}
