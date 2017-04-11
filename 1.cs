public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        for (int i = 0; i < nums.Length; i++) {
            for (int j = 0; j < nums.Length; j++) {
                if (i != j && nums[i] + nums[j] == target) {
                    return new int[] { i, j };
                }
            }
        }
        
        return new int[]{};
    }
}

public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        Dictionary<int, int> hash = new Dictionary<int, int>();
        
        for (int i = 0; i < nums.Length; i++) {
            int remaining = target - nums[i];
            if (hash.ContainsKey(remaining) && i != hash[remaining]) {
                return new int[] { hash[remaining], i };
            }
            
            if (hash.ContainsKey(nums[i])) {
                hash[nums[i]] = i;
            } else {
                hash.Add(nums[i], i);   
            }
        }
        
        return new int[]{};
    }
}