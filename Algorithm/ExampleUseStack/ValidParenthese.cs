using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleUseStack
{
    public class ValidParenthese
    {
        public bool IsValid(string s)
        {
            StackArray<char> stackArray = new StackArray<char>(s.Length);
            for(int i = 0; i < s.Length; i++)
            {
                char ch = s[i];
                if(ch == '(' || ch =='{' || ch == '[')
                {
                    stackArray.Push(ch);
                }
                else if (ch == ')' || ch == '}' || ch == ']')
                {
                    if (stackArray.IsEmpty())
                    {
                        return false;
                    }

                    var peek = stackArray.Peek();
                    if (!isMatch(peek, ch))
                    {
                        return false;
                    }
                    stackArray.Pop();
                }
            }
            return stackArray.IsEmpty() == true;
        }

        private bool isMatch(char a, char b)
        {
            if (a == '(' && b == ')')
            {
                return true;
            }
            else if (a == '{' && b == '}')
            {
                return true;
            }
            else if (a == '[' && b == ']')
            {
                return true;
            }
            return false;
        }
    }
}
