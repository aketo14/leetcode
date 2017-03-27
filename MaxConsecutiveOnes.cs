public partial class Solution {
    public int FindMaxConsecutiveOnes(int[] nums) {
        var max = 0;
        var current = 0;
        foreach (var num in nums) {
            if (num == 1) {
                current++;
            } else {
                current = 0;
            }
            
            if (current > max) {
                max = current;
            }
        }
        
        return max;
    }
}