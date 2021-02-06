using SBD.EmployerTest.TreeNodes;
using Xunit;

namespace SBD.EmployerTest.Tests.TreeNodes
{
    public class TreeNodeReflector
    {
        [Fact]
        public void ReflectTree()
        {
            var node11 = new TreeNode(11)
            {
                Left = null,
                Right = new TreeNode(111)
            };

            var node12 = new TreeNode(12)
            {
                Left = null,
                Right = new TreeNode(121)
            };

            var node1 = new TreeNode(1) { Left = node12, Right = node11 };

            var resultNode = SBD.EmployerTest.TreeNodes.TreeNodeReflector.ReflectTree(node1);

            Assert.NotNull(resultNode.Left?.Left);
            Assert.Equal(111, resultNode.Left?.Left?.Value);
            Assert.NotEqual(11, resultNode.Right.Value);
        }
    }
}
