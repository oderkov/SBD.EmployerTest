namespace SBD.EmployerTest.TreeNodes
{
    public static class TreeNodeReflector
    {
        public static TreeNode ReflectTree(TreeNode root)
        {
            var temporaryNode = root.Left;
            root.Left = root.Right;
            root.Right = temporaryNode;

            if (root.Left != null)
                ReflectTree(root.Left);
            if (root.Right != null)
                ReflectTree(root.Right);
            return root;
        }
    }
}
