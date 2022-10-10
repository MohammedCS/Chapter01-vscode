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
                res.Add(vlaues[Array.IndexOf(letters, txt[i])]);
            }

            int result = 0;
            for ( int i = 0; i < res.Count; i++)
            {
                result += res[i];
            }
            return result;
        }
        static void Run()
        {
            Write("Enter the word : ");
            string word = ReadLine();

            WriteLine(Solve(word));
        }
        static void Main(string[] args)
        {
            Run();
        }
    }
}
