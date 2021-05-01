using System;
using System.Collections;

class GFG
{
    static void Main(string[] args)
    {

        string input = Console.ReadLine();
        string[] inSpltis = input.Split(" ");

        int x = int.Parse(inSpltis[0]);
        int y = int.Parse(inSpltis[1]);

        char[,] z = new char[x, y];
        for (var i = 0; i < x; i++)
        {

            for (var j = 0; j < y; j++)
            {

                {
                    z[i, j] = Convert.ToChar(Console.Read());
                }
                if (z[i, j] == '\r' || z[i, j] == '\n')
                {
                    j--;
                }
            }
        }
        string ajaira = Console.ReadLine();
        string mz = Console.ReadLine();
        string[] mzSplits = mz.Split(" ");
        int[] m = new int[mzSplits.Length];

        for (var i = 0; i < mzSplits.Length; i++)
        {
            m[i] = int.Parse(mzSplits[i]);
        }
        int k = 0;
        int result = 0;
               
        for (var i = 0; i < y; i++)
        {
          int a = 0, b = 0,c = 0, d = 0, e = 0;
            for (var j = 0; j < x; j++)
            {
                if(z[j,i]=='A')
                {
                    a++;
                }
                if (z[j, i] == 'B')
                {
                    b++;
                }
                if (z[j, i] == 'C')
                {
                    c++;
                }
                if (z[j, i] == 'D')
                {
                    d++;
                }
                if (z[j, i] == 'E')
                {
                    e++;
                }
            }
            if (a >= b && a >= c && a >= d && a >= e)
            {
                k = a;
            }
            else if (a <= b && b >= c && b >= d && b >= e)
            {
                k = b;
            }
            else if (c >= a && b <= c && c >= d && c >= e)
            {
                k = c;
            }
            else if (d >= b && d >= c && d >= a && d >= e)
            {
                k = d;
            }
           else if (e >= b && e >= c && e >= d && a <= e)
            {
                k = e;
            }
            result = result + m[i] * k;
        }
        Console.WriteLine(result);          
    }
}