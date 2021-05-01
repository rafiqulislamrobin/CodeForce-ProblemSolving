using System;

namespace Remove_Smallest_1399A
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            
           while(n!=0)
            {
                int count = 0;
                int x = int.Parse(Console.ReadLine());
                string[] input = Console.ReadLine().Split(" ");
                int[] z = new int[x];
                for (int i = 0; i < x; i++)
                {
                    z[i] = int.Parse(input[i]);
                }
                Array.Sort(z);
                for (int i = 1; i < x; i++)
                {
                    if ((z[i]-z[i-1])>1)
                    {
                       
                        count++;
                        break;
                    }
                }
                if (count>=1)
                {
                    Console.WriteLine("NO");
                }
                else
                {
                    Console.WriteLine("YES");
                }
            
                n--;
            }
        }
    }
}
