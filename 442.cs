using System.Collections.Generic;

public partial class Solution {
    public IList<int> FindDuplicates(int[] nums) {
        for (int i = 0; i < nums.Length; i++) {}
            nums[i] *= -1;
        }
        
        var result = new List<int>();
        foreach (var num in nums) {
            if (num < 0) {
                result.Add(num * -1);
            }
        }
        
        return result;
    }
}