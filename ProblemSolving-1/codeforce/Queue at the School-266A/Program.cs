using System;

namespace Queue_at_the_School_266A
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input1 = Console.ReadLine().Split(" ");
            int n = int.Parse(input1[0]);
            int t = int.Parse(input1[1]);

           
            string input = Console.ReadLine();

            char[] cha = input.ToCharArray();

            for (int i = 0; i < t; i++)
            {
                for (int j = 0; j < n-1; j++)
                {
                    if (cha[j] =='B' && cha[j+1] == 'G') 
                    {
                        cha[j] = 'G';
                        cha[j + 1] = 'B';
                        j++;
                    }
                }
                
            }
            //string finalString = new string(cha);
            Console.WriteLine(new string(cha));
            //foreach (var ch in cha)
            //{
            //    Console.Write(ch);
            //}
        }
    }
}
