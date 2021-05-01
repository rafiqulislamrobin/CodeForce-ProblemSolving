using System;

namespace Red_and_Blue_Beans_1519A
{
    class Program
    {
        static void Main(string[] args)
        {
            int t = int.Parse(Console.ReadLine());
            while (t != 0)
            {
                string[] input = Console.ReadLine().Split(' ');

                int r = int.Parse(input[0]);
                int b = int.Parse(input[1]);
                int d = int.Parse(input[2]);

                if (r<b)
                {
                    var temp = r;
                    r = b;
                    b = temp;
                }



                if ((((r-b)+(b-1))/b)<=d)
                {
                    Console.WriteLine("YES");
                }
                else
                {

                    Console.WriteLine("NO");

                }

                t--;
            }
        }
    }
}
