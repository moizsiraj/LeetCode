﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class ValidParanthesis
    {
        /*My Approach / Optimal Apporach*/
        /*use a stack to keep all types of opening braces
         * pop the stack whenever you see a closing brace
         * if on pop the braces don't match return false
         * return stack.empty at the end
         */

        private string _String;

        public ValidParanthesis(string @string)
        {
            _String = @string;
        }
        //20 mins
        public bool Solve()
        {
            Stack<char> stack = new();
            for (int i = 0; i < _String.Length; i++)
            {
                if (_String.ElementAt<char>(i) == '(' || _String.ElementAt<char>(i) == '[' || _String.ElementAt<char>(i) == '{')
                    stack.Push(_String.ElementAt<char>(i));
                else
                { 
                    if(stack.Count == 0)
                        return false;
                    var openingBracket = stack.Pop();
                    if (openingBracket == '(' && _String.ElementAt<char>(i) == ')')
                        continue;
                    else if (openingBracket == '[' && _String.ElementAt<char>(i) == ']')
                        continue;
                    else if (openingBracket == '{' && _String.ElementAt<char>(i) == '}')
                        continue;
                    else
                        return false;
                }
            }
            return stack.Count == 0;
        }
    }
}
