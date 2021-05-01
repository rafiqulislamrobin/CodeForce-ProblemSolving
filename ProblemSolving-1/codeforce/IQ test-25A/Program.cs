using System;

namespace IQ_test_25A
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int even = 0;
            int odd = 0;

            string[] input = Console.ReadLine().Split(" ");

            for (int i = 0; i < input.Length; i++)
            {
                if (int.Parse(input[i])%2==0)
                {
                    even++;
                }
                else
                {
                    odd++;
                }
            }
            int ans;
            if (even>odd)
            {
                ans = 0;
                for (int i = 0; i < input.Length; i++)
                {
                    if (int.Parse(input[i]) % 2 == 0)
                    {
                        ans++;
                    }
                    else
                    {
                        break;
                    }
                }
                Console.WriteLine(ans+1);
            }
            else
            {
                ans = 0;
                for (int i = 0; i < input.Length; i++)
                {
                    if (int.Parse(input[i]) % 2 == 1)
                    {
                        ans++;
                    }
                    else
                    {
                        break;
                    }
                }
                Console.WriteLine(ans+1);
            }
        }
    }
}
