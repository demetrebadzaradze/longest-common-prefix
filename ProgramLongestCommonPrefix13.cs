using System;
using System.ComponentModel;
using System.Reflection.Metadata.Ecma335;

namespace Csharpproject
{
    
    class Program
    {
        static void Main(string[] args)
        {
            string[] strings = new string[3];
            string LCP = "";

            Console.WriteLine("enter 1st word");
            strings[0] = Console.ReadLine() ?? "";

            Console.WriteLine("enter 2nd word");
            strings[1] = Console.ReadLine() ?? "";

            Console.WriteLine("enter 3rd word");
            strings[2] = Console.ReadLine() ?? "";

            LCP = LongestCommonPrefix(strings);

            Console.WriteLine();

            for (int i = 0; i < strings.Length; i++)
            {
                Console.WriteLine(strings[i]);
            }

            Console.WriteLine();

            Console.WriteLine(LCP);

        }
        static string LongestCommonPrefix(string[] strs)
        {
            string result = "";
            int max = strs[0].Length;

            for (int i = 1; i < strs.Length; i++)
            {
                if (strs[i].Length <= max)
                {
                    max = strs[i].Length;
                }
            }

            Console.WriteLine(max);

            for (int i = 0; i < max; i++)
            {
                char[] cha = new char[strs.Length];

                for (int j = 0; j < strs.Length; j++)
                {
                    cha[j] = strs[j][i];
                }
                result = SameChars(cha, result, out string res, max );

                if (result[result.Length -1] == '0')
                {
                    return res;
                }
            }

            return result;
        }
        static string SameChars(char[] ch, string result, out string res, int max) 
        {
            char c = '?';
            bool waselse = false;
            for (int i = 1; i < ch.Length; i++)
            {
                if (ch[0] == ch[i])
                {
                    c = ch[0];
                }
                else
                {
                    waselse = true;
                    res = result;
                    return $"{result}0"; 
                }
            }
            if (waselse == false)
            {
                result += c;
            }
            else
            {
                res = result;
                return result;    
            }
            res = result;
            return result;
        }
    } 
}