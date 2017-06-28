using System;
using System.Collections.Generic;
using System.Linq;

class Solution
{
    static void Main(String[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine());
        
        for(int i = 0; i < n; i++)
        {
            string s = Console.ReadLine();
            
            if (IsBalanced(s))
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }
        }
    }
    
    static bool IsBalanced(string input)
    {
        Stack<char> stack = new Stack<char>();
        
        foreach (char c in input)
        {
            if (c == '[' || c == '{' || c == '(')
            {
                stack.Push(c);
            }
            else
            {
                if (!stack.Any())
                {
                    return false;
                }

                char top = stack.Peek();

                if (top == '[' && c != ']' ||
                    top == '{' && c != '}' ||
                    top == '(' && c != ')')
                {
                    return false;
                }
                else
                {
                    stack.Pop();
                }
            }
        }
        
        return !stack.Any();
    }
}
