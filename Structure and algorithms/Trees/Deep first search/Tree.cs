namespace Tree_implementation
{
	public class Tree<T>
	{
		private T data;
		private List<Tree<T>> children;

		public Tree(T data, params Tree<T>[] children)
		{
			this.data = data;
			this.children = children.ToList();
		}

		public void TraverseViaDfs(Tree<T> root)
		{
			foreach (Tree<T> child in root.children)
			{
				TraverseViaDfs(child);
			}

			Console.WriteLine(root.data + " ");
		}

		public void TraverseViaBfs(Tree<T> root)
		{
			Queue<Tree<T>> queue = new Queue<Tree<T>>();
			queue.Enqueue(root);

			while (queue.Count > 0)
			{
				Tree<T> temp = queue.Dequeue();
				foreach (Tree<T> child in temp.children)
				{
					queue.Enqueue(child);
				}
				Console.WriteLine(temp.data + " ");
			}
		}

		public bool BinarySearch(Tree<T>? root, T target)
		{
			if (root == null)
				return false;

			int isFound = Comparer<T>.Default.Compare(target, root.data);

			if (isFound == 0)
				return true;
			else if (isFound < 0)
				return BinarySearch(root.children.FirstOrDefault(), target);
			else
				return BinarySearch(root.children.LastOrDefault(), target);
		}

		public void Add(Tree<T> tree, T child)
		{
			
		}
	}
}
