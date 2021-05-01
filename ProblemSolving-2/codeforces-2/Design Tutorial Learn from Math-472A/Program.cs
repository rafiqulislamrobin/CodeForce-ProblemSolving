using System;

namespace Design_Tutorial_Learn_from_Math_472A
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            if (n%2==0)
            {
                Console.WriteLine($"8 {n-8}");
            }

            else
            {
                Console.WriteLine($"9 {n-9}");
            }
        }
    }
}
