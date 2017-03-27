public class Solution {
    public bool DetectCapitalUse(string word) {
        if (word == word.ToUpper()) return true;
        if (word == word.ToLower()) return true;
        
        word = word.Substring(1);
        if (word == word.ToLower()) return true;
        
        return false;
    }
}