using System;

namespace Bit___282A
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            int x = 0;

            for (int i = 0; i < input; i++)
            {
                string bit = Console.ReadLine();
                if (bit=="X++" || bit =="++X")
                {
                    x += 1;
                }
                else
                {
                    x -= 1;
                }
            }
            Console.WriteLine(x);
        }
    }
}
