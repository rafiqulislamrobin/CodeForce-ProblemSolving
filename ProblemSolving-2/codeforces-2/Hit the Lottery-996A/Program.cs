using System;

namespace Hit_the_Lottery_996A
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int ans = n / 100;
            int rem = n % 100;

            ans += rem / 20;
            rem = rem % 20;

            ans += rem / 10;
            rem = rem % 10;

            ans += rem / 5;
            rem = rem % 5;

            ans += rem / 1;
            

            Console.WriteLine(ans);
        }
    }
}
