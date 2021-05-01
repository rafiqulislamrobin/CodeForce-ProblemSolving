using System;

namespace _1201importantExam
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, j;
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());
            string[] answers = new string[x];
            int a = 0, b = 0, c = 0, d = 0, e = 0;
            for (i = 0; i < x; i++)
            {
                answers[i] = Console.ReadLine().ToLower();
            }
            char[][] anschar = new char[x][];
            for (i = 0; i < x; i++)
            {
                anschar[i] = answers[i].ToCharArray();
            }
            int[] marks = new int[y];
            for (i = 0; i < y; i++)
            {
                marks[i] = int.Parse(Console.ReadLine());
            }
            int count = 0, result = 0;
            for (i = 0; i < y; i++)
            {
                a = 0; b = 0; c = 0; d = 0; e = 0;
                for (j = 0; j < x; j++)
                {

                    if (anschar[j][i] == 'a')
                    { a++; }
                    if (anschar[j][i] == 'b')
                    { b++; }
                    if (anschar[j][i] == 'c')
                    { c++; }
                    if (anschar[j][i] == 'd')
                    { d++; }
                    if (anschar[j][i] == 'e')
                    { e++; }
                }
                if (a >= b && a >= c && a >= d && a >= e)
                { count = a; }
                else if (a <= b && b >= c && b >= d && b >= e)
                { count = b; }
                else if (c >= b && a <= c && c >= d && c >= e)
                { count = c; }
                else if (d >= b && d >= c && a <= d && d >= e)
                { count = d; }
                else if (e >= b && e >= c && e >= d && a <= e)
                { count = e; }


                result = result + marks[i] * count;

            }
            Console.WriteLine(result);
        }
    }
}