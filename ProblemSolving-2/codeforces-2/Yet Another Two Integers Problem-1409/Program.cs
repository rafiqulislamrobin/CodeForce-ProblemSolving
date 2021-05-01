using System;

namespace Yet_Another_Two_Integers_Problem_1409
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(" ");
                int a = int.Parse(input[0]);
                int b = int.Parse(input[1]);
                //if (a<b)
                //{
                //    var temp = a;
                //    a = b;
                //    b = temp;
                //}
                //if (a==b )
                //{
                //    Console.WriteLine(0);
                //}
                //else if ((a-b)%10==0)
                //{
                //    Console.WriteLine((a - b) / 10 );
                //}
                //else
                {
                    Console.WriteLine((((Math.Abs(a - b))+9) / 10));
                }
               
            }
        }
    }
}
