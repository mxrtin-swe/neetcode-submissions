public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        Dictionary <int, int> indices = new ();

        for (int i = 0; i < nums.Length; i++)
        {
            int complement = target - nums[i];
            if (indices.ContainsKey(complement))
            {
                return new int[] {indices[complement], i}; 
            }
            else 
            {
                indices.Add(nums[i], i);
            }
        }
        return null;
    }
}
