public class Solution {
    public bool IsPalindrome(string s) 
    {
        //abba
        // ab ba
        // abbba
        // int i = 0;
        // int j = s.Length - 1;
        // while (i < j)
        // {
        //     while (!isAlphaNum(s[i]))
        //     {
        //         i++;
        //     }
        //     while (!isAlphaNum(s[j]))
        //     {
        //         j--;
        //     }

        //     if (i > j)
        //     {
        //         break;
        //     }
        //     else if (char.ToLower(s[i]) != char.ToLower(s[j]))
        //     {
        //         return false;
        //     }
        //     i++;
        //     j--;
        // }
        // return true;
                int l = 0, r = s.Length - 1;

        while (l < r) {
            while (l < r && !isAlphaNum(s[l])) {
                l++;
            }
            while (r > l && !isAlphaNum(s[r])) {
                r--;
            }
            if (char.ToLower(s[l]) != char.ToLower(s[r])) {
                return false;
            }
            l++; r--;
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

