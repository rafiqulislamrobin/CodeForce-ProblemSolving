using System;

namespace Stones_on_the_Table_266A
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());
            string input = Console.ReadLine();
            char[] z = input.ToCharArray();
            int count = 0;

            for (int i = 0; i <input.Length; i++)
            {
                if ( i<x-1)
                {
                    if (z[i]==z[i+1])
                    {
                        count++;
                    }
                }
            }
            Console.WriteLine(count);
        }
    }
}
