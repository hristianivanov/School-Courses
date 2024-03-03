namespace S._Rao_Kosaraju_Algorithm
{
	internal class Program
	{
		private static Stack<Vertex> topologicallySortedVertices = new();
		static void Main(string[] args)
		{
			Vertex v1 = new(1);
			Vertex v2 = new(2);
			Vertex v3 = new(3);
			Vertex v4 = new(4);
			Vertex v5 = new(5);
			Vertex v6 = new(6);
			Vertex v7 = new(7);
			Vertex v8 = new(8);
			Vertex v9 = new(9);
			Vertex v10 = new(10);
			Vertex v11 = new(11);

			v1.neighbors.Add(v2);
			v2.neighbors.Add(v3);
			v3.neighbors.Add(v1);
			v3.neighbors.Add(v4);
			v4.neighbors.Add(v5);
			v5.neighbors.Add(v6);
			v6.neighbors.Add(v4);
			v7.neighbors.Add(v6);
			v7.neighbors.Add(v8);
			v8.neighbors.Add(v9);
			v8.neighbors.Add(v11);
			v9.neighbors.Add(v10);
			v10.neighbors.Add(v7);

			List<Vertex> vertices = new List<Vertex>()
			{
				v1,v2,v3,v4,v5,v6,v7,v8,v9,v10,v11
			};

			TopoSort(vertices, topologicallySortedVertices);

			TransposeGraph(vertices);

			List<List<Vertex>> sccs = new();
			FindStronglyConnectedComponents(topologicallySortedVertices, sccs);

			foreach (List<Vertex> scc in sccs)
			{
				Console.WriteLine(string.Join(',', scc.Select(v => v.data)));
			}
		}

		static void FindStronglyConnectedComponents(Stack<Vertex> topoSortedVertices, List<List<Vertex>> sccs)
		{
			foreach (Vertex vertex in topologicallySortedVertices)
			{
				vertex.color = "white";
			}

			while (topoSortedVertices.Count > 0)
			{
				Vertex currentVertex = topologicallySortedVertices.Pop();
				if (currentVertex.color == "white")
				{
					List<Vertex> scc = new();
					FindSccUtil(currentVertex, scc);
					sccs.Add(scc);
				}
			}
		}

		static void FindSccUtil(Vertex vertex, List<Vertex> scc)
		{
			vertex.color = "gray";
			foreach (Vertex neighbor in vertex.neighbors)
			{
				if (neighbor.color == "white")
				{
					FindSccUtil(neighbor, scc);
				}
			}
			vertex.color = "black";
			scc.Add(vertex);
		}

		static void TransposeGraph(List<Vertex> vertices)
		{
			Dictionary<Vertex, List<Vertex>> reversedEdges = new();
			foreach (Vertex vertex in vertices)
			{
				reversedEdges[vertex] = new List<Vertex>();
			}

			foreach (Vertex vertex in vertices)
			{
				foreach (Vertex neighbor in vertex.neighbors)
				{
					reversedEdges[neighbor].Add(vertex);
				}
			}

			foreach (Vertex vertex in vertices)
			{
				vertex.neighbors = reversedEdges[vertex];
			}
		}
		static void TopoSort(List<Vertex> vertices, Stack<Vertex> topologicallySortedVertices)
		{
			foreach (Vertex vertex in vertices)
			{
				if (vertex.color == "white")
				{
					TopoSortUtil(vertex, topologicallySortedVertices);
				}
			}
		}

		static void TopoSortUtil(Vertex vertex, Stack<Vertex> topologicallySortedVertices)
		{
			vertex.color = "gray";
			foreach (Vertex neighbor in vertex.neighbors)
			{
				if (neighbor.color == "white")
				{
					TopoSortUtil(neighbor, topologicallySortedVertices);
				}
			}
			vertex.color = "black";
			topologicallySortedVertices.Push(vertex);
		}
	}
}
