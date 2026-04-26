public class Solution {
    public bool hasDuplicate(int[] nums) {
        HashSet<int> mySet = new HashSet <int>();

        for (int i = 0; i < nums.Length; i++)
        {
            int cur = nums[i];
            if (!mySet.Add(cur))
            {
                return true;
            }
        }
        return false; 
    }
}