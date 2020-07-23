using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Linq;

namespace MultiBracketValidation
{
    class Program
    {
        static void Main(string[] args)
        {
            // TEST
            string str1 = "{{}}";
            string str2 = "{}(){}";
            string str3 = "()[[Extra Characters]]";
            string str4 = "(){}[[]]";
            string str5 = "{}{Code}[Fellows](())";
            string str6 = "[({}]";
            string str7 = "(](";
            string str8 = "[(])";

            Console.WriteLine(MultiBracketVal(str1));
            Console.WriteLine(MultiBracketVal(str2));
            Console.WriteLine(MultiBracketVal(str3));
            Console.WriteLine(MultiBracketVal(str4));
            Console.WriteLine(MultiBracketVal(str5));
            Console.WriteLine(MultiBracketVal(str6));
            Console.WriteLine(MultiBracketVal(str7));
            Console.WriteLine(MultiBracketVal(str8));
        }

        /// <summary>
        /// Checks whether the passed in strings containing brackets are 'balanced'
        /// </summary>
        /// <param name="input">string to check</param>
        /// <returns>Returns true or false</returns>
        public static bool MultiBracketVal(string input)
        {
            // identify brackets
            char[] open = { '(', '[', '{' };
            char[] close = { ')', ']', '}' };

            // open / close state of bracket
            int state = 0;
            int idx = 0;
            foreach (char ch in input)
            {
                // if char is a closing bracket
                if (close.Contains(ch))
                {
                    if (state == 0 || ch != close[idx])
                        return false;
                    state--;
                }
                // if char is an open bracket
                if (open.Contains(ch))
                {
                    // assign idx to correct idx postion in arrays
                    switch(ch)
                    {
                        case '(':
                            idx = 0;
                            break;
                        case '[':
                            idx = 1;
                            break;
                        case '{':
                            idx = 2;
                            break;
                    }
                    state++;
                }
            }
            return state == 0;
        }
    }
}
