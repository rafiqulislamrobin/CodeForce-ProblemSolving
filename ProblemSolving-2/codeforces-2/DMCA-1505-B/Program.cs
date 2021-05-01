using System;
using System.Collections.Generic;
namespace Is_it_rated___2__1505A
{
    class Program
    {
        static void Main(string[] args)
        {


            int z = int.Parse(Console.ReadLine());
            z = z % 9;
            if (z == 0)
            {
                z = 9;
                Console.WriteLine(z);
            }
            else
            {
                Console.WriteLine(z);
            }
        }
    }
}