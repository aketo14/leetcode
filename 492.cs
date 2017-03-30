public class Solution {
    public int[] ConstructRectangle(int area) {
        int a = (int)Math.Sqrt((double)area);
        
        while (area % a != 0) {
            a--;
        }
        
        return new int[] { area / a, a };
    }
}