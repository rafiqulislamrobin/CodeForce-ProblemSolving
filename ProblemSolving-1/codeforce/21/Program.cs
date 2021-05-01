using System;

namespace _21
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            string[] x = new string[n];
            string a = "";
            string b = "";
            int j = 0;

            for (var i =0; i <n; i++)
            {
                x[i] = Console.ReadLine();
              
            }

            string[] y = new string[n];

            for(var i=0; i < n; i++)
            {
                string[] splits = x[i].Split(" ");
                a = splits[0];
                b = splits[1];

                if (b == "rat")
                {
                    y[j] = a;
                    j++;
                }
            }
            for (var i = 0; i < n; i++)
            {
                string[] splits = x[i].Split(" ");
                a = splits[0];
                b = splits[1];

                if (b == "woman" || b=="child")
                {
                    y[j] = a;
                    j++;
                }
            }
            for (var i = 0; i < n; i++)
            {
                string[] splits = x[i].Split(" ");
                a = splits[0];
                b = splits[1];

                if (b == "man")
                {
                    y[j] = a;
                    j++;
                }
            }
            for (var i = 0; i < n; i++)
            {
                string[] splits = x[i].Split(" ");
                a = splits[0];
                b = splits[1];

                if (b == "captain")
                {
                    y[j] = a;
                    j++;
                }
            }
            for (var i = 0; i < n; i++)
            {
                Console.WriteLine(y[i]);
            }
                
        }
    }
}
