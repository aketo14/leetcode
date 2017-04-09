public class Solution {
    public int MajorityElement(int[] nums) {
        Dictionary<int, int> count = new Dictionary<int, int>();
        
        foreach (int num in nums) {
            if (count.ContainsKey(num)) {
                count[num]++;
            } else {
                count.Add(num, 1);
            }
        }
        
        int majority = nums[0];
        foreach (KeyValuePair<int, int> c in count) {
            if (c.Value > count[majority]) {
                majority = c.Key;
            }
        }
        
        return majority;
    }
}