public class Solution {
    public int FindContentChildren(int[] g, int[] s) {
        int count = 0;
        for (int i = 0; i < g.Length; i++) {
            int ssci = -1;
            
            for (int j = 0; j < s.Length; j++) {
                if (ssci < 0 && s[j] >= g[i]) {
                    ssci = j;
                }
                
                if (ssci >= 0 && s[j] >= g[i] && s[j] < s[ssci]) {
                    ssci = j;
                }
            }
            
            if (ssci != -1) {
                s[ssci] = -1;
                count++;
            }
        }
        
        return count;
    }
}


public class Solution {
    public int FindContentChildren(int[] g, int[] s) {
        Array.Sort(g);
        Array.Sort(s);
        
        int count = 0;
        for (int i = 0, j = 0; i < g.Length; i++) {
            if (j >= s.Length) return count;
            
            while (j < s.Length && g[i] > s[j]) {
                j++;
            }
            
            if (j < s.Length && g[i] <= s[j]) {
                count++;
                s[j] = -1;
            }
        }
        
        return count;
    }
}