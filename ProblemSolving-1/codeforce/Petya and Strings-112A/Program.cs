using System;

namespace Petya_and_Strings_112A
{
    class Program
    {
        static void Main(string[] args)
        {
            string input1 = Console.ReadLine().ToLower();
            string input2 = Console.ReadLine().ToLower();

            if (string.Compare(input1,input2)==0)
            {
                Console.WriteLine("0");
            }
            else if ((string.Compare(input1, input2) > 0))
            {
                Console.WriteLine("1");
            }
            else
            {
                Console.WriteLine("-1");
            }
            //char[] cha1 = input1.ToCharArray();
            //char[] cha2 = input2.ToCharArray();

            //int count = 0;
            //for (int i = 0; i < cha1.Length; i++)
            //{
            //    if (cha1[i] == cha2[i])
            //    {
            //        //aslkjlkasdd
            //        //asdlkjdajwi
            //    }
            //    else if (cha1[i]>cha2[i])
            //    {
                    
            //        count++;
            //    }
            //    else if (cha1[i] < cha2[i])
            //    {
            //        count--;
            //    }
            //}
            ///*onsole.WriteLine(count);*/
            //if (count==0)
            //{
            //    Console.WriteLine("0");
            //}
            //else if (count<0)
            //{
            //    Console.WriteLine("-1");
            //}
            //else
            //{
            //    Console.WriteLine("1");
            //}
        }
        
    }
}
