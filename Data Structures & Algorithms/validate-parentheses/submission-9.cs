public class Solution {
    public bool IsValid(string s) 
    {
        Dictionary <char, char> dictionary = new Dictionary <char, char>
        {
            {')', '('},
            {'}', '{'},
            {']', '['}
        };
        Stack <char> stack = new();
        foreach (char c in s)
        {
            if (dictionary.ContainsKey(c) && stack.Count > 0 && dictionary[c] == stack.Peek())
            {
                stack.Pop();
            }
            else if (dictionary.ContainsValue(c))
            {
                stack.Push(c);
            }
            else 
            {
                return false;
            }
        }
        if (stack.Count > 0)
        {
            return false;
        }
        return true;
    }
}