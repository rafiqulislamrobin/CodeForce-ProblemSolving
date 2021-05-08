using System;

namespace Fair_Division_1472B
{
    class Program
    {
        static void Main(string[] args)
        {
            int t = int.Parse(Console.ReadLine());

            while (t != 0)
            {

                int n = int.Parse(Console.ReadLine());

                string[] wText = Console.ReadLine().Split(' ');

                int[] w = new int[n];

                int count1 = 0, count2 = 0;

                for (int i = 0; i < n; i++)
                {
                    w[i] = int.Parse(wText[i]);

                  
                }
                Array.Sort(w);
                Array.Reverse(w);

                for (int i = 0; i < n; i++)
                {
                    if (count1 <= count2)
                    {
                        count1 += w[i];
                    }
                    else
                    {
                        count2 += w[i];
                    }

                }
                if (count1==count2)
                {
                    Console.WriteLine("YES");
                }
                else
                {
                    Console.WriteLine("NO");
                }

                t--;
            }
        }
    }
}
