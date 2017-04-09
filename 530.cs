/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int x) { val = x; }
 * }
 */
public class Solution {
    int prev = Int32.MinValue;
    int min = Int32.MinValue;
    
    public int GetMinimumDifference(TreeNode root) {
        if (root.left != null) GetMinimumDifference(root.left);
        
        if (prev != Int32.MinValue && (min == Int32.MinValue || min > root.val - prev)) {
            min = root.val - prev;
        }
        
        prev = root.val;
        
        if (root.right != null) GetMinimumDifference(root.right);
        
        return min;
    }
}