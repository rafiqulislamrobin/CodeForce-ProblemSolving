using System;

namespace _39
{
    class Program
    {
        static void Main(string[] args)
        {
            int white = 0, black = 0;

            for (var i = 1; i < 11; i++)
            {
                for (var j = 1; j < 9; j++)
                {
                    char c = (char)Console.Read();

                    //if (c != '\r' && c=='.')

                    {
                        if (c == 'p')
                            black += 1;
                        else if (c == 'q')
                            black += 9;
                        else if (c == 'r')
                            black += 5;
                        else if (c == 'b')
                            black += 3;
                        else if (c == 'n')
                            black += 3;
                        //if (c == 'k')
                        //     white +=
                        else if (c == 'P')
                            white += 1;
                        else if (c == 'Q')
                            white += 9;
                        else if (c == 'R')
                            white += 5;
                        else if (c == 'B')
                            white += 3;
                        else if (c == 'N')
                            white += 3;

                    }



                }
                Console.WriteLine();
            }
            if (white < black)
            {
                Console.WriteLine("Black");
            }
            else if (white > black)
            {
                Console.WriteLine("White");
            }
            else
            {
                Console.WriteLine("Draw");
            }
               

            Console.WriteLine($"black {black} =white {white}");

        } 
    }
}



//
//string x = Console.ReadLine();
//char[] c = x.Split('');

//for (var k =0; k<x.Length; k++)
//{
//    if (c[k] == "p")
//        black += 1;
//    else if (c[k] == "q")
//        black += 9;
//    else if (c[k] == "r")
//        black += 5;
//    else if (c[k] == "b")
//        black += 3;
//    else if (c[k] == "n")
//        black += 3;
//    //if (c == 'k')
//    //     white +=
//    else if (c[k] == "P")
//        white += 1;
//    else if (c[k] == "Q")
//        white += 9;
//    else if (c[k] == "R")
//        white += 5;
//    else if (c[k] == "B")
//        white += 3;
//    else if (c[k] == "N")
//        white += 3;