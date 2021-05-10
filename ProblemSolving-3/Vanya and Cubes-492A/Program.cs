using System;

namespace Vanya_and_Cubes_492A
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int count = 0;

            int total=0;
            int z = 0;
           
            for (int i = 1;( total+count+i) <= n; i++)
            {
                count += i;
                total += count;
                z++;
            }
            Console.WriteLine(z);
        }
    }
}
