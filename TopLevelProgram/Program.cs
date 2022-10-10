using System;
using System.Collections.Generic;
using static System.Console;

#nullable disable

namespace HelloCS
{
    class Program
    {
        static int Solve(string txt)
        {
            string[] letters = new[] {"I", "V", "X", "L", "C", "D",  "M"};
            int[]    vlaues  = new[] { 1 ,  5 ,  10,  50, 100, 500, 1000};
            List<int> res = new List<int>();

            for ( int i = 0; i < txt.Length; i++ )
            {
                int temp = Array.IndexOf(letters, txt[i].ToString());
                res.Add(vlaues[Array.IndexOf(letters, txt[i].ToString())]);
            }

            int result = 0;
            for ( int i = 0; i < res.Count - 1; i++)
            {
                if ( res[i] >= res[i + 1])
                {
                    result += res[i];
                    if ( i == res.Count - 2)
                        result += res[i + 1];
                }
                else
                {
                    result += res[i + 1] - res[i];
                    i++;
                }
            }
            return result;
        }
        static void Run()
        {
            Write("Enter the word : ");
            string word = "MMCDLXXV";

            WriteLine(Solve(word));
        }
        static void Main(string[] args)
        {
            Run();
        }
    }
}
