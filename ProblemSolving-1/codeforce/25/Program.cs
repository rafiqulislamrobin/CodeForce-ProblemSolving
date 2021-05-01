using System;

namespace _25
{
    class Program
    {
        static void Main(string[] args)
        {           
            char[] x = new char[100];
            int count1 = 0;
            int c1 = 0;
            int count2 = 0;
            int c2 = 0;

            for (var i = 0; i < x.Length; i++)
            {
                x[i] = Convert.ToChar(Console.Read());
                if (x[i] == '\n')
                {

                    break;
                }
               if (x[i] == '0')
                {
                    count1++;
                    count2 = 0;
                    if (count1 > c1)
                    {
                        c1 = count1;
                    }
                }
                else
                {
                    count2++;
                    count1 = 0;
                    if (count2 > c2)
                    {
                        c2 = count2;
                    }                    
                }                    
            }
           if(c1>=7 || c2 >= 7)
            {
                Console.WriteLine("YES");
            }
           else
                Console.WriteLine("NO");
        }
       
    }
}
