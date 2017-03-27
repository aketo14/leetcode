public class Solution {
    public IList<int> FindDisappearedNumbers(int[] nums) {
        int n = nums.Length;
        for (int i = 0; i < n; i++) {
            int val = Math.Abs(nums[i]) - 1;
            if (nums[val] > 0) {
                nums[val] *= -1;
            }
        }
        
        List<int> results = new List<int>();
        for (int i = 0; i < n; i++) {
            if (nums[i] > 0) {
                results.Add(i + 1);
            }
        }
        
        return results;
    }
}