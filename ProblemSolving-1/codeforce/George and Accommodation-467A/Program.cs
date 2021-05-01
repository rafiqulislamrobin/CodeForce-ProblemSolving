using System;

namespace George_and_Accommodation_467A
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int count = 0;

            for (int i = 0; i < n; i++)
            {
                string[] z = Console.ReadLine().Split(" ");
                int p = int.Parse(z[0]);
                int q = int.Parse(z[1]);
                if ((q-p)>=2)
                {
                    count++;
                }
            }
            Console.WriteLine(count);
        }
    }
}
