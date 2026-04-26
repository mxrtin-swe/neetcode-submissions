// public class Solution {
//     public int[] TwoSum(int[] nums, int target) {
        
//         Dictionary<int, int> indices = new ();

//         for (int i = 0; i < nums.Length; i++) {
//             // key -> nums value, value -> Index of nums value
//             indices[nums[i]] = i;
//         }

//         foreach (KeyValuePair<int, int> kvp in indices)
//         {
//             Console.WriteLine($"Key: {kvp.Key}, Value: {kvp.Value}");
//         }
        
//         // for (int i = 0; i < nums.Size; i++)
//         // {
//         //     /// Index/Value
//         //     if (dictNums.ContainsKey())
//         //     int complement = target - 

//         // }
//         return null;
//     }
// }


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
