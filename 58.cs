public class Solution {
    public int LengthOfLastWord(string s) {
        int letterCount = 0;
        bool startedCounting = false;
        
        for (int i = s.Length - 1; i >= 0; i--) {
            if (s[i] == ' ' && letterCount > 0) break;
            if (s[i] == ' ') startedCounting = false;
            if (s[i] != ' ') startedCounting = true;
            if (startedCounting) {
                letterCount++;
            }
        }
        
        return letterCount;
    }
}