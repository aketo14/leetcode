public class Solution {
    public string ConvertToBase7(int num) {
        if (num == 0) return "0";
        
        StringBuilder sb = new StringBuilder();
        bool negative = false;
        
        if (num < 0) negative = true;
        while (num != 0) {
            sb.Append(Math.Abs(num % 7));
            num /= 7;
        }
        
        if (negative) sb.Append("-");
        
        char[] result = sb.ToString().ToCharArray();
        Array.Reverse(result);
        return new string(result);
    }
}