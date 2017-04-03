public class Solution {
    public bool IsPowerOfTwo(int n) {
        if (n <= 0) return false;
        
        n &= (n - 1);
        
        if (n == 0) {
            return true;
        }
        
        return false;
    }
}