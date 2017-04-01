public class Solution {
    public string AddStrings(string num1, string num2) {
        int maxLength = Math.Max(num1.Length, num2.Length);
        num1 = num1.PadLeft(maxLength, '0');
        num2 = num2.PadLeft(maxLength, '0');
        
        StringBuilder sb = new StringBuilder();
        
        int carry = 0;
        for (int i = num1.Length - 1; i >= 0; i--) {
            int a = (int)num1[i] - '0';
            int b = (int)num2[i] - '0';
            
            int subResult = 0;
            
            if (a + b + carry > 9) {
                subResult = a + b - 10 + carry;
                carry = 1;
            } else {
                subResult = a + b + carry;
                carry = 0;
            }
            
            sb.Append(subResult);
        }
        
        if (carry == 1) {
            sb.Append("1");
        }
        
        char[] result = sb.ToString().ToCharArray();
        Array.Reverse(result);
        
        return new string(result);
    }
}