using System;
using System.Collections.Generic;
using System.Linq;
namespace I_Wanna_Be_the_Guy_469A
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

         
            string[] xinput = Console.ReadLine().Split(' ');
            string[] yinput = Console.ReadLine().Split(' ');

            int x = int.Parse(xinput[0]);
            int y = int.Parse(yinput[0]);

           
            List<int> p = new List<int>();
            List<int> q = new List<int>();
            for (int i = 1; i <= x; i++)
            {
                p.Add( int.Parse(xinput[i]));
            }
            for (int i = 1; i <= y; i++)
            {
                q.Add(int.Parse(yinput[i]));
            }

            List <int> result = (p.Union(q)).ToList();
         
            if (result.Count==n)
            {
                Console.WriteLine("I become the guy.");
            }
            else
            {
                Console.WriteLine("Oh, my keyboard!");
            }

        }
    }
}
