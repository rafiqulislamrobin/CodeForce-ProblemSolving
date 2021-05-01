using System;

namespace Most_Unstable_Array_1353A
{
    class Program
    {
        static void Main(string[] args)
        {
            int t = int.Parse(Console.ReadLine());
            while (t != 0)
            {
                string[] input = Console.ReadLine().Split(' ');
                int n = int.Parse(input[0]);
                int m = int.Parse(input[1]);


                if (n== 1)
                {
                    Console.WriteLine("0");
                }
                else if (n==2)
                {
                    Console.WriteLine(m);
                }
                else
                {
                    Console.WriteLine(m*2);
                }

                t--;
            }
        }
    }
}
