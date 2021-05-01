using System;

namespace Vanya_and_Fence_677A
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(" ");

            int n = int.Parse(input[0]);
            int h = int.Parse(input[1]);
            string[] people = Console.ReadLine().Split(" ");

            int road = 0;
            for (int i = 0; i < n; i++)
            {
                int y =int.Parse(people[i]);
                if (y>h)
                {
                    road += 2;
                }
                else
                {
                    road += 1;
                }
                
            }
            Console.WriteLine(road);
        }
    }
}
