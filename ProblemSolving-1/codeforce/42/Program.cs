using System;
using System.Linq;

namespace _42
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());            

            for (var j = 0; j <n; j++)
            {
                var count = 0;
                string a = Console.ReadLine();
                string b = Console.ReadLine();
                string c = Console.ReadLine();

                for(var i = 0; i < a.Length; i++)
                {
                    if(a[i] == c[i]  || b[i] == c[i])
                    {
                        count++;
                    }                  
                }
                if (a.Length == count)
                {
                    Console.WriteLine("YES");
                }
                else
                    Console.WriteLine($"NO");                
            }          
        }
    }
}
