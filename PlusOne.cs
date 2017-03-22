public partial class Solution {
    // Second Solution
    public int[] PlusOneSecond(int[] digits) {
        
        for (int i = digits.Length - 1; i >= 0; i--) {
            if (digits[i] < 9) {
                digits[i]++;
                return digits;
            }
            
            digits[i] = 0;
        }
        
        var newDigits = new int[digits.Length + 1];
        newDigits[0] = 1;
        
        return newDigits;
    }

    // First Solution
    public int[] PlusOneFirst(int[] digits) {
        int carry = 0;
        
        for (int i = digits.Length - 1; i >= 0; i--) {
            var newDigit = 0;
            if (i == digits.Length - 1) {
                newDigit = digits[i] + 1 + carry;
            } else {
                newDigit = digits[i] + carry;
            }
            
            carry = 0;
            if (newDigit > 9) {
                carry += 1;
                newDigit -= 10;
            }
            
            digits[i] = newDigit;
        }
        
        if (carry != 0) {
            var newArray = new int[digits.Length + 1];
            newArray[0] = carry;
            for (int i = 1; i < digits.Length; i++) {
                newArray[i] = digits[i - 1];
            }
            
            return newArray;
        }
        
        return digits;
    }
}