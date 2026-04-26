public class Solution {
    public int Search(int[] nums, int target) {
        int leftIndex = 0;
        int rightIndex = nums.Length - 1;
        while (leftIndex <= rightIndex )
        {
            int centerIndex = leftIndex + (rightIndex - leftIndex) / 2;
            if (nums[centerIndex] == target)
            {
                return centerIndex;
            }
            else if (target < nums[centerIndex])
            {
                rightIndex = centerIndex - 1;
            }
            else if (target > nums[centerIndex])
            {
                leftIndex = centerIndex + 1;
            }
        }   
        return -1;
    }
}