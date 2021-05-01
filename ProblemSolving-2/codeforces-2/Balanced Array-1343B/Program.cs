using System;

namespace Balanced_Array_1343B
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            while (n!=0)
            {
                int x = int.Parse(Console.ReadLine());
                if (x%4!=0)
                {
                    Console.WriteLine("NO");
                }
                else                {
                    Console.WriteLine("YES");
                    
                    for (int i = 2; i <= x/2; i+=2)
                    {
                        Console.Write($"{x-i} {x+i} ");
                    }
                    for (int i = 1; i < x/2; i+=2)
                    {
                        Console.Write($"{x - i} {x + i} ");                        
                    }
                    Console.WriteLine();
                   
                }
                n--;
            }
        }
    }
}
