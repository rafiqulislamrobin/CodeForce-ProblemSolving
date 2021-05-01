using System;

namespace Nearly_Lucky_Number_110A
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            char[] c = s.ToCharArray();
            int cou = 0;

            for (int i = 0; i < s.Length; i++)
            {
                if (c[i] =='7'||c[i] =='4')
                {
                    cou++;
                }
            }
            if (cou==4 || cou==7)
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }
         
            
        }
    }
}
