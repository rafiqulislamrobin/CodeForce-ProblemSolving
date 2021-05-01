using System;
namespace ComparingTwoLongIntegers
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] one = new char[1000000];
            char[] two = new char[1000000];
            int i = 0, j = 0, len1, len2;
            one = Console.ReadLine().ToCharArray();
            two = Console.ReadLine().ToCharArray();
            len1 = one.Length; len2 = two.Length;
            while (i < one.Length)
            {
                if (one[i] == '0') { i++; }
                else
                    break;
            }         

            for (j=0; j < two.Length;j++)
            {
                if (two[j] == '0')
                {

                }


                else
                    break;
            }

            if (len1 - i > len2 - j)
            {
                Console.WriteLine(">");
            }
              

            else if (len1 - i < len2 - j)
            {
                Console.WriteLine("<");
            }
                
            else
            {
                Array.Reverse(one); Array.Reverse(two);
                string z = new string(one);
                if (i != 0)
                {
                    z = z.Remove(len1 - i);
                }
                one = z.ToCharArray(); 
                Array.Reverse(one);
                z = new string(one);

                string y = new string(two);
                if (j != 0) 
                {
                    y = y.Remove(len2 - j);
                }
                two = y.ToCharArray();
                Array.Reverse(two);
                y = new string(two);

                if (string.Compare(z, y) == 0)
                    Console.WriteLine("=");

                else if (string.Compare(z, y) > 0)
                    Console.WriteLine(">");
                else
                    Console.WriteLine("<");
            }

        }
    }
}