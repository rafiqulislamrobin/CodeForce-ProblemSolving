using System;

namespace Ultra_Fast_Mathematician_61A
{
    class Program
    {
        static void Main(string[] args)
        {
            string input1 = Console.ReadLine();
            string input2 = Console.ReadLine();

            char[] m = input1.ToCharArray();
            char[] n = input2.ToCharArray();

            int[] ans = new int[input1.Length];

            for (int i = 0; i < m.Length; i++)
            {
                if (char.GetNumericValue(m[i]) == char.GetNumericValue(n[i]))
                {
                    ans[i] = 0;
                }
                else
                {
                    ans[i] = 1;
                }
                Console.Write(ans[i]);
            }

        }
    }
}
