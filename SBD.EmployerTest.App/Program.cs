using SBD.EmployerTest.Tools;
using SBD.EmployerTest.TreeNodes;
using System;

namespace SBD.EmployerTest.App
{
	class Program
	{
		static void Main(string[] args)
		{
			int value = 100500;

			var isValid = Tools.Math.IsPowerOfThree(value);
			if (isValid)
			{
				var tree = new TreeNode(100500);
				var reflectedTree = TreeNodeReflector.ReflectTree(tree);
				Console.WriteLine("Сделано");
			}
			else
			{
				Console.WriteLine("Плохое число");
			}

			Console.ReadKey();
		}
	}

}
