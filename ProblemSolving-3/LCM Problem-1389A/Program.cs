using System;

namespace LCM_Problem_1389A
{
    class Program
    {
        static void Main(string[] args)
        {
            int t = int.Parse(Console.ReadLine());

            while (t != 0)
            {
                string[] x = Console.ReadLine().Split(' ');
                int l = int.Parse(x[0]);
                int r = int.Parse(x[1]);


                if (l*2>r)
                {
                    Console.WriteLine("-1 -1");
                }
                else
                {
                    Console.WriteLine($"{l} {l*2}");
                }

                t--;
            }

      

        }
    }
}
