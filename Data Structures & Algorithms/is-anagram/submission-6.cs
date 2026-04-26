public class Solution {
    public bool IsAnagram(string s, string t) 
    {
        if (s.Length != t.Length)
        {
            return false;
        }
        const int kAlphabetCount = 26;
        // Bucket Sort
        int[] arrS = new int[kAlphabetCount];
        int[] arrT = new int[kAlphabetCount];

        for (int i = 0; i < s.Length; i++)
        {
            int indexS = s[i] - 'a';
            int indexT = t[i] - 'a';
            arrS[indexS] += 1;
            arrT[indexT] += 1;
        }
        for (int i = 0; i < kAlphabetCount; i++)
        {
            if (arrS[i] != arrT[i])
            {
                return false;
            }
        }
        return true;
    }
}


