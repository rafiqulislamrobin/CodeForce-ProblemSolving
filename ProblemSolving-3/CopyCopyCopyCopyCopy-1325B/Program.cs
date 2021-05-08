using System;
using System.Collections.Generic;
using System.Linq;

namespace CopyCopyCopyCopyCopy_1325B
{
    class Program
    {
        static void Main(string[] args)
        {
            int t = int.Parse(Console.ReadLine());

            while (t != 0)
            {

                int n = int.Parse(Console.ReadLine());

                string[] listText = Console.ReadLine().Split(' ');

                HashSet<int> list = new HashSet<int>();

                for (int i = 0; i < n; i++)
                {
                   
                    list.Add(int.Parse(listText[i]));

                }

                //var duplicates = list.Where(item => !myhash.Add(item)).Distinct().ToList();
                //;


                Console.WriteLine(list.Count);
                t--;
            }
        }
    }
}
