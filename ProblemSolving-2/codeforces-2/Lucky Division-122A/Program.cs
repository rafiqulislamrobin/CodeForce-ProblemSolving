using System;

namespace Lucky_Division_122A
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[] arr =
            {
                4,7,47,74,447,474,477,744,747,774
            };
            int count = 0;
            for (int i = 0; i < 10; i++)
            {
                if (n%arr[i]==0)
                {
                    Console.WriteLine("YES");
                    count++;
                    break;
                }
            }
            if (count==0)
            {
                Console.WriteLine("NO");
            }
            
        }
    }
}
