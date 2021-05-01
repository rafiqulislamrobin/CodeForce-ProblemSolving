using System;

namespace I_Wanna_Be_the_Guy_469A
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            string[] input1 = Console.ReadLine().Split(" ");
            int p = int.Parse(input1[0]);


            string[] input2 = Console.ReadLine().Split(" ");
            int q = int.Parse(input2[0]);

            int count = 0;
            int[] arr = new int[n*2];

            for (int i = 0; i < p; i++)
            {
                arr[i] = int.Parse(input2[i]);
            }
            for (int i = p; i <p+ q; i++)
            {
                arr[i] = 0;
            }

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < p+q; j++)
                {
                    if (arr[j]==i)
                    {
                        count++;
                        break;
                    }
                }
            }
            if (count==n)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }


        }
    }
}
