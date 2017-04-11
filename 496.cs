public class Solution {
    public int[] NextGreaterElement(int[] findNums, int[] nums) {
        int[] results = new int[findNums.Length];
        
        int i = 0;
        foreach (int fn in findNums) {
            bool looking = false;
            results[i] = -1;
            
            foreach (int n in nums) {
                if (fn == n) {
                    looking = true;
                }
                
                if (looking && n > fn) {
                    results[i] = n;
                    break;
                }
            }
            
            i++;
        }
        
        return results;
    }
}