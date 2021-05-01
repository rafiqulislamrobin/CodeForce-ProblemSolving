using System;
using System.Linq;

namespace _23
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] x = new char[100005];
            char[] y = new char[100005];
            int a = 0,b=0,count=0;

            for (var i = 0; i < x.Length; i++)
            {
                x[i] = Convert.ToChar((Console.Read()));

                if (x[i] == '\n')
                    break;
             
            }
            for (var i = 0; i < y.Length; i++)
            {
                y[i] = Convert.ToChar((Console.Read()));

                if (y[i] == '\n')
                    break;
            }
            if (x.Length != y.Length)
            {
                Console.WriteLine("NO");
            }
            else
            {
                for (var i = 0; i < 100005; i++)
                {
                    if (y[i] == '\n' || (x[i] == '\n'))

                        break;
                    else
                    {
                        if (x[i] != y[i])
                            count++;

                        if (count > 2)
                        {
                            Console.WriteLine("NO");
                            break;
                        }
                        a = a + Convert.ToInt32(x[i]);
                        b = b + Convert.ToInt32(y[i]);
                    }
                }
                if(count < 3)
                {
                    if (a == b)
                    {
                        Console.WriteLine("YES");
                    }
                    else
                        Console.WriteLine("NO");
                }
            }
        }
    }
}
