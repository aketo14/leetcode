using System.Collections.Generic;

public partial class Solution {
    public string[] FindWords(string[] words) {
        var topRow = new char[] { 'q', 'w', 'e', 'r', 't', 'y', 'u', 'i', 'o', 'p' };
        var middleRow = new char[] { 'a', 's', 'd', 'f', 'g', 'h', 'j', 'k', 'l' };
        var bottomRow = new char[] { 'z', 'x', 'c', 'v', 'b', 'n', 'm' };
        
        List<string> results = new List<string>();
        
        foreach (var word in words) {
            var topPossible = true;
            var middlePossible = true;
            var bottomPossible = true;
            
            foreach (var character in word.ToLower()) {
                if (!letterInRow(character, topRow)) topPossible = false;
                if (!letterInRow(character, middleRow)) middlePossible = false;
                if (!letterInRow(character, bottomRow)) bottomPossible = false;
            }
            
            if (topPossible || middlePossible || bottomPossible) {
                results.Add(word);
            }
        }
        
        return results.ToArray();
    }
    
    public bool letterInRow(char letter, char[] row) {
        foreach (var character in row) {
            if (character == letter) {
                return true;
            }
        }
        
        return false;
    }
}