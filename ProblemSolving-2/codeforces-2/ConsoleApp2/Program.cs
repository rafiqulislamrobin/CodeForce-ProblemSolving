using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            int t = int.Parse(Console.ReadLine());

            while (t!=0)
            {
                int n = int.Parse(Console.ReadLine());
                string[] x = Console.ReadLine().Split(" ");
                double isOk = 0; ;
                for (int i = 0; i < n; i++)
                {
                    if ((Convert.ToInt32(Math.Sqrt(int.Parse(x[i]))) * Convert.ToInt32(Math.Sqrt((int.Parse(x[i])))) )!= (int.Parse(x[i])))
                    {
                        isOk = 1;
                    }
                }
                
                if (isOk!=1)
                {
                    Console.WriteLine("NO");
                }
                else
                {
                    Console.WriteLine("YES");
                }
                t--;
            }
        }
    }
}
