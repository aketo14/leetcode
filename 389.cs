public class Solution {
    public char FindTheDifference(string s, string t) {
        int sAsciiCount = 0;
        int tAsciiCount = 0;
        
        foreach (var character in s) {
            sAsciiCount += (int)character;
        }
        
        foreach (var character in t) {
            tAsciiCount += (int)character;
        }
        
        return (char)(tAsciiCount - sAsciiCount);
    }
}