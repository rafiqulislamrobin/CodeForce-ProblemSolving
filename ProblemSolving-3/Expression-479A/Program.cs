using System;

namespace Expression_479A
{
    class Program
    {
        static void Main(string[] args)
        {

            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());

            int ans5 = a + b + c;
            int ans1 = a + (b * c);
            int ans2 = a * (b + c);
            int ans3 = a * b * c;
            int ans4 = (a + b) * c;

            int result = Math.Max(ans5, ans1);
            result = Math.Max(result, ans2);
            result = Math.Max(result, ans3);
            result = Math.Max(result, ans4);
            Console.WriteLine(result);
        }
    }
}
