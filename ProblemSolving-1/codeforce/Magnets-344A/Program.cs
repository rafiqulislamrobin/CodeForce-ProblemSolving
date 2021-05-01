using System;

namespace Magnets_344A
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int count = 1;
            string[] z = new string[n];
            for (int i = 0; i < n; i++)
            {
                z[i] = Console.ReadLine();

            }
            for (int i = 0; i < n-1; i++)
            {
                if (z[i] ==z[i+1])
                {

                }
                else
                {
                    count++;
                }
            }
            Console.WriteLine(count);
        }
    }
}
