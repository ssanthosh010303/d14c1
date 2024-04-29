/*
 * Author: Sakthi Santhosh
 * Created on: 29/04/2024
 */
public class Solution
{
    private int _minDepth = int.MaxValue;

    public async Task MinDepthFinder(TreeNode node, int currentDepth = 0)
    {
        currentDepth++;

        if (node.left == null && node.right == null)
        {
            _minDepth = int.Min(_minDepth, currentDepth);
        }

        if (node.left != null)
            MinDepthFinder(node.left, currentDepth);
        if (node.right != null)
            MinDepthFinder(node.right, currentDepth);
    }

    public int MinDepth(TreeNode root)
    {
        if (root == null) return 0;

        MinDepthFinder(node: root);
        return _minDepth;
    }
}
