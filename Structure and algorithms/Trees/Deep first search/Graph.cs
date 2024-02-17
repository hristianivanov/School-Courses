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
		public void TraverseViaBfs(Graph<T> startVertex)
		{
			HashSet<Graph<T>> visited = new HashSet<Graph<T>>();
			Queue<Graph<T>> queue = new Queue<Graph<T>>();

			queue.Enqueue(startVertex);
			visited.Add(startVertex);

			while (queue.Count > 0)
			{
				Graph<T> currentVertex = queue.Dequeue();
				Console.WriteLine(currentVertex.data + " ");

				foreach (Graph<T> neighbor in currentVertex.neighbors)
				{
					if (!visited.Contains(neighbor))
					{
						queue.Enqueue(neighbor);
						visited.Add(neighbor);
					}
				}
			}
		}
	}
}
