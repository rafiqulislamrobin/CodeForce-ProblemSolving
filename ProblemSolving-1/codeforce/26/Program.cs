using System;

namespace _26
{
    class Program
    {
        static void Main(string[] args)
        {


            char[] ch = new char[1000];

           

            for (var i = 0; i < ch.Length; i++)
            {
                ch[i] = Convert.ToChar(Console.Read());
                
                if (ch[i] == '\n')
                {

                    break;
                }
                if (i == 0)
                {
                    if ( Convert.ToInt32(ch[i]) > 91)
                    {
                        ch[i] = char.ToUpper(ch[i]);
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
//////////nice one 
///
