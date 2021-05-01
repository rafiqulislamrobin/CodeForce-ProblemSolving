using System;

namespace Maximum_GCD_1370
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            while (n!=0)
            {
                int x = int.Parse(Console.ReadLine());

                Console.WriteLine(x / 2);
                
                n--;
            }
        }
    }
}
