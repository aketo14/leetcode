using System;

public partial class Solution {
    public int SingleNumber(int[] nums) {
        var result = nums[0];
        for (int i = 1; i < nums.Length; i++) {
            result ^= nums[i];
        }
        
        return result;
    }

    public int SingleNumberOne(int[] nums) {
        if (nums.Length == 1) return nums[0];
        Array.Sort(nums);
        
        for (int i = 1; i < nums.Length; i++) {
            if (nums[i - 1] != nums[i] && i == 1) {
                return nums[0];
            }
            
            if (nums[i - 1] != nums[i] && i == nums.Length - 1) {
                return nums[i];
            }
            
            if (nums[i - 1] != nums[i] && nums[i + 1] != nums[i]) {
                return nums[i];
            }
        }
        
        return -1;
    }
}