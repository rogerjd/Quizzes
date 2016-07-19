using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quizzes
{
    static class ReverseWords
    {
        const string inStr = "The quick brown fox, jumped over the lazy dog.";
        static string delims = ", .";

        public static void Run()
        {
            string word = "";
            string res = "";

            for (int i = 0; i < inStr.Length; i++)
            {
                if (delims.Contains(inStr[i]))
                {
                    if (word != "")
                    {
                        res += RevWord(word);
                        word = "";
                    }
                    res += inStr[i];
                }
                else
                {
                    word += inStr[i];

                    //last char is not a delim
                    //could also add delim to input str, if missing
                    if (i == inStr.Length-1) 
                    {
                        res += RevWord(word);
                        word = "";
                    }
                }
            }
            Console.WriteLine(res);
            Console.ReadLine();
        }

        private static string RevWord(string word)
        {
            string res = "";
            for (int i = word.Length - 1; i >= 0; i--)
            {
                res += word[i];
            }
            return res;
        }
    }
}
