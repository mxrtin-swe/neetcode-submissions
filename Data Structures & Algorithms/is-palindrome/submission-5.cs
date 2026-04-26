public class Solution {
    public bool IsPalindrome(string s) 
    {
        //abba
        // ab ba
        // abbba
        int i = 0;
        int j = s.Length - 1;
        while (i < j)
        {
            while ( i < j && !isAlphaNum(s[i]))
            {
                i++;
            }
            while (j > i && !isAlphaNum(s[j]))
            {
                j--;
            }

            if (i > j)
            {
                break;
            }
            else if (char.ToLower(s[i]) != char.ToLower(s[j]))
            {
                return false;
            }
            i++;
            j--;
        }
        return true;
    }

    private bool isAlphaNum(char c)
    {
        return (
        c >= 'A' && c <= 'Z' ||
        c >= 'a' && c <= 'z' ||
        c >= '0' && c <= '9');
    }
}

