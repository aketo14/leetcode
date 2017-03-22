using System.Collections.Generic;

public partial class Solution {
    public int[] TwoSum(int[] nums, int target) {
        var hashMap = new Dictionary<int, int>();
        
        for (int i = 0; i < nums.Length; i++) {
            if (hashMap.ContainsKey(target - nums[i])) {
                var first = hashMap[target-nums[i]];
                var second = i;
                return new int[] { first, second };
            } else {
                if (hashMap.ContainsKey(nums[i])) {
                    hashMap[nums[i]] = i;
                } else {
                    hashMap.Add(nums[i], i);
                }
            }
        }
        
        return new int[] {};
    }
}