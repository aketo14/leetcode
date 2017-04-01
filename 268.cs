public class Solution {
    public int MissingNumber(int[] nums) {
        Array.Sort(nums);
        
        if (nums[0] == 1) return 0;
        
        for (int i = 0; i < nums.Length; i++) {
            if (i == nums.Length - 1 || nums[i + 1] != nums[i] + 1) {
                return nums[i] + 1;
            }
        }
        
        return -1;
    }
}

public class Solution {
    public int MissingNumber(int[] nums) {
        int sum = 0;
        foreach (var num in nums) {
            sum += num;
        }
        
        int sumFromLength = nums.Length * (nums.Length + 1) / 2;
        return sumFromLength - sum;
    }
}