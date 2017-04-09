public class Solution {
    public string[] FindRelativeRanks(int[] nums) {
        int[] ordering = new int[nums.Length];
        
        for (int i = 0; i < nums.Length; i++) {
            ordering[i] = i;
        }
        
        Array.Sort(nums, ordering);
        Array.Reverse(nums);
        Array.Reverse(ordering);
        
        string[] results = new string[nums.Length];
        
        for (int i = 0; i < nums.Length; i++) {
            if (i == 0) results[ordering[i]] = "Gold Medal";
            else if (i == 1) results[ordering[i]] = "Silver Medal";
            else if (i == 2) results[ordering[i]] = "Bronze Medal";
            else results[ordering[i]] = (i + 1).ToString();
        }
        
        return results;
    }
}