public class Solution {
    public int LongestPalindrome(string s) {
        int[] tally = new int[(int)'z'];
        
        for (int i = 0; i < s.Length; i++) {
            int charCode = (int)s[i] - 'A';
            tally[charCode]++;
        }
        
        bool oddExists = false;
        int evenSum = 0;
        for (int i = 0; i < tally.Length; i++) {
            if (tally[i] % 2 == 0) {
                evenSum += tally[i];
            } else {
                oddExists = true;
                evenSum += tally[i] - 1;
            }
        }
        
        if (oddExists) evenSum++;
        return evenSum;
    }
}