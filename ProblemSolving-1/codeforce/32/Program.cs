using System;

namespace _32
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            //string ajaira = Console.ReadLine();
            string input = Console.ReadLine();
            string[] x = input.Split(" ");

            int count1 = 0;
            int count2 = 0;
            int count3 = 0;

            int compare1 = 0;
            int compare2 = 0;

            int[] a1 = new int[5000];
            int[] a2 = new int[5000];
            int[] a3 = new int[5000];
            

            for (var i =0; i < x.Length; i++)
            {
                int c = int.Parse(x[i]);
                if (c == 1)
                {
                    a1[count1] = i + 1;
                    count1++;
                }
                else if (c == 2)
                {
                    a2[count2] = i + 1;
                    count2++;
                }
                else
                {
                    a3[count3] = i + 1;
                    count3++;
                }
                    
            }
            compare2 = Math.Min(count1, count2);
            compare1 = Math.Min(compare2, count3);
        

            Console.WriteLine(compare1);



            count1 = 0; count2 = 0; count3 = 0;
            while (count1 < compare1 || count2 < compare1 || count3 < compare1)
            {
                Console.WriteLine($"{a1[count1]} {a2[count2]} {a3[count3]}");

                count3++;
                count2++;
                count1++;
            }
               

        }
    }
}
