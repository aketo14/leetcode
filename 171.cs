public class Solution {
    public int TitleToNumber(string s) {
        char[] ca = s.ToCharArray();
        
        int count = 0;
        for (int i = 0; i < ca.Length; i++) {
            count += ((int)ca[i] - 'A' + 1) * (int)Math.Pow((double)26, (double)ca.Length - i - 1);
        }
        
        return count;
    }
}

public class Solution {
    public int TitleToNumber(string s) {
        char[] ca = s.ToCharArray();
        
        int count = 0;
        for (int i = 0; i < ca.Length; i++) {
            count *= 26;
            count += (int)ca[i] - 'A' + 1;
        }
        
        return count;
    }
}