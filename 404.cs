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
    public int SumOfLeftLeaves(TreeNode root) {
        if (root == null) return 0;
        
        int i = 0;
        if (root.left != null) {
            if (root.left.left == null && root.left.right == null) i += root.left.val;
            else i += SumOfLeftLeaves(root.left);
        }
        
        i += SumOfLeftLeaves(root.right);
        
        return i;
    }
}