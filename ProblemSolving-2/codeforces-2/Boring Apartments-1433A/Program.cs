using System;

namespace Boring_Apartments_1433A
{
    class Program
    {
        static void Main(string[] args)
        {
            int t = int.Parse(Console.ReadLine());
            while (t!=0)
            {
                string input = (Console.ReadLine());
                int x = int.Parse(input);
                int ans = 0;
                
                for (int i = 1; i <= 9; i++)
                {
                    int total = 0;
                    for (int j = 1; j <= 4; j++)
                    {
                        total =total* 10 + i;

                        ans += j;
                        if (total == x)
                        {
                            Console.WriteLine(ans);
                            break;
                        }

                    }
                   
                }
                t--;
            }
        }
    }
}
