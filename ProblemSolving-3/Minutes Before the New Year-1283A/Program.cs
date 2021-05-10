using System;

namespace Minutes_Before_the_New_Year_1283A
{
    class Program
    {
        static void Main(string[] args)
        {
            int t = int.Parse(Console.ReadLine());
            while (t != 0)
            {

                string[] x = Console.ReadLine().Split(' ');

                int h = int.Parse(x[0]);
                int m = int.Parse(x[1]);

                Console.WriteLine((((23 - h) * 60) +(60-m)));


                t--;
            }
        }
    }
}
