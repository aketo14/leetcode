public class Solution {
    public bool CanConstruct(string ransomNote, string magazine) {
        if (ransomNote == magazine) return true;
        if (ransomNote.Length > magazine.Length) return false;
        
        var rn = ransomNote.ToCharArray();
        var mg = magazine.ToCharArray();
        
        int count = 0;
        for (int i = 0; i < rn.Length; i++) {
            if (count == rn.Length) return true;
            for (int j = 0; j < mg.Length; j++) {
                if (rn[i] == mg[j]) {
                    mg[j] = '\0';
                    count++;
                    break;
                }
            }
        }
        
        return count == rn.Length;
    }
}

public class Solution {
    public bool CanConstruct(string ransomNote, string magazine) {
        if (ransomNote == magazine) return true;
        if (ransomNote.Length > magazine.Length) return false;
        
        var rn = ransomNote.ToCharArray();
        var mg = magazine.ToCharArray();
        
        Array.Sort(rn);
        Array.Sort(mg);
        
        int count = 0;
        for (int i = 0, j = 0; i < rn.Length; i++) {
            if (count == rn.Length) break;
            
            while (j < mg.Length && mg[j] != rn[i]) {
                j++;
            }
            
            if (j < mg.Length && mg[j] == rn[i]) {
                count++;
                j++;
            }
        }
        
        return count == rn.Length;
    }
}

public class Solution {
    public bool CanConstruct(string ransomNote, string magazine) {
        int[] tally = new int[26];
        
        for (int i = 0; i < ransomNote.Length; i++) {
            int charCode = (int)ransomNote[i] - 'a';
            tally[charCode]++;
            
        }
        
        for (int j = 0; j < magazine.Length; j++) {
            int charCode = (int)magazine[j] - 'a';
            tally[charCode]--;
        }
        
        foreach (var count in tally) {
            if (count > 0) return false;
        }
        
        return true;
    }
}