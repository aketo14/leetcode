public class Solution {
    public bool IsValid(string s) {
        if (s.Length % 2 != 0) return false;
        
        Stack<int> stack = new Stack<int>();
        
        for (int i = 0; i < s.Length; i++) {
            if (stack.Count > 0 &&
                ((s[i] == ')' && stack.Peek() == '(') ||
                 (s[i] == '}' && stack.Peek() == '{') ||
                 (s[i] == ']' && stack.Peek() == '['))) {
                stack.Pop();
            } else {
                stack.Push(s[i]);
            }
        }
        
        return stack.Count == 0;
    }
}