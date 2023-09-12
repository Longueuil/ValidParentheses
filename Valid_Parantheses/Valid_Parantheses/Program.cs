using System;
using System.Collections.Generic;

public class Solution
{
    public bool IsValid(string s)
    {
        Stack<char> stack = new Stack<char>();

        foreach (char c in s)
        {
            // check if one of the brackets is opened and if
            // it is opened - add to the stack
            if (c == '(' || c == '{' || c == '[')
            {
                stack.Push(c); 
            }
            else
            {
                //if stack is empty - return false. It means that we don't have opened brackets
                if (stack.Count == 0)
                {
                    return false; 
                }
                // extrack first element from the stack
                //if stack don't have opened and closed brackets we return false
                char top = stack.Pop(); 
                if (c == ')' && top != '(' ||
                    c == '}' && top != '{' ||
                    c == ']' && top != '[')
                {
                    return false; 
                }
            }
        }
        // check if all opened brackets was closed
        return stack.Count == 0; 
    }
}

class Program
{
    static void Main()
    {
        Solution solution = new Solution();

        string s1 = "()";
        Console.WriteLine(solution.IsValid(s1)); 

        string s2 = "()[]{}";
        Console.WriteLine(solution.IsValid(s2)); 

        string s3 = "(]";
        Console.WriteLine(solution.IsValid(s3)); 
    }
}
