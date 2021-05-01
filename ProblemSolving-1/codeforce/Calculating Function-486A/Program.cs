using System;

namespace Calculating_Function_486A
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal n = decimal.Parse(Console.ReadLine());

            
            if (n % 2 == 0)
            {
                Console.WriteLine(n/2);
            }
            else
            {
                Console.WriteLine((n-1)/2-n);
            }
           
        }
    }
}
