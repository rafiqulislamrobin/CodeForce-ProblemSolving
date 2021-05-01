using System;

namespace Phoenix_and_Balance_1348A
{
    class Program
    {
        static void Main(string[] args)
        {
            int t = int.Parse(Console.ReadLine());
            while (t!=0)
            {
                int n = int.Parse(Console.ReadLine());
               
                double pile1 = Math.Pow(2,n); double pile2 = 0;
                for (int i = 1; i < n; i++)
                {
                    if (i < n / 2)
                    {
                        pile1 += Math.Pow(2, i);
                    }
                    else
                    {
                        pile2 += Math.Pow(2, i);
                    }
                }
                Console.WriteLine(Math.Abs(pile1-pile2));
                t--;
            }
        }
    }
}
