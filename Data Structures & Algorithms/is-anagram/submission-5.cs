// public class Solution {
//     public bool IsAnagram(string s, string t) 
//     {
//         var dictS = new Dictionary <char, int> ();

//         foreach (char charS in s)
//         {
//             dictS[charS] = dictS.GetValueOrDefault(charS) + 1; 
//         }

//         foreach (char charT in t)
//         {
//             if (!dictS.Exists(charT))
//             {
//                 return false;
//             }
//             dictS[charT]--;
//         }
//         foreach (var i in dictS)
//         {
//             if (i.Value != 0)
//             {
//                 return false;
//             }
//         }
//     return true;
//     }
// }


public class Solution {
    public bool IsAnagram(string s, string t) 
    {
        int length = 0;
        if (s.Length != t.Length)
        {
            return false;
        }
        else 
        {
            length = s.Length;
        }

        Dictionary <char, int> dictionaryS = new ();
        foreach (char charS in s)
        {
            dictionaryS[charS] = dictionaryS.GetValueOrDefault(charS) + 1;
        }

        foreach (char c in t)
        {
            if (dictionaryS.ContainsKey(c))
            {
                dictionaryS[c]--;
                if (dictionaryS[c] < 0)
                {
                    return false;
                }
            }
            
        }
        foreach (var value in dictionaryS.Values)
        {
            if (value != 0)
            {
                return false;
            }
        }
        return true;
    }
}

