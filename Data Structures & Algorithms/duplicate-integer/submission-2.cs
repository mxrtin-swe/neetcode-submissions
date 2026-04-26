public class Solution {
    public bool hasDuplicate(int[] nums) 
    {
        HashSet<int> hashSet = new ();
        for (int i = 0; i < nums.Length; i++) 
        {
            if (!hashSet.Add(nums[i]))
            {
                return true;
            }
        }
        return false;
    }
}