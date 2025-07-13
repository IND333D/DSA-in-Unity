using System.Collections.Generic;
using UnityEngine;

public class ValidParenthesis : MonoBehaviour
{
    public string input;

    private void Start()
    {
        Debug.Log(IsValid(input));
    }
    //, { '(',')' }, { '{','}' }, { '[' ,']' }
    public bool IsValid(string s)
    {
        if (s.Length % 2 != 0)
            return false;

        Stack<char> stack = new Stack<char>();

        foreach (char c in s)
        {
            if( c == '(' || c == '{' || c == '[')
            {
                stack.Push(c);
            }
            else
            {
                if(stack.Count == 0)
                {
                    return false;
                }

                char top = stack.Pop();

                if( c == ')' && top != '(' || c == ']' && top != '[' || c == '}' && top != '{')
                {
                    return false ;
                }
            }
        }
        return stack.Count == 0;
    }
}
