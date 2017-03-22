public partial class Solution {
    public int HammingDistance(int x, int y) {
        int n = x ^ y, distance = 0;
        
        while (n != 0) {
            n &= (n - 1);
            distance++;
        }
        
        return distance;
    }
}