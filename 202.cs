public class Solution {
    public bool IsHappy(int n) {
        HashSet<int> alreadyFound = new HashSet<int>();
        
        while (alreadyFound.Add(n)) {
            int sumOfSquares = 0;
            int digitCount = (int)Math.Floor(Math.Log10(n) + 1);
            for (int i = 0; i < digitCount; i++) {
                int digit = (int)Math.Floor((double)(n / (int)Math.Pow(10.0, digitCount - i - 1)) % 10);
                sumOfSquares += digit * digit;
            }
            
            n = sumOfSquares;
            
            if (n == 1) return true;
        }
        
        return false;
    }
}