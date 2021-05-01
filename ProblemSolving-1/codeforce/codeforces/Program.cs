using System;

namespace codeforces

{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());

            for (int i = 0; i < a; i++)
            {
                
                int n = int.Parse(Console.ReadLine());
                string[] arrText = Console.ReadLine().Split(" ");
                int[] arr = new int[n];
                for (int j  = 0; j < n; j++)
                {
                    arr[j]=int.Parse(arrText[j]);
                }
                for (int j = 0; j < n-1; j++)
                {
                    if (arr[j]!=arr[j+1])
                    {
                        if (j==0 )
                        {
                            if (arr[j+1]==arr[j+2])
                            {
                                Console.WriteLine(j+1);
                                break;
                            }
                            else
                            {
                                Console.WriteLine(j+2);
                                break;
                            }
                        }                       
                        else if (j+1==n-1)
                        {
                            Console.WriteLine(j + 2);
                        }
                        else if (j != 0)
                        {
                            Console.WriteLine(j+2);
                            break;
                        }
                    }
                }
            }            
        }
    }
}
