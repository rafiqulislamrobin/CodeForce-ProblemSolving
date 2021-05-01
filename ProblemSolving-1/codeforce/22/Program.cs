using System;

namespace _22
{
    class Program
    {
        static void Main(string[] args)
        {
            string inp1 = Console.ReadLine();
            string[] inp1Splits = inp1.Split(" ");

            int n = int.Parse(inp1Splits[0]);
            int x = int.Parse(inp1Splits[1]);

            string nx = Console.ReadLine();
            long d = 0;
           for (var i =0; i < n; i++)
            {
                string[] xn = nx.Split(" ");
                int a = int.Parse(xn[i]);

                d = d * x;
                d = d + a;
            }

            string inp2 = Console.ReadLine();
            string[] inp2Splits = inp2.Split(" ");

            int m = int.Parse(inp2Splits[0]);
            int y = int.Parse(inp2Splits[1]);

            string my = Console.ReadLine();
           long  e = 0;
            for (var i = 0; i < m; i++)
            {
                string[] ym = my.Split(" ");
                int b = int.Parse(ym[i]);

                e =(e * y);
                e = e + b;
            }


            if(d<e)
                Console.WriteLine("<");

            else if(d>e)
                Console.WriteLine(">");

            else
                Console.WriteLine("=");
        }
    }
}
