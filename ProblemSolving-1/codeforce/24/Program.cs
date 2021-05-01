using System;

namespace _24
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] x = new int[4];
            int[] y = new int[4];
            int ans = -1;
           for (var i=0; i < n; i++)
            {
                string m = Console.ReadLine();
                string[] splits = m.Split(" ");

                 x[i] = int.Parse(splits[0]);
                 y[i] = int.Parse(splits[1]);

                if (n <2)
                {

                    break;
                }
            }
            for (var i = 0; i < n; i++)
            {
                for(var j=0; j < n; j++)
                {
                    if (x[i] != x[j] && y[i] != y[j])
                        ans = Math.Abs(x[i] - x[j]) * Math.Abs(y[i] - y[j]);
                }
            }
                Console.WriteLine(ans);
           
        }
    }
}

//math sutro pari nai nije :)






