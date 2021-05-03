using System;

namespace Phoenix_and_Gold_1515A
{
    class Program
    {
        static void Main(string[] args)
        {
            int t = int.Parse(Console.ReadLine());

            while (t != 0)
            {
                string[] input = Console.ReadLine().Split(' ');
                int n = int.Parse(input[0]);
                int x = int.Parse(input[1]);

                string[] input2 = Console.ReadLine().Split(' ');

                int[] arr = new int[n];
                for (int i = 0; i < n; i++)
                {
                    arr[i] = int.Parse(input2[i]);
                }
                bool flag = false;
                int coin = arr[0];

                Array.Sort(arr);
                Array.Reverse(arr);
                for (int i = 0; i < n; i++)
                {
                    if (coin==x)
                    {
                        
                        flag = true;
                        
                        break;
                    }
                
                    else
                    {
                        if (i>0)
                        {
                            coin += arr[i];
                        }
                      
                    }
                }
                if (!flag)
                {
                    
                    Console.WriteLine("YES");
                    for (int i = 0; i < n; i++)
                    {
                        Console.Write($"{arr[i]} ");
                    }

                }
                else
                {
                    Console.WriteLine("NO");
                    for (int i = 0; i < n; i++)
                    {
                        Console.Write($"{arr[i]} ");
                    }

                }
                t--;
                if (t>0)
                {
                    Console.WriteLine();
                }
               
               

                
            }
        }
    }
}
