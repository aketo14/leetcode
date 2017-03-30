public class Solution {
    public int FirstUniqChar(string s) {
        int[] tally = new int[26];
        
        for (int i = 0; i < s.Length; i++) {
            int charCode = (int)s[i] - 'a';
            tally[charCode]++;
        }
        
        for (int i = 0; i < s.Length; i++) {
            int charCode = (int)s[i] - 'a';
            if (tally[charCode] == 1) {
                return i;
            }
        }
        
        return -1;
    }
}