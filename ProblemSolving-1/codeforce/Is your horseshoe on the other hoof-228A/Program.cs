using System;

namespace Is_your_horseshoe_on_the_other_hoof_228A
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] n =Console.ReadLine().Split(" ");
            int count = 0;

            int[] arr = new int[5];
            for (int i = 0; i < n.Length; i++)
            {
                arr[i] = int.Parse(n[i]);
            }

            Array.Sort(arr) ;

            for (int i = 0; i < n.Length; i++)
            {
                if (arr[i]==arr[i+1])
                {
                    count++;
                }
            }
            Console.WriteLine(count);

        }
    }
}
