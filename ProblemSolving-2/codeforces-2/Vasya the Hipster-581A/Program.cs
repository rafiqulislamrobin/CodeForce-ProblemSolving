using System;

namespace Vasya_the_Hipster_581A
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(" ");

            int a = int.Parse(input[0]);
            int b = int.Parse(input[1]);

            int differentShocks = 0;
            int sameShocks = 0;

            while (a!=0 && b!=0)
            {
                if (a > 0 && b > 0)
                {
                    a -= 1;
                    b -= 1;
                    differentShocks++;
                } 
            }

            while (a > 1 || b > 1)
            {
                if (a > 1 || b > 1)
                {
                    a -= 2;
                    b -= 2;
                    sameShocks++;
                } 
            }
            Console.WriteLine($"{differentShocks} {sameShocks}");

        }
    }
}
