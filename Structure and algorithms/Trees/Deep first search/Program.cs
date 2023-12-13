namespace Tree_implementation
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Tree<int> tree = new Tree<int>(-3,
						new Tree<int>
										(4, 
											new Tree<int>(2),
										new Tree<int>
											(1,
											new Tree<int>(9)
										),
									new Tree<int>(10)
										),
								new Tree<int>(3)
						);

			tree.TraverseViaDfs(tree);

			Console.WriteLine(new string('-', 30));

			tree.TraverseViaBfs(tree);
		}
	}
}