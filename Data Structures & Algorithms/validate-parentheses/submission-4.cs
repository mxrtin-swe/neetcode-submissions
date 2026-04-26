public class Solution {
    public bool IsValid(string s) 
    {
        // null
        // ]]
        // [[
        // [
        // ]
        // [}
        
        // Guard Clause
        if (s.Length % 2 != 0)
        {
            return false;
        }

        Stack<char> stack = new();
        for (int i = 0; i < s.Length; i++)
        {
            if (isValidOpenBracket(s[i]))
            {
                stack.Push(s[i]);
            }
            else if (isValidCloseBracket(s[i]))
            {
                if (stack.Count == 0)
                {
                    return false;
                }
                char topStack = stack.Peek();
                
                if (topStack == '(' && s[i] == ')')
                {
                    stack.Pop();
                }
                else if (topStack == '{' && s[i] == '}')
                {
                    stack.Pop();
                }
                else if (topStack == '[' && s[i] == ']')
                {
                    stack.Pop();
                }
                else 
                {
                    return false;
                }
            }
        }
        if (stack.Count != 0)
        {
            return false;
        }
        return true;
    }

    bool isValidOpenBracket (char c)
    {
        if (c == '(' || c == '{' || c == '[')
        {
            return true;
        }
        return false;
    }
    bool isValidCloseBracket(char c)
    {
        if (c == ')' || c == '}' || c == ']')
        {
            return true;
        }
        return false;
    }
}