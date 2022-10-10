using System;
using System.Collections.Generic;
using static System.Console;

namespace PlayGround
{
    class Program
    {
        static string Solve(string txt)
        {
            int len = txt.Length;
            int count = 2;
            List<string> res = new List<string>();
            for (int i = 0; i < len - 1; i++)
            {
                for (int j = 0; j < len - i - 1; j++)
                {
                    string temp = SubString(txt, j, j + count);
                    if (IsPalindrome(SubString(txt, j, j + count)))
                    {
                        res.Add(SubString(txt, j, j + count));
                        // return SubString(txt, j, j + count);
                    }
                }
                count++;
            }

            string result = "NotPalindrom";
            int max = 0;
            for ( int i = 0; i < res.Count; i++)
            {
                int temp = res[i].Length;
                if ( i == 0)
                {
                    max = temp;
                    result = res[i];
                }
                else if (temp > max)
                {
                    max = temp;
                    result = res[i];
                }
            }
            return result;
        }
        static string SubString(string txt, int start, int end)
        {
            string res = "";
            for (int i = start; i < end; i++)
            {
                res += txt[i];
            }
            return res;
        }
        static bool IsPalindrome(string txt)
        {
            int len = txt.Length;
            for (int i = 0; i < len / 2; i++)
            {
                if (txt[i] != txt[len - i - 1])
                    return false;
            }
            return true;
        }
        static void Run()
        {
            WriteLine("Enter Your text : ");
            string text = "babababab";

            WriteLine(Solve(text));
        }
        static void Main(string[] args)
        {
            Run();
        }
    }
}