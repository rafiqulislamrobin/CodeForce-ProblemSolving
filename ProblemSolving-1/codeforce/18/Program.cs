using System;

namespace _18
{
    class Program
    {
        static void Main(string[] args)
        {
            string a = Console.ReadLine();

            string[] x = new string[10];

            for(var i = 0; i < 10; i++)
            {
                x[i] = Console.ReadLine();
            }
            for (var i = 0; i < 8; i++)
            {
                string z = (a.Substring(i * 10, 10));

                for(var j=0; j<10;j++)
                {
                    if (z == x[j])
                    {
                        Console.Write(j);
                        break;
                    }
                    
                }
            }
        }
    }
}
