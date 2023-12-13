namespace Tree_implementation
{
	public class Graph<T>
	{
		private T data;
		private readonly ICollection<Graph<T>> neighbors;
		private string color;

		public Graph(T data, params Graph<T>[] neighbors)
		{
			this.data = data;
			this.neighbors = neighbors.ToList();
			this.color = "white";
		}

		public void TraverseViaDfs(Graph<T> vertex)
		{
			vertex.color = "gray";

			foreach (Graph<T> neighbor in neighbors)
			{
				if (neighbor.color == "white")
					TraverseViaDfs(neighbor);
			}

			vertex.color = "black";
			Console.WriteLine(vertex.data);
		}

		public void TraverseViaBfs(Graph<T> vertex)
		{
			Queue<Graph<T>> queue = new Queue<Graph<T>>();

			queue.Enqueue(vertex);

			while (queue.Count > 0)
			{
				Graph<T> temp = queue.Dequeue();
				foreach (Graph<T> neighbor in temp.neighbors)
				{
					queue.Enqueue(neighbor);
				}
				Console.WriteLine(temp.data + " ");
			}
		}
	}
}
