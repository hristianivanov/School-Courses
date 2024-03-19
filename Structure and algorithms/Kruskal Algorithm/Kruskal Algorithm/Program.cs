namespace Kruskal_Algorithm
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Vertex v1 = new(1);
			Vertex v2 = new(2);
			Vertex v3 = new(3);
			Vertex v4 = new(4);
			Vertex v5 = new(5);
			Vertex v6 = new(6);
			Vertex v7 = new(7);

			List<Vertex> vertices = new List<Vertex>() { v1, v2, v3, v4, v5, v6, v7 };

			List<Edge> edges = new List<Edge>()
			{
				new Edge(v1,v2,2),
				new Edge(v1,v3,1),
				new Edge(v2,v1,2),
				new Edge(v2,v3,5),
				new Edge(v2,v6,5),
				new Edge(v3,v1,1),
				new Edge(v3,v2,5),
				new Edge(v3,v4,5),
				new Edge(v3,v5,2),
				new Edge(v4,v3,5),
				new Edge(v4,v5,2),
				new Edge(v5,v3,2),
				new Edge(v5,v4,2),
				new Edge(v5,v6,3),
				new Edge(v6,v2,5),
				new Edge(v6,v5,3),
				new Edge(v6,v7,100),
				new Edge(v7,v6,100),
			};
			List<Edge> sortedEdges = edges.OrderBy(edge => edge.weight).ToList();

			Tree[] trees = new Tree[]
			{
				new Tree(1),
				new Tree(2),
				new Tree(3),
				new Tree(4),
				new Tree(5),
				new Tree(6),
				new Tree(7),
			};

			int count = 0;
			List<Edge> pickedEdges = new List<Edge>();
			while (pickedEdges.Count < vertices.Count - 1)
			{
				Edge currentEdge = sortedEdges[count];
				Tree rootOne = Find(trees[currentEdge.from.data - 1], trees);
				Tree rootTwo = Find(trees[currentEdge.to.data - 1], trees);

				if (rootOne != rootTwo)
				{
					if (rootOne.height > rootTwo.height)
					{
						rootTwo.parent = rootOne.vertex;
					}
					else
					{
						rootOne.parent = rootTwo.vertex;
						rootTwo.height = Math.Max(rootTwo.height, rootOne.height + 1);
					}

					pickedEdges.Add(currentEdge);
				}

				count++;
			}

			foreach (Edge edge in pickedEdges)
			{
				Console.WriteLine($"Edge from {edge.from.data}, to {edge.to.data} with weight {edge.weight}");
			}
			Tree Find(Tree root, Tree[] trees)
			{
				if (root.vertex != root.parent)
				{
					Tree currentRoot = Find(trees[root.parent - 1], trees);
					root.parent = currentRoot.vertex;

					return currentRoot;
				}

				return root;
			}
		}
	}
}
