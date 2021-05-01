using System;

namespace _35
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] n = new char[2];

            for (var i =0; i < n.Length; i++)
            {
                n[i] = Convert.ToChar(Console.Read());
            }
            string f = Console.ReadLine();
            string x = Console.ReadLine();
            string[] xsplits = x.Split(" ");


            int count = 0;
            for (var j =0; j < xsplits.Length; j++)
            {
                char[] input = new char[2];
                for (var i = 0; i < input.Length; i++)
                {
                    input[i] = xsplits[j][i];

                    if (input[i] == n[i])
                    {
                        count++;
                        break;
                    }
                }
            }
            if (count > 0)
            {
                Console.WriteLine("YES");
            }
            else
                Console.WriteLine("NO");
        }
    }
}
