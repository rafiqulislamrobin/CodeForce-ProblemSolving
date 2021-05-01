using System;

namespace Short_Substrings_1347A
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            
            while (n!=0)
            {
                string input = Console.ReadLine();
                char[] ch = input.ToCharArray();
                string ans = "";
                for (int i = 0; i < input.Length-1; i++)
                {
                    if (i==0)
                    {
                        ans += ch[i].ToString();
                    }
                     else if (ch[i]==ch[i-1])
                    {
                        ans += ch[i].ToString();
                        i++;
                    }
                }
                ans += ch[input.Length - 1].ToString();

                Console.WriteLine(ans);
                n--;
            }
           

           
        }
    }
    
}
