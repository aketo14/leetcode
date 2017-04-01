public class Solution {
    public IList<string> ReadBinaryWatch(int num) {
        List<string> results = new List<string>();
        
        for (int i = 0; i < 12; i++) {
            for (int j = 0; j < 60; j++) {
                if (BitCount(i) + BitCount(j) == num) {
                    results.Add(String.Format("{0}:{1:D2}", i, j));
                }
            }
        }
        
        return results;
    }
    
    public int BitCount(int num) {
        int count = 0;
        while (num != 0) {
            num &= num - 1;
            count++;
        }
        return count;
    }
}