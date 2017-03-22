using System.Text;

public partial class Solution {
    public string ReverseString(string s) {
        var builder = new StringBuilder();
        
        for (int i = s.Length - 1; i >= 0; i--) {
            builder.Append(s[i]);
        }
        
        return builder.ToString();
    }
}