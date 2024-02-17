namespace Tree_implementation
{
	internal class Program
	{
		static void Main(string[] args)
		{

		}

		private static Tree<int> ImplementationSecond()
		{
			return new Tree<int>(15,
			   new Tree<int>(10,
				   new Tree<int>(5,
					   new Tree<int>(3),
					   new Tree<int>(7,
						   new Tree<int>(6))
				   ),
				   new Tree<int>(13,
					   new Tree<int>(12,
						   new Tree<int>(11)),
					   new Tree<int>(14)
				   )
			   ),
			   new Tree<int>(20,
				   new Tree<int>(18,
					   new Tree<int>(19)),
				   new Tree<int>(21,
					   new Tree<int>(23)
				   )
			   )
		   );
		}

		private static void ImplementationOne()
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