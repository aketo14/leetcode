public class Solution {
    public string ReverseWords(string s) {
        string[] split = s.Split(' ');
        
        for (int i = 0; i < split.Length; i++) {
            char[] charString = split[i].ToCharArray();
            Array.Reverse(charString);
            split[i] = new string(charString);
        }
        
        return string.Join(" ", split);
    }
}