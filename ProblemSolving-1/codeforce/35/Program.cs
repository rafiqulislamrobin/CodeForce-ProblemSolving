using System;

namespace _35
{


    /// <summary>
    /// //////////////// onnnnnnnnnnnnk ksu janlam :) thnx eto tym maira khawar jonne :) 
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            char[] x = new char[n+2];
            char[] y = new char[n];
            int m = 0;


            int count = 0;

            for (var i = 0; i < n+2; i++)
            {
                x[i] = Convert.ToChar(Console.Read());

            }
            for (var i = 0; i < n; i++)
            {
                y[i] = Convert.ToChar(Console.Read());
  
            }

            for( var j = 0; j < x.Length; j++)
            {
                if (x[j]!='\n' && x[j] != '\r')
                {
                    int a = x[j] - '0';
                    int b = y[j] - '0';

                    m = Math.Abs(a - b);

                    if (m > 5)
                    {
                        int s = Math.Max(a, b);
                        int ss = Math.Min(a, b);
                        count += 9 + ss + 1 - s;
                    }
                    else
                        count += m;
                }
                
            }
            Console.WriteLine(count);
        }
    }
}
