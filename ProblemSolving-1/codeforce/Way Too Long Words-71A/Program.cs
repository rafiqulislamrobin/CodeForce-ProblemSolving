using System;

namespace Way_Too_Long_Words_71A
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());

            for (int i = 0; i < input; i++)
            {
                string inputText = Console.ReadLine();

                if (inputText.Length>10)
                {
                    char[] inputChar = inputText.ToCharArray();
                    int count = 0;                    
                    char first = 'a';
                    char last = 'a';
                    for (int j = 0; j < inputChar.Length; j++)
                    {                        
                        if (j == 0 )
                        {
                            first =inputChar[j];
                        }
                        else if ( j == inputChar.Length-1)
                        {
                            last = inputChar[j];
                        }
                        else
                        {
                            count++;
                        }
                    }
                    Console.WriteLine($"{first}{count}{last}");
                }
                else
                {
                    Console.WriteLine(inputText);
                }
            }
        }
    }
}
