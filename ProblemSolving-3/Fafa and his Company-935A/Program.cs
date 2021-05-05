using System;

namespace Fafa_and_his_Company_935A
{
    class Program
    {
        static void Main(string[] args)
        {
            ulong t = ulong.Parse(Console.ReadLine());

            int count = 1;
            for (ulong i = 2; i < t; i++)
            {
                if (t % i == 0)
                {
                    count++;
                }
            }
            Console.WriteLine(count);
        }
    }
}
