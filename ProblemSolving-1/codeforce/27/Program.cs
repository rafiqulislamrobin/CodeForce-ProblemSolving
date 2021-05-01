using System;
using System.Collections.Generic;

namespace _27
{
    class Program
    {
        static void Main(string[] args)
        {
        
            char[] ch = new char[102];
           
            int count= 0;
            int count2 = -2; 

            for (var i=0; i <ch.Length; i++)
            {
                ch[i] = Convert.ToChar(Console.Read());
                count2++;
                if (ch[i]=='\n')
                {
                    
                    break;
                }
            }
            for (var i = 1; i < ch.Length; i++)
            {
                if (Convert.ToInt32(ch[i]) > 64 && Convert.ToInt32(ch[i]) < 91)
                {
                    count++;
                }
 
            }
            if (count == count2-1)
            {
                for (var i =0;i < ch.Length; i++)
                {
                    if (Convert.ToInt32(ch[i]) > 64 && Convert.ToInt32(ch[i]) < 91)
                    {
                        (ch[i]) = (char)(97 + (Convert.ToInt32(ch[i])) - 65);
                    }
                    else if (Convert.ToInt32(ch[i]) > 96 && Convert.ToInt32(ch[i]) < 123)
                    {
                        (ch[i]) = (char)(65 + (Convert.ToInt32(ch[i])) - 97);
                    }
                }
            }
            for (var i = 0; i < ch.Length; i++)
            {
                if (Convert.ToInt32(ch[i]) > 64 && Convert.ToInt32(ch[i]) < 123)
                {
                    Console.Write(ch[i]);
                }
            }

        }
    }
}
//mothertoast prblm

