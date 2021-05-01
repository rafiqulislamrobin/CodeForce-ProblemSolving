using System;

namespace _40
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int h0 = 0, m0 = 0;

            int count = 1;
            int cash = 1;
            for (var i = 0; i < n; i++)
            {
                string x = Console.ReadLine();
                string[] splits = x.Split(" ");
                int a = int.Parse(splits[0]);
                int b = int.Parse(splits[1]);

                if (i > 0)
                {
                    if (a == h0 && b == m0)
                    {
                        count += 1;
                        if (count > cash)
                        {
                            cash = count;
                        }

                    }
                    else
                    {
                        count = 1;
                    }

                }
                h0 = a;
                m0 = b;

            }
            Console.WriteLine(cash);
        }
    }
}
